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
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();

        }


        // et on ajoute la méthode :

        public static void ThreadProc()
        {
            Application.Run(new Menu());
        }


        private void FConnex_Load(object sender, EventArgs e)
        {
            btnValidé.Visible = true;
            btnOk.Visible = false;
        }

        private void BtnValidé_Click(object sender, EventArgs e)
        {

            MessageBox.Show(ModeleMission1.validConnexion(txtIdentifiant.Text.ToString(), txtPasswd.Text.ToString()));

            if (ModeleMission1.getConnexionValide())
            {
                btnOk.Visible = true;
                btnValidé.Visible = false;
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
          

        }
        
    }
}
