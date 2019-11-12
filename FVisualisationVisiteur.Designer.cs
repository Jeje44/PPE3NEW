namespace PPE3_Github_Tajek
{
    partial class FVisualisationVisiteur
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.régionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secteurToolStripMenuItem,
            this.régionToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // secteurToolStripMenuItem
            // 
            this.secteurToolStripMenuItem.Name = "secteurToolStripMenuItem";
            this.secteurToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.secteurToolStripMenuItem.Text = "Secteur";
            this.secteurToolStripMenuItem.Click += new System.EventHandler(this.SecteurToolStripMenuItem_Click);
            // 
            // régionToolStripMenuItem
            // 
            this.régionToolStripMenuItem.Name = "régionToolStripMenuItem";
            this.régionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.régionToolStripMenuItem.Text = "Région";
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.globalToolStripMenuItem.Text = "Global";
            // 
            // FVisualisationVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FVisualisationVisiteur";
            this.Text = "FVisualisationVisiteur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem régionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
    }
}