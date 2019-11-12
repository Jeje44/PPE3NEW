using System;
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
    public partial class FListeVisiteurcs : Form
    {
        public FListeVisiteurcs()
        {
            InitializeComponent();
        }

        private void FListeVisiteurcs_Load(object sender, EventArgs e)
        {
            cbListeSecteur.ValueMember = "idSecteur";//permet de stocker l'identifiant
            cbListeSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = ModeleMission1.ListesSecteur();
            cbListeSecteur.DataSource = bsSecteur;

            cbRegion.ValueMember = "idRegion";
            cbRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = ModeleMission1.ListesRegions();
            cbRegion.DataSource = bsRegion; 
           
        }

        private void BsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            Secteur s = (Secteur)bsSecteur.Current;
            bsRegion.DataSource = s.Region.ToList();
            cbRegion.DataSource = bsRegion ;
        }

        private void BsRegion_CurrentChanged(object sender, EventArgs e)
        {
            Region r = (Region)bsRegion.Current;
            bsVisiteurs.DataSource = r.Visiteur1.ToList();
            dgvVisiteur.DataSource = bsVisiteurs;
        }
    }
}
