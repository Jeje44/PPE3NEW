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
        }

       /* private void BsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT r = (RAPPORT)bsRapport.Current;
            bsRapport.DataSource = ModeleMission2.listeRapport();

        }*/

        /*private void FTousRapports_Load(object sender, EventArgs e)
        {
            cborapport.ValueMember = "idRapport";
            cborapport.DisplayMember = "idRapport";
            bsRapport.DataSource = ModeleMission2.listeRapport();
            cborapport.DataSource = bsRapport; 

        }*/
    }
}
