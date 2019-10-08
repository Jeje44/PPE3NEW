namespace PPE3_Github_Tajek
{
    partial class FInformationcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbNomVisteur = new System.Windows.Forms.TextBox();
            this.tbPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.tbCPVisiteur = new System.Windows.Forms.TextBox();
            this.tbVilleVisiteur = new System.Windows.Forms.TextBox();
            this.tbAdresseVisiteur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDateEmbauche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbNomVisteur
            // 
            this.tbNomVisteur.Location = new System.Drawing.Point(338, 22);
            this.tbNomVisteur.Name = "tbNomVisteur";
            this.tbNomVisteur.Size = new System.Drawing.Size(100, 20);
            this.tbNomVisteur.TabIndex = 1;
            // 
            // tbPrenomVisiteur
            // 
            this.tbPrenomVisiteur.Location = new System.Drawing.Point(338, 83);
            this.tbPrenomVisiteur.Name = "tbPrenomVisiteur";
            this.tbPrenomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.tbPrenomVisiteur.TabIndex = 2;
            // 
            // tbCPVisiteur
            // 
            this.tbCPVisiteur.Location = new System.Drawing.Point(338, 186);
            this.tbCPVisiteur.Name = "tbCPVisiteur";
            this.tbCPVisiteur.Size = new System.Drawing.Size(100, 20);
            this.tbCPVisiteur.TabIndex = 3;
            // 
            // tbVilleVisiteur
            // 
            this.tbVilleVisiteur.Location = new System.Drawing.Point(338, 160);
            this.tbVilleVisiteur.Name = "tbVilleVisiteur";
            this.tbVilleVisiteur.Size = new System.Drawing.Size(100, 20);
            this.tbVilleVisiteur.TabIndex = 4;
            // 
            // tbAdresseVisiteur
            // 
            this.tbAdresseVisiteur.Location = new System.Drawing.Point(338, 134);
            this.tbAdresseVisiteur.Name = "tbAdresseVisiteur";
            this.tbAdresseVisiteur.Size = new System.Drawing.Size(100, 20);
            this.tbAdresseVisiteur.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code Postal";
            // 
            // tbDateEmbauche
            // 
            this.tbDateEmbauche.Location = new System.Drawing.Point(338, 238);
            this.tbDateEmbauche.Name = "tbDateEmbauche";
            this.tbDateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.tbDateEmbauche.TabIndex = 11;
            // 
            // FInformationcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDateEmbauche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdresseVisiteur);
            this.Controls.Add(this.tbVilleVisiteur);
            this.Controls.Add(this.tbCPVisiteur);
            this.Controls.Add(this.tbPrenomVisiteur);
            this.Controls.Add(this.tbNomVisteur);
            this.Controls.Add(this.button1);
            this.Name = "FInformationcs";
            this.Text = "FInformationcs";
            this.Load += new System.EventHandler(this.FInformationcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNomVisteur;
        private System.Windows.Forms.TextBox tbPrenomVisiteur;
        private System.Windows.Forms.TextBox tbCPVisiteur;
        private System.Windows.Forms.TextBox tbVilleVisiteur;
        private System.Windows.Forms.TextBox tbAdresseVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDateEmbauche;
    }
}