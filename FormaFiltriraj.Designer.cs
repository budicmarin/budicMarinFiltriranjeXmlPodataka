namespace budicMarinFiltriranjeXmlPodataka
{
    partial class FormaFiltriraj
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
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelRazred = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            "4.D"});
            this.comboBoxRazred.Location = new System.Drawing.Point(15, 250);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRazred.TabIndex = 20;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(11, 330);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(11, 301);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 18;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(11, 168);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 17;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(15, 107);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrezime.TabIndex = 16;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(15, 39);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 22);
            this.textBoxIme.TabIndex = 15;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(12, 87);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(59, 17);
            this.labelPrezime.TabIndex = 14;
            this.labelPrezime.Text = "Prezime";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 148);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "E-mail";
            // 
            // labelRazred
            // 
            this.labelRazred.AutoSize = true;
            this.labelRazred.Location = new System.Drawing.Point(12, 229);
            this.labelRazred.Name = "labelRazred";
            this.labelRazred.Size = new System.Drawing.Size(54, 17);
            this.labelRazred.TabIndex = 12;
            this.labelRazred.Text = "Razred";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(12, 19);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(30, 17);
            this.labelIme.TabIndex = 11;
            this.labelIme.Text = "Ime";
            // 
            // FormaFiltriraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 450);
            this.Controls.Add(this.comboBoxRazred);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelRazred);
            this.Controls.Add(this.labelIme);
            this.Name = "FormaFiltriraj";
            this.Text = "FormaFiltriraj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRazred;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelRazred;
        private System.Windows.Forms.Label labelIme;
    }
}