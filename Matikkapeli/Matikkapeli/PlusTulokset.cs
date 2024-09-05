using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class PlusTulokset : TuloksetPohja
    {
        private const string FileName = "plus_tulokset.txt";
        private Dictionary<string, int> plusTulokset;

        public PlusTulokset() : base()
        {
            InitializeComponent();
            plusTulokset = LoadScores(FileName);
            DisplayScores();
        }

        protected override void DisplayScores()
        {
            foreach (var tulos in plusTulokset)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
