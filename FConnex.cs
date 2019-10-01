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
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }
       

       // et on ajoute la méthode :

        public static void ThreadProc()
        {
            Application.Run(new Menu());
        }

        private void FConnex_Load(object sender, EventArgs e)
        {

        }
    }
}
