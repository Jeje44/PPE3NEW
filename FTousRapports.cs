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
    public partial class FTousRapports : Form
    {
        public FTousRapports()
        {
            InitializeComponent();
            bsRapport.DataSource = ModeleMission2.listeRapportVisiteur();
            dgvRapport.DataSource = bsRapport;
            dgvRapport.Columns[0].HeaderText = "DATE";
            dgvRapport.Columns[1].HeaderText = "NOM";
            dgvRapport.Columns[2].HeaderText = "PRENOM";
            dgvRapport.Columns[3].Visible = false; 

        }

        private void FTousRapports_Load(object sender, EventArgs e)
        {
            cboPraticien.ValueMember = "idMedecin"; //permet de stocker l'identifiant 
            cboPraticien.DisplayMember = "nom";
            bsMedecin.DataSource = ModeleMission2.listeMedecin();
            cboPraticien.DataSource = bsMedecin;
        }

        private void CboPraticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            Form LaFormeRapport = new FRapportsDeVisite();
            LaFormeRapport.Show();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {

        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            
            bsRapport.DataSource = ModeleMission2.listeRapportVisiteurMedecin(((MEDECIN)bsMedecin.Current).idMedecin);
            dgvRapport.DataSource = bsRapport; 

        }
    }
}
