﻿namespace PPE3_Github_Tajek
{
    partial class FTousRapports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cborapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // cborapport
            // 
            this.cborapport.FormattingEnabled = true;
            this.cborapport.Location = new System.Drawing.Point(39, 81);
            this.cborapport.Name = "cborapport";
            this.cborapport.Size = new System.Drawing.Size(121, 21);
            this.cborapport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes Rapports de visite";
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.BsRapport_CurrentChanged);
            // 
            // FTousRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cborapport);
            this.Name = "FTousRapports";
            this.Text = "FTousRapports";
            this.Load += new System.EventHandler(this.FTousRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cborapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsRapport;
    }
}