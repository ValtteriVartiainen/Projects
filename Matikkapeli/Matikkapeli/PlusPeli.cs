using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class PlusPeli : Form
    {
        private Random random = new Random();
        private int laskujenMaara = 0;
        private int oikeidenVastaustenMaara = 0;
        private string kayttajanimi;
        private Dictionary<string, int> plusTulokset;

        public PlusPeli(string kayttajanimi)
        {
            InitializeComponent();
            this.kayttajanimi = kayttajanimi;
            plusTulokset = LoadScores("plus_tulokset.txt");
            vastaus.KeyDown += new KeyEventHandler(vastaus_KeyDown);
        }

        private void PlusPeli_Load(object sender, EventArgs e)
        {
            GenerateRandomAddition();
        }

        private void GenerateRandomAddition()
        {
            if (laskujenMaara < 10)
            {
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);

                
                string addition = $"{num1} + {num2}";

                
                textBox1.Text = addition;

                
                laskujenMaara++;
            }
            else
            {
                MessageBox.Show($"Vastasit oikein {oikeidenVastaustenMaara} kysymykseen kymmenestä.");
                TallennaPisteet();
                Close();
            }
        }

        private void lukitseV_Click(object sender, EventArgs e)
        {
            string vastaus1 = vastaus.Text;

            int vastausNumero;
            if (int.TryParse(vastaus1, out vastausNumero))
            {
                string[] osat = textBox1.Text.Split('+');
                int oikeaTulos = int.Parse(osat[0].Trim()) + int.Parse(osat[1].Trim());
                if (vastausNumero == oikeaTulos)
                {
                    oikeidenVastaustenMaara++;
                }
            }

            vastaus.Text = "";

            
            GenerateRandomAddition();
        }

        private void vastaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lukitseV_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void TallennaPisteet()
        {            
            if (plusTulokset.TryGetValue(kayttajanimi, out int vanhaTulos))
            {
                if (oikeidenVastaustenMaara > vanhaTulos)
                {
                    plusTulokset[kayttajanimi] = oikeidenVastaustenMaara;
                    SaveScores("plus_tulokset.txt", plusTulokset);
                }
            }
            else
            {
                plusTulokset.Add(kayttajanimi, oikeidenVastaustenMaara);
                SaveScores("plus_tulokset.txt", plusTulokset);
            }
        }

        private void SaveScores(string fileName, Dictionary<string, int> scores)
        {
            List<string> lines = new List<string>();
            foreach (var tulos in scores)
            {
                lines.Add($"{tulos.Key},{tulos.Value}");
            }
            File.WriteAllLines(fileName, lines);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vastaus_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void Dispose(bool disposing)
        {
            TallennaPisteet();
            base.Dispose(disposing);
        }
    }
}
