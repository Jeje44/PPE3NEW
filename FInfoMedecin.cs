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

        private void FInfoMedecin_Load(object sender, EventArgs e)
        {
            System.Type type = bsMedecin.GetType();
            var id = (int)type.GetProperty("idMedecin").GetValue(bsMedecin.Current, null);
            //ModeleMission2.trouveMedecin; 

            txtidMedecin.Text = ModeleMission2.MedecinChoisi.idMedecin.ToString();
            txtNom.Text = ModeleMission2.MedecinChoisi.nom;
            txtPrenom.Text = ModeleMission2.MedecinChoisi.prenom;
            txtTelephone.Text = ModeleMission2.MedecinChoisi.tel;
           // cboPraticien.SelectedIndex = ModeleMission2.MedecinChoisi.idNation - 1;


        }
    }
}
