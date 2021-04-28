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
    public partial class frmUnos : Form
    {
        List<Ucenik> listaUcenik = new List<Ucenik>();
      
        public frmUnos()
        {
            InitializeComponent();
        }
        
        private void btnUnos_Click(object sender, EventArgs e)
        {
            string dir = @"D:\Documents\xmlDokument";
            
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Ucenik ucenik = new Ucenik(textBoxIme.Text,textBoxPrezime.Text,textBoxEmail.Text,comboBoxRazred.SelectedItem.ToString());
            listaUcenik.Add(ucenik);
            

        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUnos_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRazred_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            

            var dokumentXmlKlijenti = new XDocument(new XElement("listaUcenik",
                from Ucenik in listaUcenik
                select new XElement("Ucenik",
                    new XElement("Ime", Ucenik.Ime),
                    new XElement("Prezime", Ucenik.Prezime),
                    new XElement("EmailAdresa", Ucenik.Email),
                    new XElement("Razred", Ucenik.Razred)
                    )));
          
            
            //spremanje rezultata prvog pretraživanja
            dokumentXmlKlijenti.Save("D:/Documents/xmlDokument/pretraga12.xml");
            this.Close();
        }
       
    }

}
