using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Matikkapeli
{
    public partial class MiinusPeli : Form
    {
        private Random random = new Random();
        private int laskujenMaara = 0;
        private int oikeidenVastaustenMaara = 0;
        private string kayttajanimi;
        private Dictionary<string, int> miinusTulokset;

        public MiinusPeli(string kayttajanimi)
        {
            InitializeComponent();
            this.kayttajanimi = kayttajanimi;
            miinusTulokset = new Dictionary<string, int>();
            vastaus.KeyDown += new KeyEventHandler(vastaus_KeyDown);
        }

        private void MiinusPeli_Load(object sender, EventArgs e)
        {
            GenerateRandomSubtraction();
        }

        private void GenerateRandomSubtraction()
        {
            if (laskujenMaara < 10)
            {
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, num1);

                string subtraction = $"{num1} - {num2}";

                textBox1.Text = subtraction;

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
            if (miinusTulokset.TryGetValue(kayttajanimi, out int vanhaTulos))
            {
                if (oikeidenVastaustenMaara > vanhaTulos)
                {
                    miinusTulokset[kayttajanimi] = oikeidenVastaustenMaara;
                    TallennaTulokset();
                }
            }
            else
            {
                miinusTulokset.Add(kayttajanimi, oikeidenVastaustenMaara);
                TallennaTulokset();
            }
        }

        private void TallennaTulokset()
        {
            using (StreamWriter writer = new StreamWriter("miinus_tulokset.txt", true))
            {
                foreach (var tulos in miinusTulokset)
                {
                    writer.WriteLine($"{tulos.Key},{tulos.Value}");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lukitseV_Click_1(object sender, EventArgs e)
        {
            string vastaus1 = vastaus.Text;

            int vastausNumero;
            if (int.TryParse(vastaus1, out vastausNumero))
            {
                string[] osat = textBox1.Text.Split('-');
                int oikeaTulos = int.Parse(osat[0].Trim()) - int.Parse(osat[1].Trim());
                if (vastausNumero == oikeaTulos)
                {
                    oikeidenVastaustenMaara++;
                }
            }

            vastaus.Text = "";

            GenerateRandomSubtraction();
        }

        private void vastaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lukitseV_Click_1(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void vastaus_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
