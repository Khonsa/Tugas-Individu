using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspedisiBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            homeScreen1.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            homeScreen1.BringToFront();
        }

        private void Pesananku_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Pesananku.Height;
            SidePanel.Top = Pesananku.Top;
            pesanankuScreen1.BringToFront();

        }

        private void CekTarif_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CekTarif.Height;
            SidePanel.Top = CekTarif.Top;
            cekTarifScreen1.BringToFront();
        }

        private void LokasiTerdekat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = LokasiTerdekat.Height;
            SidePanel.Top = LokasiTerdekat.Top;
            lokasiScreen1.BringToFront();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AboutUs.Height;
            SidePanel.Top = AboutUs.Top;
            aboutUsScreen1.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
