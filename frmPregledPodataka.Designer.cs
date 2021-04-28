namespace budicMarinFiltriranjeXmlPodataka
{
    partial class frmPregledPodataka
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.richTextBoxUcitaj = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(14, 13);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(165, 38);
            this.btnUcitaj.TabIndex = 0;
            this.btnUcitaj.Text = "Učitaj dokument";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(195, 13);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(88, 38);
            this.btnFiltriraj.TabIndex = 1;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(310, 13);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(111, 38);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // richTextBoxUcitaj
            // 
            this.richTextBoxUcitaj.Location = new System.Drawing.Point(14, 71);
            this.richTextBoxUcitaj.Name = "richTextBoxUcitaj";
            this.richTextBoxUcitaj.Size = new System.Drawing.Size(407, 409);
            this.richTextBoxUcitaj.TabIndex = 3;
            this.richTextBoxUcitaj.Text = "";
            // 
            // frmPregledPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 492);
            this.Controls.Add(this.richTextBoxUcitaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnUcitaj);
            this.Name = "frmPregledPodataka";
            this.Text = "v  ";
            this.Load += new System.EventHandler(this.frmPregledPodataka_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox richTextBoxUcitaj;
    }
}