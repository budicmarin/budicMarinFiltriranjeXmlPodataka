using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace budicMarinFiltriranjeXmlPodataka
{
   
    public partial class FormaFiltriraj : Form
    {
        public static string Ime = "";
        public static string Prezime = "";
        public static string Email = "";
        public static string Razred = "";
        public FormaFiltriraj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Ime = textBoxIme.Text;
            Prezime = textBoxPrezime.Text;
            Email = textBoxEmail.Text;
            Razred = (string)comboBoxRazred.SelectedItem;
            this.Hide();
            
            

           
        }
    }
}
