namespace Koledar
{
    partial class Koledar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koledar));
            this.MesecComboBox = new System.Windows.Forms.ComboBox();
            this.LetoVnos = new System.Windows.Forms.TextBox();
            this.TekstZaIzberiMesec = new System.Windows.Forms.Label();
            this.TekstZaVpisiLeto = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LetoNaslov = new System.Windows.Forms.Label();
            this.MesecNaslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tekstIkona = new System.Windows.Forms.Label();
            this.gumbPotrdi = new Gumb();
            this.gumbiNaslednji = new Gumb();
            this.gumbPrejsnji = new Gumb();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MesecComboBox
            // 
            this.MesecComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MesecComboBox.FormattingEnabled = true;
            this.MesecComboBox.Items.AddRange(new object[] {
            "januar",
            "februar",
            "marec",
            "april",
            "maj",
            "junij",
            "julij",
            "avgust",
            "september",
            "oktober",
            "november",
            "december"});
            this.MesecComboBox.Location = new System.Drawing.Point(411, 95);
            this.MesecComboBox.Name = "MesecComboBox";
            this.MesecComboBox.Size = new System.Drawing.Size(121, 24);
            this.MesecComboBox.TabIndex = 1;
            // 
            // LetoVnos
            // 
            this.LetoVnos.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.LetoVnos.Location = new System.Drawing.Point(535, 95);
            this.LetoVnos.Name = "LetoVnos";
            this.LetoVnos.Size = new System.Drawing.Size(116, 25);
            this.LetoVnos.TabIndex = 2;
            // 
            // TekstZaIzberiMesec
            // 
            this.TekstZaIzberiMesec.AutoSize = true;
            this.TekstZaIzberiMesec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.TekstZaIzberiMesec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstZaIzberiMesec.Location = new System.Drawing.Point(410, 68);
            this.TekstZaIzberiMesec.Name = "TekstZaIzberiMesec";
            this.TekstZaIzberiMesec.Size = new System.Drawing.Size(109, 23);
            this.TekstZaIzberiMesec.TabIndex = 5;
            this.TekstZaIzberiMesec.Text = "Izberi mesec";
            // 
            // TekstZaVpisiLeto
            // 
            this.TekstZaVpisiLeto.AutoSize = true;
            this.TekstZaVpisiLeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.TekstZaVpisiLeto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstZaVpisiLeto.Location = new System.Drawing.Point(535, 68);
            this.TekstZaVpisiLeto.Name = "TekstZaVpisiLeto";
            this.TekstZaVpisiLeto.Size = new System.Drawing.Size(84, 23);
            this.TekstZaVpisiLeto.TabIndex = 6;
            this.TekstZaVpisiLeto.Text = "Vpisi leto";
            // 
            // tabela
            // 
            this.tabela.BackColor = System.Drawing.Color.Transparent;
            this.tabela.ColumnCount = 7;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabela.Location = new System.Drawing.Point(44, 257);
            this.tabela.Name = "tabela";
            this.tabela.RowCount = 6;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabela.Size = new System.Drawing.Size(714, 428);
            this.tabela.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(59, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "PON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(159, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(259, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "SRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(359, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "ČET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label5.Location = new System.Drawing.Point(466, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "PET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label6.Location = new System.Drawing.Point(562, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "SOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.label7.Location = new System.Drawing.Point(673, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "NED";
            // 
            // LetoNaslov
            // 
            this.LetoNaslov.AutoSize = true;
            this.LetoNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.LetoNaslov.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetoNaslov.ForeColor = System.Drawing.Color.White;
            this.LetoNaslov.Location = new System.Drawing.Point(83, 0);
            this.LetoNaslov.Name = "LetoNaslov";
            this.LetoNaslov.Size = new System.Drawing.Size(175, 81);
            this.LetoNaslov.TabIndex = 19;
            this.LetoNaslov.Text = "2023";
            // 
            // MesecNaslov
            // 
            this.MesecNaslov.AutoSize = true;
            this.MesecNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.MesecNaslov.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesecNaslov.Location = new System.Drawing.Point(90, 81);
            this.MesecNaslov.Name = "MesecNaslov";
            this.MesecNaslov.Size = new System.Drawing.Size(84, 38);
            this.MesecNaslov.TabIndex = 20;
            this.MesecNaslov.Text = "JULIJ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 142);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tekstIkona
            // 
            this.tekstIkona.AutoSize = true;
            this.tekstIkona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.tekstIkona.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstIkona.ForeColor = System.Drawing.Color.DarkGreen;
            this.tekstIkona.Location = new System.Drawing.Point(758, 92);
            this.tekstIkona.Name = "tekstIkona";
            this.tekstIkona.Size = new System.Drawing.Size(0, 32);
            this.tekstIkona.TabIndex = 25;
            // 
            // gumbPotrdi
            // 
            this.gumbPotrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbPotrdi.BarvaOkvirja = System.Drawing.Color.Transparent;
            this.gumbPotrdi.BarvaOzadja = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbPotrdi.BarvaTeksta = System.Drawing.Color.White;
            this.gumbPotrdi.FlatAppearance.BorderSize = 0;
            this.gumbPotrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumbPotrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPotrdi.ForeColor = System.Drawing.Color.White;
            this.gumbPotrdi.Location = new System.Drawing.Point(657, 92);
            this.gumbPotrdi.Name = "gumbPotrdi";
            this.gumbPotrdi.RadijOkvirja = 5;
            this.gumbPotrdi.Size = new System.Drawing.Size(95, 30);
            this.gumbPotrdi.TabIndex = 23;
            this.gumbPotrdi.Text = "Potrdi";
            this.gumbPotrdi.UseVisualStyleBackColor = false;
            this.gumbPotrdi.VelikostOkvirja = 2;
            this.gumbPotrdi.Click += new System.EventHandler(this.GumbPotrdiKlik);
            // 
            // gumbiNaslednji
            // 
            this.gumbiNaslednji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbiNaslednji.BarvaOkvirja = System.Drawing.Color.Black;
            this.gumbiNaslednji.BarvaOzadja = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbiNaslednji.BarvaTeksta = System.Drawing.Color.White;
            this.gumbiNaslednji.FlatAppearance.BorderSize = 0;
            this.gumbiNaslednji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumbiNaslednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbiNaslednji.ForeColor = System.Drawing.Color.White;
            this.gumbiNaslednji.Location = new System.Drawing.Point(780, 0);
            this.gumbiNaslednji.Name = "gumbiNaslednji";
            this.gumbiNaslednji.RadijOkvirja = 0;
            this.gumbiNaslednji.Size = new System.Drawing.Size(43, 35);
            this.gumbiNaslednji.TabIndex = 22;
            this.gumbiNaslednji.Text = ">";
            this.gumbiNaslednji.UseVisualStyleBackColor = false;
            this.gumbiNaslednji.VelikostOkvirja = 0;
            this.gumbiNaslednji.Click += new System.EventHandler(this.GumbNaslednjiKlik);
            // 
            // gumbPrejsnji
            // 
            this.gumbPrejsnji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbPrejsnji.BarvaOkvirja = System.Drawing.Color.Black;
            this.gumbPrejsnji.BarvaOzadja = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.gumbPrejsnji.BarvaTeksta = System.Drawing.Color.White;
            this.gumbPrejsnji.FlatAppearance.BorderSize = 0;
            this.gumbPrejsnji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumbPrejsnji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPrejsnji.ForeColor = System.Drawing.Color.White;
            this.gumbPrejsnji.Location = new System.Drawing.Point(0, 0);
            this.gumbPrejsnji.Name = "gumbPrejsnji";
            this.gumbPrejsnji.RadijOkvirja = 0;
            this.gumbPrejsnji.Size = new System.Drawing.Size(48, 34);
            this.gumbPrejsnji.TabIndex = 21;
            this.gumbPrejsnji.Text = "<";
            this.gumbPrejsnji.UseVisualStyleBackColor = false;
            this.gumbPrejsnji.VelikostOkvirja = 0;
            this.gumbPrejsnji.Click += new System.EventHandler(this.GumbPrejsnjiKlik);
            // 
            // Koledar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 736);
            this.Controls.Add(this.tekstIkona);
            this.Controls.Add(this.gumbPotrdi);
            this.Controls.Add(this.gumbiNaslednji);
            this.Controls.Add(this.gumbPrejsnji);
            this.Controls.Add(this.MesecNaslov);
            this.Controls.Add(this.LetoNaslov);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.TekstZaVpisiLeto);
            this.Controls.Add(this.TekstZaIzberiMesec);
            this.Controls.Add(this.LetoVnos);
            this.Controls.Add(this.MesecComboBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Koledar";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox MesecComboBox;
        private System.Windows.Forms.TextBox LetoVnos;
        private System.Windows.Forms.Label TekstZaIzberiMesec;
        private System.Windows.Forms.Label TekstZaVpisiLeto;
        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LetoNaslov;
        private System.Windows.Forms.Label MesecNaslov;
        protected Gumb gumbPrejsnji;
        protected Gumb gumbiNaslednji;
        protected Gumb gumbPotrdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tekstIkona;
    }
}

