using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Matikkapeli
{
    public partial class Form1 : Form
    {
        private bool musicOn = true;
        private string kayttajanimi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayttajanimi = kayttajaNimi.Text;

            if (string.IsNullOrEmpty(kayttajanimi))
            {
                MessageBox.Show("Käyttäjänimi ei voi olla tyhjä. Syötä käyttäjänimi ja yritä uudelleen.");
                return;
            }

            PlusPeli form2 = new PlusPeli(kayttajanimi);
            form2.Show();
        }

        private void kayttajaNimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void huipputuloksetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plusPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plusPeliToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PlusTulokset plusTuloksetForm = new PlusTulokset();
            plusTuloksetForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayttajanimi = kayttajaNimi.Text;

            if (string.IsNullOrEmpty(kayttajanimi))
            {
                MessageBox.Show("Käyttäjänimi ei voi olla tyhjä. Syötä käyttäjänimi ja yritä uudelleen.");
                return;
            }

            MiinusPeli form2 = new MiinusPeli(kayttajanimi);
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void miinusPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiinusTulokset miinusTuloksetForm = new MiinusTulokset();

            miinusTuloksetForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayttajanimi = kayttajaNimi.Text;

            if (string.IsNullOrEmpty(kayttajanimi))
            {
                MessageBox.Show("Käyttäjänimi ei voi olla tyhjä. Syötä käyttäjänimi ja yritä uudelleen.");
                return;
            }

            KertoPeli form2 = new KertoPeli(kayttajanimi);
            form2.Show();
        }

        private void kertoPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KertoTulokset kertoTuloksetForm = new KertoTulokset();

            kertoTuloksetForm.Show();
        }
    }
}
