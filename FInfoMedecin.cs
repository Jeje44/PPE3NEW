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
    public partial class FInfoMedecin : Form
    {
        public FInfoMedecin()
        {
            InitializeComponent();
        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN m = (MEDECIN)bsMedecin.Current;
            bsMedecin.DataSource = ModeleMission2.listeMedecin();

        }
    }
}
