namespace PPE3_Github_Tajek
{
    partial class FRapportsDeVisite
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.dgvOffrir = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.cboPraticien = new System.Windows.Forms.ComboBox();
            this.dtpDateRapport = new System.Windows.Forms.DateTimePicker();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bsOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro Rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Praticien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Rapport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif Visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Offre d\'echantillons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bilan";
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Enabled = false;
            this.txtNumRapport.Location = new System.Drawing.Point(151, 42);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtNumRapport.TabIndex = 6;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(151, 216);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(209, 155);
            this.txtBilan.TabIndex = 10;
            // 
            // dgvOffrir
            // 
            this.dgvOffrir.AllowUserToAddRows = false;
            this.dgvOffrir.AllowUserToDeleteRows = false;
            this.dgvOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffrir.Location = new System.Drawing.Point(435, 232);
            this.dgvOffrir.Name = "dgvOffrir";
            this.dgvOffrir.ReadOnly = true;
            this.dgvOffrir.Size = new System.Drawing.Size(263, 150);
            this.dgvOffrir.TabIndex = 11;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(299, 81);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "Détails";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // cboPraticien
            // 
            this.cboPraticien.FormattingEnabled = true;
            this.cboPraticien.Location = new System.Drawing.Point(151, 81);
            this.cboPraticien.Name = "cboPraticien";
            this.cboPraticien.Size = new System.Drawing.Size(121, 21);
            this.cboPraticien.TabIndex = 7;
            this.cboPraticien.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboPraticien_Format);
            // 
            // dtpDateRapport
            // 
            this.dtpDateRapport.Location = new System.Drawing.Point(151, 129);
            this.dtpDateRapport.Name = "dtpDateRapport";
            this.dtpDateRapport.Size = new System.Drawing.Size(200, 20);
            this.dtpDateRapport.TabIndex = 13;
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(151, 171);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(139, 21);
            this.cboMotif.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rapport de visite";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(285, 407);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(99, 31);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.BsRapport_CurrentChanged);
            // 
            // bsMedecin
            // 
            this.bsMedecin.CurrentChanged += new System.EventHandler(this.BsMedecin_CurrentChanged);
            // 
            // FRapportsDeVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMotif);
            this.Controls.Add(this.dtpDateRapport);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvOffrir);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.cboPraticien);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRapportsDeVisite";
            this.Text = "FRapportsDeVisite";
            this.Load += new System.EventHandler(this.FRapportsDeVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DataGridView dgvOffrir;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.BindingSource bsOffrir;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.ComboBox cboPraticien;
        private System.Windows.Forms.DateTimePicker dtpDateRapport;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValider;
    }
}