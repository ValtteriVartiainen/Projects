using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class TuloksetPohja : Form
    {
        protected ListBox listBox1;

        public TuloksetPohja()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            listBox1 = new ListBox();
            listBox1.Dock = DockStyle.Fill;
            Controls.Add(listBox1);
        }

        protected virtual void DisplayScores()
        {
            // Tämä metodi on tarkoitus ylikirjoittaa johdannaisluokassa
            // tässä luokassa ei ole varsinaista toteutusta
        }
    }
}
