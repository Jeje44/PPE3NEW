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
    public partial class FChangerMdp : Form
    {
        public FChangerMdp()
        {
            InitializeComponent();
        }

        private void FChangerMdp_Load(object sender, EventArgs e)
        {

        }

        private void BtnValiderMDP_Click(object sender, EventArgs e)
        {
            if(tbNewMdp.Text == tbNewMDP2.Text)
            {
                
                if (ModeleMission1.changeMDP(tbMDP.Text, tbNewMdp.Text))
                {
                    MessageBox.Show("Modification validée");
                }
                else
                {
                    MessageBox.Show("erreur");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("erreur mdp");
            }
        }
    }
}
