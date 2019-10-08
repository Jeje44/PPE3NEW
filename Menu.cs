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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnMiss3_Click(object sender, EventArgs e)
        {
            //choix fiche de frais ou vaidation paiement.
            Form LaFormeRemboursementFrais = new FGestionRemboursementFrais();
            LaFormeRemboursementFrais.Show();
        }

        private void BtnMiss2_Click(object sender, EventArgs e)
        {
            Form LaFormeRapportDeVisite = new FRapportsDeVisite();
            LaFormeRapportDeVisite.Show();
        }

        private void BtnMiss1_Click(object sender, EventArgs e)
        {
            Form LaFormeGestionDesVisiteur = new FInformationcs();
            LaFormeGestionDesVisiteur.Show();
        }
    }
}
