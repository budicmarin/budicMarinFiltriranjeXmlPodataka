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
    public partial class frmPregledPodataka : Form
    {
        public frmPregledPodataka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            XElement povuciPodatke = XElement.Load(@"D:/Documents/xmlDokument/pretraga12.xml");
            IEnumerable<XElement> ucenici = from Ucenik in povuciPodatke.Descendants("Ucenik") select Ucenik;
            foreach (var item in ucenici)
            {
                richTextBoxUcitaj.Text += item.ToString()+ " \n";
            }
        }

        private void frmPregledPodataka_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            FormaFiltriraj frm = new FormaFiltriraj();
            frm.Show();
            XElement povuciPodatke = XElement.Load(@"D:/Documents/xmlDokument/pretraga12.xml");
            IEnumerable<XElement> ucenici = from Ucenik in povuciPodatke.Descendants("Ucenik")
                                            where (string)Ucenik.Element("Ime") == FormaFiltriraj.Ime
&& (string)Ucenik.Element("Prezime") ==FormaFiltriraj.Prezime
&& (string)Ucenik.Element("EmailAdresa") == FormaFiltriraj.Email
&& (string)Ucenik.Element("Razred") == FormaFiltriraj.Razred
                                            select Ucenik;
            foreach (var item in ucenici)
            {
                richTextBoxUcitaj.Text += item.ToString() + " \n";
            }
        }
    }
}
