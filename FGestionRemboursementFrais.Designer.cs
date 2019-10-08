namespace PPE3_Github_Tajek
{
    partial class FGestionRemboursementFrais
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
            this.Renseigner = new System.Windows.Forms.Button();
            this.Consulter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Renseigner
            // 
            this.Renseigner.Location = new System.Drawing.Point(203, 250);
            this.Renseigner.Name = "Renseigner";
            this.Renseigner.Size = new System.Drawing.Size(75, 23);
            this.Renseigner.TabIndex = 0;
            this.Renseigner.Text = "Renseigner";
            this.Renseigner.UseVisualStyleBackColor = true;
            this.Renseigner.Click += new System.EventHandler(this.Renseigner_Click);
            // 
            // Consulter
            // 
            this.Consulter.Location = new System.Drawing.Point(529, 250);
            this.Consulter.Name = "Consulter";
            this.Consulter.Size = new System.Drawing.Size(75, 23);
            this.Consulter.TabIndex = 1;
            this.Consulter.Text = "Consulter";
            this.Consulter.UseVisualStyleBackColor = true;
            this.Consulter.Click += new System.EventHandler(this.Consulter_Click);
            // 
            // FGestionRemboursementFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consulter);
            this.Controls.Add(this.Renseigner);
            this.Name = "FGestionRemboursementFrais";
            this.Text = "FGestionRemboursementFrais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Renseigner;
        private System.Windows.Forms.Button Consulter;
    }
}