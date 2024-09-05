using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class KertoTulokset : TuloksetPohja
    {
        private const string FileName = "kerto_tulokset.txt";
        private Dictionary<string, int> kertoTulokset;

        public KertoTulokset() : base()
        {
            InitializeComponent();
            kertoTulokset = LoadScores(FileName);
            DisplayScores();
        }

        protected override void DisplayScores()
        {
            foreach (var tulos in kertoTulokset)
            {
                listBox1.Items.Add($"{tulos.Key}: {tulos.Value}");
            }
        }

        private Dictionary<string, int> LoadScores(string fileName)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        scores[parts[0]] = score;
                    }
                }
            }

            return scores;
        }
    }
}
