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
    public partial class ConsulterFicheDeFrais : Form
    {
        public ConsulterFicheDeFrais()
        {
            InitializeComponent();
            IdVisiteur.Text = "a13";// Lien avec l'idvisiteur
            // lien avec la date des fiches et le combobox permettra de changer de fiche
            PrenomNom.Text = "Louis VILLECHALANE";// lien avec la bdd en prenan le prenom et le nom en toupper 
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FraisForfaitaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
