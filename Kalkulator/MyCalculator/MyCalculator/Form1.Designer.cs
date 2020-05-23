namespace MyCalculator
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
            this.tombol7 = new System.Windows.Forms.Button();
            this.tombol8 = new System.Windows.Forms.Button();
            this.tombol9 = new System.Windows.Forms.Button();
            this.bagi = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.tombol6 = new System.Windows.Forms.Button();
            this.tombol5 = new System.Windows.Forms.Button();
            this.tombol4 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.tombol3 = new System.Windows.Forms.Button();
            this.tombol2 = new System.Windows.Forms.Button();
            this.tombol1 = new System.Windows.Forms.Button();
            this.smdengan = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.koma = new System.Windows.Forms.Button();
            this.ombol0 = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.TextBox();
            this.simpanOperasi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tombol7
            // 
            this.tombol7.BackColor = System.Drawing.Color.Plum;
            this.tombol7.FlatAppearance.BorderSize = 0;
            this.tombol7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol7.Location = new System.Drawing.Point(13, 91);
            this.tombol7.Name = "tombol7";
            this.tombol7.Size = new System.Drawing.Size(35, 35);
            this.tombol7.TabIndex = 0;
            this.tombol7.Text = "7";
            this.tombol7.UseVisualStyleBackColor = false;
            this.tombol7.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol8
            // 
            this.tombol8.BackColor = System.Drawing.Color.Plum;
            this.tombol8.FlatAppearance.BorderSize = 0;
            this.tombol8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol8.Location = new System.Drawing.Point(54, 91);
            this.tombol8.Name = "tombol8";
            this.tombol8.Size = new System.Drawing.Size(35, 35);
            this.tombol8.TabIndex = 1;
            this.tombol8.Text = "8";
            this.tombol8.UseVisualStyleBackColor = false;
            this.tombol8.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol9
            // 
            this.tombol9.BackColor = System.Drawing.Color.Plum;
            this.tombol9.FlatAppearance.BorderSize = 0;
            this.tombol9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol9.Location = new System.Drawing.Point(95, 91);
            this.tombol9.Name = "tombol9";
            this.tombol9.Size = new System.Drawing.Size(35, 35);
            this.tombol9.TabIndex = 2;
            this.tombol9.Text = "9";
            this.tombol9.UseVisualStyleBackColor = false;
            this.tombol9.Click += new System.EventHandler(this.tombol_angka);
            // 
            // bagi
            // 
            this.bagi.BackColor = System.Drawing.Color.Plum;
            this.bagi.FlatAppearance.BorderSize = 0;
            this.bagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagi.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagi.Location = new System.Drawing.Point(136, 91);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(35, 35);
            this.bagi.TabIndex = 3;
            this.bagi.Text = "/";
            this.bagi.UseVisualStyleBackColor = false;
            this.bagi.Click += new System.EventHandler(this.tombol_operator);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.Plum;
            this.ce.FlatAppearance.BorderSize = 0;
            this.ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ce.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(177, 91);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(37, 35);
            this.ce.TabIndex = 4;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Plum;
            this.c.FlatAppearance.BorderSize = 0;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(177, 132);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(37, 35);
            this.c.TabIndex = 9;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // kali
            // 
            this.kali.BackColor = System.Drawing.Color.Plum;
            this.kali.FlatAppearance.BorderSize = 0;
            this.kali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kali.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kali.Location = new System.Drawing.Point(136, 132);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(35, 35);
            this.kali.TabIndex = 8;
            this.kali.Text = "*";
            this.kali.UseVisualStyleBackColor = false;
            this.kali.Click += new System.EventHandler(this.tombol_operator);
            // 
            // tombol6
            // 
            this.tombol6.BackColor = System.Drawing.Color.Plum;
            this.tombol6.FlatAppearance.BorderSize = 0;
            this.tombol6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol6.Location = new System.Drawing.Point(95, 132);
            this.tombol6.Name = "tombol6";
            this.tombol6.Size = new System.Drawing.Size(35, 35);
            this.tombol6.TabIndex = 7;
            this.tombol6.Text = "6";
            this.tombol6.UseVisualStyleBackColor = false;
            this.tombol6.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol5
            // 
            this.tombol5.BackColor = System.Drawing.Color.Plum;
            this.tombol5.FlatAppearance.BorderSize = 0;
            this.tombol5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol5.Location = new System.Drawing.Point(54, 132);
            this.tombol5.Name = "tombol5";
            this.tombol5.Size = new System.Drawing.Size(35, 35);
            this.tombol5.TabIndex = 6;
            this.tombol5.Text = "5";
            this.tombol5.UseVisualStyleBackColor = false;
            this.tombol5.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol4
            // 
            this.tombol4.BackColor = System.Drawing.Color.Plum;
            this.tombol4.FlatAppearance.BorderSize = 0;
            this.tombol4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol4.Location = new System.Drawing.Point(13, 132);
            this.tombol4.Name = "tombol4";
            this.tombol4.Size = new System.Drawing.Size(35, 35);
            this.tombol4.TabIndex = 5;
            this.tombol4.Text = "4";
            this.tombol4.UseVisualStyleBackColor = false;
            this.tombol4.Click += new System.EventHandler(this.tombol_angka);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Plum;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(136, 173);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(35, 35);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.tombol_operator);
            // 
            // tombol3
            // 
            this.tombol3.BackColor = System.Drawing.Color.Plum;
            this.tombol3.FlatAppearance.BorderSize = 0;
            this.tombol3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol3.Location = new System.Drawing.Point(95, 173);
            this.tombol3.Name = "tombol3";
            this.tombol3.Size = new System.Drawing.Size(35, 35);
            this.tombol3.TabIndex = 12;
            this.tombol3.Text = "3";
            this.tombol3.UseVisualStyleBackColor = false;
            this.tombol3.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol2
            // 
            this.tombol2.BackColor = System.Drawing.Color.Plum;
            this.tombol2.FlatAppearance.BorderSize = 0;
            this.tombol2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol2.Location = new System.Drawing.Point(54, 173);
            this.tombol2.Name = "tombol2";
            this.tombol2.Size = new System.Drawing.Size(35, 35);
            this.tombol2.TabIndex = 11;
            this.tombol2.Text = "2";
            this.tombol2.UseVisualStyleBackColor = false;
            this.tombol2.Click += new System.EventHandler(this.tombol_angka);
            // 
            // tombol1
            // 
            this.tombol1.BackColor = System.Drawing.Color.Plum;
            this.tombol1.FlatAppearance.BorderSize = 0;
            this.tombol1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombol1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol1.Location = new System.Drawing.Point(13, 173);
            this.tombol1.Name = "tombol1";
            this.tombol1.Size = new System.Drawing.Size(35, 35);
            this.tombol1.TabIndex = 10;
            this.tombol1.Text = "1";
            this.tombol1.UseVisualStyleBackColor = false;
            this.tombol1.Click += new System.EventHandler(this.tombol_angka);
            // 
            // smdengan
            // 
            this.smdengan.BackColor = System.Drawing.Color.Plum;
            this.smdengan.FlatAppearance.BorderSize = 0;
            this.smdengan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smdengan.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smdengan.Location = new System.Drawing.Point(177, 173);
            this.smdengan.Name = "smdengan";
            this.smdengan.Size = new System.Drawing.Size(37, 76);
            this.smdengan.TabIndex = 19;
            this.smdengan.Text = "=";
            this.smdengan.UseVisualStyleBackColor = false;
            this.smdengan.Click += new System.EventHandler(this.smdengan_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.Plum;
            this.tambah.FlatAppearance.BorderSize = 0;
            this.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(136, 214);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(35, 35);
            this.tambah.TabIndex = 18;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tombol_operator);
            // 
            // koma
            // 
            this.koma.BackColor = System.Drawing.Color.Plum;
            this.koma.FlatAppearance.BorderSize = 0;
            this.koma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koma.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koma.Location = new System.Drawing.Point(95, 214);
            this.koma.Name = "koma";
            this.koma.Size = new System.Drawing.Size(35, 35);
            this.koma.TabIndex = 17;
            this.koma.Text = ",";
            this.koma.UseVisualStyleBackColor = false;
            this.koma.Click += new System.EventHandler(this.tombol_angka);
            // 
            // ombol0
            // 
            this.ombol0.BackColor = System.Drawing.Color.Plum;
            this.ombol0.FlatAppearance.BorderSize = 0;
            this.ombol0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ombol0.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ombol0.Location = new System.Drawing.Point(13, 214);
            this.ombol0.Name = "ombol0";
            this.ombol0.Size = new System.Drawing.Size(76, 35);
            this.ombol0.TabIndex = 15;
            this.ombol0.Text = "0";
            this.ombol0.UseVisualStyleBackColor = false;
            this.ombol0.Click += new System.EventHandler(this.tombol_angka);
            // 
            // hasil
            // 
            this.hasil.BackColor = System.Drawing.Color.Plum;
            this.hasil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hasil.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil.Location = new System.Drawing.Point(13, 39);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(201, 20);
            this.hasil.TabIndex = 20;
            this.hasil.Text = "0";
            this.hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // simpanOperasi
            // 
            this.simpanOperasi.AutoSize = true;
            this.simpanOperasi.BackColor = System.Drawing.SystemColors.Control;
            this.simpanOperasi.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanOperasi.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.simpanOperasi.Location = new System.Drawing.Point(15, 17);
            this.simpanOperasi.Name = "simpanOperasi";
            this.simpanOperasi.Size = new System.Drawing.Size(0, 19);
            this.simpanOperasi.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(226, 259);
            this.Controls.Add(this.simpanOperasi);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.smdengan);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.koma);
            this.Controls.Add(this.ombol0);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.tombol3);
            this.Controls.Add(this.tombol2);
            this.Controls.Add(this.tombol1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.tombol6);
            this.Controls.Add(this.tombol5);
            this.Controls.Add(this.tombol4);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.tombol9);
            this.Controls.Add(this.tombol8);
            this.Controls.Add(this.tombol7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulatorku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombol7;
        private System.Windows.Forms.Button tombol8;
        private System.Windows.Forms.Button tombol9;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.Button tombol6;
        private System.Windows.Forms.Button tombol5;
        private System.Windows.Forms.Button tombol4;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button tombol3;
        private System.Windows.Forms.Button tombol2;
        private System.Windows.Forms.Button tombol1;
        private System.Windows.Forms.Button smdengan;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button koma;
        private System.Windows.Forms.Button ombol0;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Label simpanOperasi;
    }
}

