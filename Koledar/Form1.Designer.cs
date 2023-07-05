namespace Koledar
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
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.vnos = new System.Windows.Forms.TextBox();
            this.gumb = new System.Windows.Forms.Button();
            this.okvir = new System.Windows.Forms.TableLayoutPanel();
            this.izberi_mesec = new System.Windows.Forms.Label();
            this.vpisi_leto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.ColumnCount = 2;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.Location = new System.Drawing.Point(290, 174);
            this.tabela.Name = "tabela";
            this.tabela.RowCount = 2;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.Size = new System.Drawing.Size(200, 100);
            this.tabela.TabIndex = 0;
            // 
            // comboBox
            // 
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
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
            this.comboBox.Location = new System.Drawing.Point(253, 121);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 1;
            // 
            // vnos
            // 
            this.vnos.Location = new System.Drawing.Point(390, 123);
            this.vnos.Name = "vnos";
            this.vnos.Size = new System.Drawing.Size(100, 22);
            this.vnos.TabIndex = 2;
            // 
            // gumb
            // 
            this.gumb.Location = new System.Drawing.Point(525, 116);
            this.gumb.Name = "gumb";
            this.gumb.Size = new System.Drawing.Size(124, 29);
            this.gumb.TabIndex = 3;
            this.gumb.Text = "potrdi";
            this.gumb.UseVisualStyleBackColor = true;
            this.gumb.Click += new System.EventHandler(this.gumb_klik);
            // 
            // okvir
            // 
            this.okvir.ColumnCount = 2;
            this.okvir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okvir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okvir.Location = new System.Drawing.Point(74, 174);
            this.okvir.Name = "okvir";
            this.okvir.RowCount = 2;
            this.okvir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okvir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.okvir.Size = new System.Drawing.Size(200, 100);
            this.okvir.TabIndex = 4;
            // 
            // izberi_mesec
            // 
            this.izberi_mesec.AutoSize = true;
            this.izberi_mesec.Location = new System.Drawing.Point(267, 92);
            this.izberi_mesec.Name = "izberi_mesec";
            this.izberi_mesec.Size = new System.Drawing.Size(83, 16);
            this.izberi_mesec.TabIndex = 5;
            this.izberi_mesec.Text = "Izberi mesec";
            // 
            // vpisi_leto
            // 
            this.vpisi_leto.AutoSize = true;
            this.vpisi_leto.Location = new System.Drawing.Point(415, 92);
            this.vpisi_leto.Name = "vpisi_leto";
            this.vpisi_leto.Size = new System.Drawing.Size(60, 16);
            this.vpisi_leto.TabIndex = 6;
            this.vpisi_leto.Text = "vpisi leto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vpisi_leto);
            this.Controls.Add(this.izberi_mesec);
            this.Controls.Add(this.okvir);
            this.Controls.Add(this.gumb);
            this.Controls.Add(this.vnos);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.tabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox vnos;
        private System.Windows.Forms.Button gumb;
        private System.Windows.Forms.TableLayoutPanel okvir;
        private System.Windows.Forms.Label izberi_mesec;
        private System.Windows.Forms.Label vpisi_leto;
    }
}

