namespace PPE3_Github_Tajek
{
    partial class FConnex
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnValidé = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiez vous";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(283, 96);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.Text = "dandre";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(283, 141);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 2;
            this.txtPasswd.Text = "dandre";
            // 
            // btnValidé
            // 
            this.btnValidé.Location = new System.Drawing.Point(469, 137);
            this.btnValidé.Name = "btnValidé";
            this.btnValidé.Size = new System.Drawing.Size(75, 23);
            this.btnValidé.TabIndex = 3;
            this.btnValidé.Text = "Validé";
            this.btnValidé.UseVisualStyleBackColor = true;
            this.btnValidé.Click += new System.EventHandler(this.BtnValidé_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(289, 180);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(176, 102);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Identifiant :";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(179, 147);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(80, 13);
            this.lblMDP.TabIndex = 6;
            this.lblMDP.Text = "Mot de passe : ";
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnValidé);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label1);
            this.Name = "FConnex";
            this.Text = "FConnex";
            this.Load += new System.EventHandler(this.FConnex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnValidé;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMDP;
    }
}