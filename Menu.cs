﻿using System;
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
            Form LaFormeRemboursementFrais = new FGestionRemboursementFrais();
            LaFormeRemboursementFrais.Show();
        }
    }
}
