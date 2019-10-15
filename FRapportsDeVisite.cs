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
    public partial class FRapportsDeVisite : Form
    {
        public FRapportsDeVisite()
        {
            InitializeComponent();
            bsOffrir.DataSource = ModeleMission2.listeOffrir();
            dgvOffrir.DataSource = bsOffrir;
            dgvOffrir.Columns[0].Visible = false;
            dgvOffrir.Columns[1].HeaderText = "Medicament";
            dgvOffrir.Columns[2].HeaderText = "Quantité";
            dgvOffrir.Columns[3].Visible = false;
            dgvOffrir.Columns[4].Visible = false; 

        }

        private void BsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT r = (RAPPORT)bsRapport.Current;
            bsRapport.DataSource = ModeleMission2.listeRapport();
            txtNumRapport.Text = r.idRapport.ToString();
    
        }

        private void FRapportsDeVisite_Load(object sender, EventArgs e)
        {
            
            cboPraticien.ValueMember = "idMedecin"; //permet de stocker l'identifiant 
            cboPraticien.DisplayMember = "nom";
            bsMedecin.DataSource = ModeleMission2.listeMedecin();
            cboPraticien.DataSource = bsMedecin;

            cboMotif.ValueMember = "idMotif";
            cboMotif.DisplayMember = "libMotif";
            bsMotif.DataSource = ModeleMission2.listeMotif();
            cboMotif.DataSource = bsMotif;

        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN m = (MEDECIN)bsMedecin.Current;
         

        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            Form LaFormeInformationMedecin = new FInfoMedecin();
            LaFormeInformationMedecin.Show();
        }

        private void CboPraticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            
        }
    }
}
