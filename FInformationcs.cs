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
    public partial class FInformationcs : Form
    {
        public FInformationcs()
        {
            InitializeComponent();
        }

        private void FInformationcs_Load(object sender, EventArgs e)
        {
            Visiteur unVisiteur = ModeleMission1.unVisiteurCo;
            tbNomVisteur.Text = unVisiteur.nom.ToString();
            tbCPVisiteur.Text = unVisiteur.cp.ToString();
            tbAdresseVisiteur.Text = unVisiteur.rue.ToString();
            tbPrenomVisiteur.Text = unVisiteur.prenom.ToString();
            tbVilleVisiteur.Text = unVisiteur.ville.ToString();
            tbDateEmbauche.Text = unVisiteur.dateEmbauche.ToString();
            btnOK.Visible = true;
           // btnModifuer.Visible = false;

        }

        private void BtnModifuer_Click(object sender, EventArgs e)
        {
            ModeleMission1.ModifVisiteur(tbAdresseVisiteur.Text, tbCPVisiteur.Text, tbVilleVisiteur.Text);
            
               MessageBox.Show("Modification validée");
            

            
            
          

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}