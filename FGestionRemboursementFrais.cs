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
    public partial class FGestionRemboursementFrais : Form
    {
        public FGestionRemboursementFrais()
        {
            InitializeComponent();
        }

        private void Consulter_Click(object sender, EventArgs e)
        {
            Form LaFormConsulterFrais = new ConsulterFicheDeFrais();
            LaFormConsulterFrais.Show();
        }

        private void Renseigner_Click(object sender, EventArgs e)
        {
            Form LaFormeRenseignerFrais = new RenseignerFicheDeFrais();
            LaFormeRenseignerFrais.Show();
        }
    }
}
