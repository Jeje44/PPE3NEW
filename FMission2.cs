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
    public partial class FMission2 : Form
    {
        public FMission2()
        {
            InitializeComponent();
            dgvRapport.DataSource = ModeleMission2.listeRapport();
            dgvRapport.DataSource = bsRapport;
        }

        private void BsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT r = (RAPPORT)bsRapport.Current;
            bsRapport.DataSource = ModeleMission2.listeRapport();
        }

       
    }
}
