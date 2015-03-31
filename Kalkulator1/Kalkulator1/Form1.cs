using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zbroj;
            zbroj = Double.Parse(prviBroj.Text) + Double.Parse(drugiBroj.Text);
            rezultat.Text = zbroj.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double razlika;
            razlika = Double.Parse(prviBroj.Text) - Double.Parse(drugiBroj.Text);
            rezultat.Text = razlika.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kvocijent;
            kvocijent = Double.Parse(prviBroj.Text) / Double.Parse(drugiBroj.Text);
            rezultat.Text = kvocijent.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double umnozak;
            umnozak = Double.Parse(prviBroj.Text) + Double.Parse(drugiBroj.Text);
            rezultat.Text = umnozak.ToString();
        }

        private void prviBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void drugiBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void rezultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
