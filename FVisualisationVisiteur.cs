﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_Github_Tajek
{
    public partial class FVisualisationVisiteur : Form
    {
        public FVisualisationVisiteur()
        {
            InitializeComponent();
        }

        private void SecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LaFormeListeDesVisiteurParSecteur = new FListeVisiteurcs();
            LaFormeListeDesVisiteurParSecteur.Show();
        }
    }
}
