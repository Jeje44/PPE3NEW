namespace PPE3_Github_Tajek
{
    partial class ConsulterFicheDeFrais
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
            this.Entete = new System.Windows.Forms.TableLayoutPanel();
            this.Visiteur = new System.Windows.Forms.Label();
            this.Mois = new System.Windows.Forms.Label();
            this.IdVisiteur = new System.Windows.Forms.Label();
            this.PrenomNom = new System.Windows.Forms.Label();
            this.FraisForfaitaires = new System.Windows.Forms.DataGridView();
            this.AutresFrais = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.TotalFrais = new System.Windows.Forms.DataGridView();
            this.MslashA = new System.Windows.Forms.Label();
            this.moisAnnee = new System.Windows.Forms.ComboBox();
            this.retour = new System.Windows.Forms.Button();
            this.Entete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FraisForfaitaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutresFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // Entete
            // 
            this.Entete.ColumnCount = 3;
            this.Entete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.70313F));
            this.Entete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.29688F));
            this.Entete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.Entete.Controls.Add(this.Visiteur, 0, 0);
            this.Entete.Controls.Add(this.Mois, 0, 1);
            this.Entete.Controls.Add(this.IdVisiteur, 1, 0);
            this.Entete.Controls.Add(this.PrenomNom, 2, 0);
            this.Entete.Controls.Add(this.moisAnnee, 1, 1);
            this.Entete.Location = new System.Drawing.Point(12, 12);
            this.Entete.Name = "Entete";
            this.Entete.RowCount = 2;
            this.Entete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Entete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Entete.Size = new System.Drawing.Size(776, 100);
            this.Entete.TabIndex = 0;
            this.Entete.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // Visiteur
            // 
            this.Visiteur.AutoSize = true;
            this.Visiteur.Location = new System.Drawing.Point(3, 0);
            this.Visiteur.Name = "Visiteur";
            this.Visiteur.Size = new System.Drawing.Size(41, 13);
            this.Visiteur.TabIndex = 0;
            this.Visiteur.Text = "Visiteur";
            this.Visiteur.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Mois
            // 
            this.Mois.AutoSize = true;
            this.Mois.Location = new System.Drawing.Point(3, 50);
            this.Mois.Name = "Mois";
            this.Mois.Size = new System.Drawing.Size(29, 13);
            this.Mois.TabIndex = 1;
            this.Mois.Text = "Mois";
            // 
            // IdVisiteur
            // 
            this.IdVisiteur.AutoSize = true;
            this.IdVisiteur.Location = new System.Drawing.Point(247, 0);
            this.IdVisiteur.Name = "IdVisiteur";
            this.IdVisiteur.Size = new System.Drawing.Size(50, 13);
            this.IdVisiteur.TabIndex = 2;
            this.IdVisiteur.Text = "IdVisiteur";
            // 
            // PrenomNom
            // 
            this.PrenomNom.AutoSize = true;
            this.PrenomNom.Location = new System.Drawing.Point(536, 0);
            this.PrenomNom.Name = "PrenomNom";
            this.PrenomNom.Size = new System.Drawing.Size(67, 13);
            this.PrenomNom.TabIndex = 3;
            this.PrenomNom.Text = "prenomNOM";
            // 
            // FraisForfaitaires
            // 
            this.FraisForfaitaires.AllowUserToOrderColumns = true;
            this.FraisForfaitaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FraisForfaitaires.Location = new System.Drawing.Point(12, 118);
            this.FraisForfaitaires.Name = "FraisForfaitaires";
            this.FraisForfaitaires.Size = new System.Drawing.Size(776, 180);
            this.FraisForfaitaires.TabIndex = 1;
            this.FraisForfaitaires.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FraisForfaitaires_CellContentClick);
            // 
            // AutresFrais
            // 
            this.AutresFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutresFrais.Location = new System.Drawing.Point(12, 304);
            this.AutresFrais.Name = "AutresFrais";
            this.AutresFrais.Size = new System.Drawing.Size(776, 134);
            this.AutresFrais.TabIndex = 2;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(503, 479);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 3;
            this.Total.Text = "Total";
            // 
            // TotalFrais
            // 
            this.TotalFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalFrais.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalFrais.Location = new System.Drawing.Point(611, 463);
            this.TotalFrais.Name = "TotalFrais";
            this.TotalFrais.Size = new System.Drawing.Size(177, 51);
            this.TotalFrais.TabIndex = 4;
            // 
            // MslashA
            // 
            this.MslashA.AutoSize = true;
            this.MslashA.Location = new System.Drawing.Point(540, 479);
            this.MslashA.Name = "MslashA";
            this.MslashA.Size = new System.Drawing.Size(65, 13);
            this.MslashA.TabIndex = 5;
            this.MslashA.Text = "Mois/Annee";
            // 
            // moisAnnee
            // 
            this.moisAnnee.FormattingEnabled = true;
            this.moisAnnee.Location = new System.Drawing.Point(247, 53);
            this.moisAnnee.Name = "moisAnnee";
            this.moisAnnee.Size = new System.Drawing.Size(121, 21);
            this.moisAnnee.TabIndex = 4;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(12, 474);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 6;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            // 
            // ConsulterFicheDeFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.MslashA);
            this.Controls.Add(this.TotalFrais);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.AutresFrais);
            this.Controls.Add(this.FraisForfaitaires);
            this.Controls.Add(this.Entete);
            this.Name = "ConsulterFicheDeFrais";
            this.Text = "ConsulterFicheDeFrais";
            this.Entete.ResumeLayout(false);
            this.Entete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FraisForfaitaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutresFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Entete;
        private System.Windows.Forms.Label Visiteur;
        private System.Windows.Forms.Label Mois;
        private System.Windows.Forms.Label IdVisiteur;
        private System.Windows.Forms.Label PrenomNom;
        private System.Windows.Forms.DataGridView FraisForfaitaires;
        private System.Windows.Forms.DataGridView AutresFrais;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.DataGridView TotalFrais;
        private System.Windows.Forms.Label MslashA;
        private System.Windows.Forms.ComboBox moisAnnee;
        private System.Windows.Forms.Button retour;
    }
}