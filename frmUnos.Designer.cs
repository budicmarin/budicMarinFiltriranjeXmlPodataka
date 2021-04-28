namespace budicMarinFiltriranjeXmlPodataka
{
    partial class frmUnos
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelRazred = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(13, 45);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(30, 17);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime";
            // 
            // labelRazred
            // 
            this.labelRazred.AutoSize = true;
            this.labelRazred.Location = new System.Drawing.Point(13, 255);
            this.labelRazred.Name = "labelRazred";
            this.labelRazred.Size = new System.Drawing.Size(54, 17);
            this.labelRazred.TabIndex = 1;
            this.labelRazred.Text = "Razred";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 174);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(13, 113);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(59, 17);
            this.labelPrezime.TabIndex = 3;
            this.labelPrezime.Text = "Prezime";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(16, 65);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 22);
            this.textBoxIme.TabIndex = 4;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIme_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(16, 133);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrezime.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 327);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(12, 356);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(75, 23);
            this.btnZavrsi.TabIndex = 9;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // comboBoxRazred
            // 
            this.comboBoxRazred.FormattingEnabled = true;
            this.comboBoxRazred.Items.AddRange(new object[] {
            "1.A",
            "1.B",
            "1.C",
            "1.D",
            "2.A",
            "2.B",
            "2.C",
            "2.D",
            "3.A",
            "3.B",
            "3.C",
            "3.D",
            "4.A",
            "4.B",
            "4.C",
            "4.D",
            "1.A",
            "1.B",
            "1.C",
            "1.D"});
            this.comboBoxRazred.Location = new System.Drawing.Point(16, 276);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRazred.TabIndex = 10;
            this.comboBoxRazred.SelectedIndexChanged += new System.EventHandler(this.comboBoxRazred_SelectedIndexChanged);
            // 
            // frmUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.comboBoxRazred);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelRazred);
            this.Controls.Add(this.labelIme);
            this.Name = "frmUnos";
            this.Text = "frmUnos";
            this.Load += new System.EventHandler(this.frmUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelRazred;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.ComboBox comboBoxRazred;
    }
}