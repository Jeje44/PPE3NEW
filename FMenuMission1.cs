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
    public partial class FMenuMission1 : Form
    {
        public FMenuMission1()
        {
            InitializeComponent();
        }

        private void BtnMDP_Click(object sender, EventArgs e)
        {
           
            Form LaFormeChangerMdp = new FChangerMdp();
            LaFormeChangerMdp.Show();
        }

        private void BtnConsultation_Click(object sender, EventArgs e)
        {
            Form LaFormeGestionDesVisiteur = new FInformationcs();
            LaFormeGestionDesVisiteur.Show();
        }

        private void BtnListeVisiteur_Click(object sender, EventArgs e)
        {
            Form LaFormeListeDesVisiteur = new FVisualisationVisiteur();
            LaFormeListeDesVisiteur.Show();
        }
    }
}
