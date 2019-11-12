namespace PPE3_Github_Tajek
{
    partial class FMenuMission1
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
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnMDP = new System.Windows.Forms.Button();
            this.btnListeVisiteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultation
            // 
            this.btnConsultation.Location = new System.Drawing.Point(31, 129);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(233, 23);
            this.btnConsultation.TabIndex = 0;
            this.btnConsultation.Text = "Consulation et mis à jour du profil ";
            this.btnConsultation.UseVisualStyleBackColor = true;
            this.btnConsultation.Click += new System.EventHandler(this.BtnConsultation_Click);
            // 
            // btnMDP
            // 
            this.btnMDP.Location = new System.Drawing.Point(356, 128);
            this.btnMDP.Name = "btnMDP";
            this.btnMDP.Size = new System.Drawing.Size(165, 23);
            this.btnMDP.TabIndex = 1;
            this.btnMDP.Text = "Modifier Mot de passe";
            this.btnMDP.UseVisualStyleBackColor = true;
            this.btnMDP.Click += new System.EventHandler(this.BtnMDP_Click);
            // 
            // btnListeVisiteur
            // 
            this.btnListeVisiteur.Location = new System.Drawing.Point(570, 127);
            this.btnListeVisiteur.Name = "btnListeVisiteur";
            this.btnListeVisiteur.Size = new System.Drawing.Size(172, 23);
            this.btnListeVisiteur.TabIndex = 2;
            this.btnListeVisiteur.Text = "Visualisation des Visiteurs";
            this.btnListeVisiteur.UseVisualStyleBackColor = true;
            this.btnListeVisiteur.Click += new System.EventHandler(this.BtnListeVisiteur_Click);
            // 
            // FMenuMission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListeVisiteur);
            this.Controls.Add(this.btnMDP);
            this.Controls.Add(this.btnConsultation);
            this.Name = "FMenuMission1";
            this.Text = "FMenuMission1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnMDP;
        private System.Windows.Forms.Button btnListeVisiteur;
    }
}