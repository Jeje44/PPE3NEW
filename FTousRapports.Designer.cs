namespace PPE3_Github_Tajek
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
            this.label1 = new System.Windows.Forms.Label();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.cboPraticien = new System.Windows.Forms.ComboBox();
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les rapports :";
            // 
            // dgvRapport
            // 
            this.dgvRapport.AllowUserToAddRows = false;
            this.dgvRapport.AllowUserToDeleteRows = false;
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Location = new System.Drawing.Point(41, 90);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.ReadOnly = true;
            this.dgvRapport.Size = new System.Drawing.Size(484, 180);
            this.dgvRapport.TabIndex = 2;
            // 
            // cboPraticien
            // 
            this.cboPraticien.FormattingEnabled = true;
            this.cboPraticien.Location = new System.Drawing.Point(41, 26);
            this.cboPraticien.Name = "cboPraticien";
            this.cboPraticien.Size = new System.Drawing.Size(121, 21);
            this.cboPraticien.TabIndex = 3;
            this.cboPraticien.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboPraticien_Format);
            // 
            // bsMedecin
            // 
            this.bsMedecin.CurrentChanged += new System.EventHandler(this.BsMedecin_CurrentChanged);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(41, 293);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(76, 23);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(142, 293);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // FTousRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.cboPraticien);
            this.Controls.Add(this.dgvRapport);
            this.Controls.Add(this.label1);
            this.Name = "FTousRapports";
            this.Text = "FTousRapports";
            this.Load += new System.EventHandler(this.FTousRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.ComboBox cboPraticien;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjout;
    }
}