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
    public partial class RenseignerFicheDeFrais : Form
    {
        public RenseignerFicheDeFrais()
        {
            InitializeComponent();
            ligneMatricule.Text = "karim" ;//ModeleMission3.getiduser(); 
        }

        private void RenseignerFicheDeFrais_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AutreFrais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
