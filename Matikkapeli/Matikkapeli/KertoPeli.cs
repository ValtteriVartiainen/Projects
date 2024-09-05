using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class KertoPeli : Form
    {
        private Random random = new Random();
        private int laskujenMaara = 0;
        private int oikeidenVastaustenMaara = 0;
        private string kayttajanimi;
        private Dictionary<string, int> kertoTulokset;

        public KertoPeli(string kayttajanimi)
        {
            InitializeComponent();
            this.kayttajanimi = kayttajanimi;
            kertoTulokset = new Dictionary<string, int>();
            vastaus.KeyDown += new KeyEventHandler(vastaus_KeyDown);
        }

        private void KertoPeli_Load(object sender, EventArgs e)
        {
            GenerateRandomMultiplication();
        }

        private void GenerateRandomMultiplication()
        {
            if (laskujenMaara < 10)
            {
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);

                string multiplication = $"{num1} * {num2}";

                textBox1.Text = multiplication;

                laskujenMaara++;
            }
            else
            {
                MessageBox.Show($"Vastasit oikein {oikeidenVastaustenMaara} kysymykseen kymmenestä.");
                TallennaPisteet();
                this.Close();
            }
        }

        private void TallennaPisteet()
        {
            if (kertoTulokset.TryGetValue(kayttajanimi, out int vanhaTulos))
            {
                if (oikeidenVastaustenMaara > vanhaTulos)
                {
                    kertoTulokset[kayttajanimi] = oikeidenVastaustenMaara;
                    TallennaTulokset();
                }
            }
            else
            {
                kertoTulokset.Add(kayttajanimi, oikeidenVastaustenMaara);
                TallennaTulokset();
            }
        }

        private void TallennaTulokset()
        {
            using (StreamWriter writer = new StreamWriter("kerto_tulokset.txt", true))
            {
                foreach (var tulos in kertoTulokset)
                {
                    writer.WriteLine($"{tulos.Key},{tulos.Value}");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lukitseV_Click(object sender, EventArgs e)
        {
            string vastaus1 = vastaus.Text;

            int vastausNumero;
            if (int.TryParse(vastaus1, out vastausNumero))
            {
                string[] osat = textBox1.Text.Split('*');
                int oikeaTulos = int.Parse(osat[0].Trim()) * int.Parse(osat[1].Trim());
                if (vastausNumero == oikeaTulos)
                {
                    oikeidenVastaustenMaara++;
                }
            }

            vastaus.Text = "";

            GenerateRandomMultiplication();
        }

        private void vastaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lukitseV_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
