namespace PPE3_Github_Tajek
{
    partial class FChangerMdp
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
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNewMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewMDP2 = new System.Windows.Forms.TextBox();
            this.btnValiderMDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(305, 66);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(100, 20);
            this.tbMDP.TabIndex = 0;
            // 
            // tbNewMdp
            // 
            this.tbNewMdp.Location = new System.Drawing.Point(305, 104);
            this.tbNewMdp.Name = "tbNewMdp";
            this.tbNewMdp.Size = new System.Drawing.Size(100, 20);
            this.tbNewMdp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot de passe Actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saisir nouveau mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retaper le mot de passe";
            // 
            // tbNewMDP2
            // 
            this.tbNewMDP2.Location = new System.Drawing.Point(305, 145);
            this.tbNewMDP2.Name = "tbNewMDP2";
            this.tbNewMDP2.Size = new System.Drawing.Size(100, 20);
            this.tbNewMDP2.TabIndex = 5;
            // 
            // btnValiderMDP
            // 
            this.btnValiderMDP.Location = new System.Drawing.Point(305, 232);
            this.btnValiderMDP.Name = "btnValiderMDP";
            this.btnValiderMDP.Size = new System.Drawing.Size(75, 23);
            this.btnValiderMDP.TabIndex = 6;
            this.btnValiderMDP.Text = "Valider";
            this.btnValiderMDP.UseVisualStyleBackColor = true;
            this.btnValiderMDP.Click += new System.EventHandler(this.BtnValiderMDP_Click);
            // 
            // FChangerMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderMDP);
            this.Controls.Add(this.tbNewMDP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewMdp);
            this.Controls.Add(this.tbMDP);
            this.Name = "FChangerMdp";
            this.Text = "FChangerMdp";
            this.Load += new System.EventHandler(this.FChangerMdp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNewMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewMDP2;
        private System.Windows.Forms.Button btnValiderMDP;
    }
}