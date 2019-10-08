namespace PPE3_Github_Tajek
{
    partial class RenseignerFicheDeFrais
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
            this.valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.ligneMatricule = new System.Windows.Forms.Label();
            this.Matricule = new System.Windows.Forms.Label();
            this.Visiteur = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.ligneNom = new System.Windows.Forms.Label();
            this.Mois = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TabFraisForfaitaire = new System.Windows.Forms.DataGridView();
            this.FraisForfaitaires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutreFrais = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabFraisForfaitaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutreFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(617, 361);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 0;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(12, 361);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            // 
            // ligneMatricule
            // 
            this.ligneMatricule.AutoSize = true;
            this.ligneMatricule.Location = new System.Drawing.Point(186, 31);
            this.ligneMatricule.Name = "ligneMatricule";
            this.ligneMatricule.Size = new System.Drawing.Size(72, 13);
            this.ligneMatricule.TabIndex = 2;
            this.ligneMatricule.Text = "ligneMatricule";
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(130, 31);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(50, 13);
            this.Matricule.TabIndex = 3;
            this.Matricule.Text = "Marticule";
            // 
            // Visiteur
            // 
            this.Visiteur.AutoSize = true;
            this.Visiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visiteur.Location = new System.Drawing.Point(25, 24);
            this.Visiteur.Name = "Visiteur";
            this.Visiteur.Size = new System.Drawing.Size(62, 20);
            this.Visiteur.TabIndex = 4;
            this.Visiteur.Text = "Visiteur";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(130, 63);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 5;
            this.Nom.Text = "Nom";
            // 
            // ligneNom
            // 
            this.ligneNom.AutoSize = true;
            this.ligneNom.Location = new System.Drawing.Point(186, 63);
            this.ligneNom.Name = "ligneNom";
            this.ligneNom.Size = new System.Drawing.Size(55, 13);
            this.ligneNom.TabIndex = 6;
            this.ligneNom.Text = "LigneNom";
            // 
            // Mois
            // 
            this.Mois.AutoSize = true;
            this.Mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois.Location = new System.Drawing.Point(25, 88);
            this.Mois.Name = "Mois";
            this.Mois.Size = new System.Drawing.Size(42, 20);
            this.Mois.TabIndex = 7;
            this.Mois.Text = "Mois";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // TabFraisForfaitaire
            // 
            this.TabFraisForfaitaire.AllowUserToDeleteRows = false;
            this.TabFraisForfaitaire.AllowUserToOrderColumns = true;
            this.TabFraisForfaitaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabFraisForfaitaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TabFraisForfaitaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabFraisForfaitaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FraisForfaitaires,
            this.Quantite,
            this.MontantUnitaire,
            this.Total});
            this.TabFraisForfaitaire.Location = new System.Drawing.Point(29, 114);
            this.TabFraisForfaitaire.Name = "TabFraisForfaitaire";
            this.TabFraisForfaitaire.ReadOnly = true;
            this.TabFraisForfaitaire.Size = new System.Drawing.Size(663, 108);
            this.TabFraisForfaitaire.TabIndex = 9;
            this.TabFraisForfaitaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // FraisForfaitaires
            // 
            this.FraisForfaitaires.HeaderText = "FraisForfaitaires";
            this.FraisForfaitaires.Name = "FraisForfaitaires";
            this.FraisForfaitaires.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // MontantUnitaire
            // 
            this.MontantUnitaire.HeaderText = "Montant Unitaire";
            this.MontantUnitaire.Name = "MontantUnitaire";
            this.MontantUnitaire.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // AutreFrais
            // 
            this.AutreFrais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AutreFrais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AutreFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutreFrais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Libeller,
            this.Montant});
            this.AutreFrais.Location = new System.Drawing.Point(29, 234);
            this.AutreFrais.Name = "AutreFrais";
            this.AutreFrais.Size = new System.Drawing.Size(501, 76);
            this.AutreFrais.TabIndex = 10;
            this.AutreFrais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutreFrais_CellContentClick);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 55;
            // 
            // Libeller
            // 
            this.Libeller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Libeller.HeaderText = "Libellé";
            this.Libeller.Name = "Libeller";
            this.Libeller.Width = 62;
            // 
            // Montant
            // 
            this.Montant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.Width = 71;
            // 
            // RenseignerFicheDeFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 396);
            this.Controls.Add(this.AutreFrais);
            this.Controls.Add(this.TabFraisForfaitaire);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Mois);
            this.Controls.Add(this.ligneNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Visiteur);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.ligneMatricule);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.valider);
            this.Name = "RenseignerFicheDeFrais";
            this.Text = "RenseignerFicheDeFrais";
            this.Load += new System.EventHandler(this.RenseignerFicheDeFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabFraisForfaitaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutreFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Label ligneMatricule;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.Label Visiteur;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label ligneNom;
        private System.Windows.Forms.Label Mois;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView TabFraisForfaitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn FraisForfaitaires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView AutreFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
    }
}