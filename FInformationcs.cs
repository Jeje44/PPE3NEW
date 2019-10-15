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

            //Partie Résponsabilitée
            bsResponsabilité.DataSource = ModeleMission1.unVisiteur.Region.ToList();
            dgvRegion.DataSource = bsResponsabilité;
            dgvRegion.Columns[0].Visible = false;
            dgvRegion.Columns[2].Visible = false;
            dgvRegion.Columns[3].Visible = false;
            dgvRegion.Columns[4].Visible = false;
            dgvRegion.Columns[5].Visible = false;
            dgvRegion.Columns[6].Visible = false;
            dgvRegion.Columns[1].HeaderText = "Région";

        }

        private void BtnModifuer_Click(object sender, EventArgs e)
        {
            ModeleMission1.ModifVisiteur(tbAdresseVisiteur.Text, tbCPVisiteur.Text, tbVilleVisiteur.Text);

            MessageBox.Show("Modification validée");
            this.Close();






        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
