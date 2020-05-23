using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        Double nilaiHasil = 0;
        String tampilanOperasi = "";
        bool isTampilanOperasi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tombol_angka(object sender, EventArgs e)
        {
            if ((hasil.Text == "0")|| (isTampilanOperasi))
                hasil.Clear();
            isTampilanOperasi = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!hasil.Text.Contains (","))
                    hasil.Text = hasil.Text + button.Text;
            }else
            hasil.Text = hasil.Text + button.Text;
        }

        private void tombol_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (nilaiHasil != 0)
            {
                smdengan.PerformClick();
                tampilanOperasi = button.Text;
                nilaiHasil = Double.Parse(hasil.Text);
                simpanOperasi.Text = nilaiHasil + " " + tampilanOperasi;
                isTampilanOperasi = true;

            }
            else
            {
                tampilanOperasi = button.Text;
                nilaiHasil = Double.Parse(hasil.Text);
                simpanOperasi.Text = nilaiHasil + " " + tampilanOperasi;
                isTampilanOperasi = true;
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            hasil.Text = "0";
        }

        private void c_Click(object sender, EventArgs e)
        {
            hasil.Text = "0";
            nilaiHasil = 0;
        }

        private void smdengan_Click(object sender, EventArgs e)
        {
            switch(tampilanOperasi)
            {
                case "+":
                    hasil.Text = (nilaiHasil + Double.Parse(hasil.Text)).ToString();
                    break;
                case "-":
                    hasil.Text = (nilaiHasil - Double.Parse(hasil.Text)).ToString();
                    break;
                case "*":
                    hasil.Text = (nilaiHasil * Double.Parse(hasil.Text)).ToString();
                    break;
                case "/":
                    hasil.Text = (nilaiHasil / Double.Parse(hasil.Text)).ToString();
                    break;
                default:
                    break;
            }
            simpanOperasi.Text = "";
        }
    }
}
