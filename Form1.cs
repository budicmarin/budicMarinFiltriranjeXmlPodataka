﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinFiltriranjeXmlPodataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            frmUnos frm = new frmUnos();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            frmPregledPodataka frm = new frmPregledPodataka();
            frm.Show();
        }
    }
}
