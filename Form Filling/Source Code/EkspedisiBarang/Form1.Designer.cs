namespace EkspedisiBarang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.AboutUs = new System.Windows.Forms.Button();
            this.LokasiTerdekat = new System.Windows.Forms.Button();
            this.CekTarif = new System.Windows.Forms.Button();
            this.Pesananku = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lonceng = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lokasiScreen1 = new EkspedisiBarang.LokasiScreen();
            this.cekTarifScreen1 = new EkspedisiBarang.CekTarifScreen();
            this.pesanankuScreen1 = new EkspedisiBarang.PesanankuScreen1();
            this.homeScreen1 = new EkspedisiBarang.homeScreen1();
            this.aboutUsScreen1 = new EkspedisiBarang.AboutUsScreen();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.AboutUs);
            this.panel1.Controls.Add(this.LokasiTerdekat);
            this.panel1.Controls.Add(this.CekTarif);
            this.panel1.Controls.Add(this.Pesananku);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 550);
            this.panel1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 513);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 25);
            this.button10.TabIndex = 8;
            this.button10.Text = "?";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 181);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 55);
            this.SidePanel.TabIndex = 2;
            // 
            // AboutUs
            // 
            this.AboutUs.FlatAppearance.BorderSize = 0;
            this.AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUs.ForeColor = System.Drawing.Color.White;
            this.AboutUs.Image = ((System.Drawing.Image)(resources.GetObject("AboutUs.Image")));
            this.AboutUs.Location = new System.Drawing.Point(12, 425);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(271, 55);
            this.AboutUs.TabIndex = 7;
            this.AboutUs.Text = "         ABOUT US";
            this.AboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutUs.UseVisualStyleBackColor = true;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // LokasiTerdekat
            // 
            this.LokasiTerdekat.FlatAppearance.BorderSize = 0;
            this.LokasiTerdekat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LokasiTerdekat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LokasiTerdekat.ForeColor = System.Drawing.Color.White;
            this.LokasiTerdekat.Image = ((System.Drawing.Image)(resources.GetObject("LokasiTerdekat.Image")));
            this.LokasiTerdekat.Location = new System.Drawing.Point(12, 364);
            this.LokasiTerdekat.Name = "LokasiTerdekat";
            this.LokasiTerdekat.Size = new System.Drawing.Size(271, 55);
            this.LokasiTerdekat.TabIndex = 6;
            this.LokasiTerdekat.Text = "   LOKASI TERDEKAT";
            this.LokasiTerdekat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LokasiTerdekat.UseVisualStyleBackColor = true;
            this.LokasiTerdekat.Click += new System.EventHandler(this.LokasiTerdekat_Click);
            // 
            // CekTarif
            // 
            this.CekTarif.FlatAppearance.BorderSize = 0;
            this.CekTarif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CekTarif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CekTarif.ForeColor = System.Drawing.Color.White;
            this.CekTarif.Image = ((System.Drawing.Image)(resources.GetObject("CekTarif.Image")));
            this.CekTarif.Location = new System.Drawing.Point(12, 303);
            this.CekTarif.Name = "CekTarif";
            this.CekTarif.Size = new System.Drawing.Size(271, 55);
            this.CekTarif.TabIndex = 5;
            this.CekTarif.Text = "        CEK TARIF";
            this.CekTarif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CekTarif.UseVisualStyleBackColor = true;
            this.CekTarif.Click += new System.EventHandler(this.CekTarif_Click);
            // 
            // Pesananku
            // 
            this.Pesananku.FlatAppearance.BorderSize = 0;
            this.Pesananku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesananku.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesananku.ForeColor = System.Drawing.Color.White;
            this.Pesananku.Image = ((System.Drawing.Image)(resources.GetObject("Pesananku.Image")));
            this.Pesananku.Location = new System.Drawing.Point(12, 242);
            this.Pesananku.Name = "Pesananku";
            this.Pesananku.Size = new System.Drawing.Size(271, 55);
            this.Pesananku.TabIndex = 4;
            this.Pesananku.Text = "         PESANANKU";
            this.Pesananku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pesananku.UseVisualStyleBackColor = true;
            this.Pesananku.Click += new System.EventHandler(this.Pesananku_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(24, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "              HOME";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(12, 181);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(271, 55);
            this.Home.TabIndex = 2;
            this.Home.Text = "              HOME";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(124)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.Lonceng);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Setting);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 47);
            this.panel2.TabIndex = 1;
            // 
            // Lonceng
            // 
            this.Lonceng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lonceng.BackgroundImage")));
            this.Lonceng.FlatAppearance.BorderSize = 0;
            this.Lonceng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lonceng.Location = new System.Drawing.Point(520, 7);
            this.Lonceng.Name = "Lonceng";
            this.Lonceng.Size = new System.Drawing.Size(35, 32);
            this.Lonceng.TabIndex = 6;
            this.Lonceng.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(620, 7);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Setting
            // 
            this.Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Setting.BackgroundImage")));
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Location = new System.Drawing.Point(555, 8);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(31, 31);
            this.Setting.TabIndex = 4;
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(241, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form Filling (Ekspedisi Barang)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "TUGAS PEMROGAMAN VISUAL";
            // 
            // lokasiScreen1
            // 
            this.lokasiScreen1.Location = new System.Drawing.Point(282, 45);
            this.lokasiScreen1.Name = "lokasiScreen1";
            this.lokasiScreen1.Size = new System.Drawing.Size(667, 508);
            this.lokasiScreen1.TabIndex = 10;
            // 
            // cekTarifScreen1
            // 
            this.cekTarifScreen1.Location = new System.Drawing.Point(282, 45);
            this.cekTarifScreen1.Name = "cekTarifScreen1";
            this.cekTarifScreen1.Size = new System.Drawing.Size(668, 508);
            this.cekTarifScreen1.TabIndex = 9;
            // 
            // pesanankuScreen1
            // 
            this.pesanankuScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(150)))), ((int)(((byte)(125)))));
            this.pesanankuScreen1.Location = new System.Drawing.Point(282, 45);
            this.pesanankuScreen1.Name = "pesanankuScreen1";
            this.pesanankuScreen1.Size = new System.Drawing.Size(668, 505);
            this.pesanankuScreen1.TabIndex = 8;
            // 
            // homeScreen1
            // 
            this.homeScreen1.Location = new System.Drawing.Point(282, 45);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(667, 502);
            this.homeScreen1.TabIndex = 7;
            // 
            // aboutUsScreen1
            // 
            this.aboutUsScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.aboutUsScreen1.Location = new System.Drawing.Point(282, 44);
            this.aboutUsScreen1.Name = "aboutUsScreen1";
            this.aboutUsScreen1.Size = new System.Drawing.Size(668, 509);
            this.aboutUsScreen1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.aboutUsScreen1);
            this.Controls.Add(this.lokasiScreen1);
            this.Controls.Add(this.cekTarifScreen1);
            this.Controls.Add(this.pesanankuScreen1);
            this.Controls.Add(this.homeScreen1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button LokasiTerdekat;
        private System.Windows.Forms.Button CekTarif;
        private System.Windows.Forms.Button Pesananku;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Lonceng;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Setting;
        private homeScreen1 homeScreen1;
        private PesanankuScreen1 pesanankuScreen1;
        private CekTarifScreen cekTarifScreen1;
        private LokasiScreen lokasiScreen1;
        private AboutUsScreen aboutUsScreen1;
    }
}

