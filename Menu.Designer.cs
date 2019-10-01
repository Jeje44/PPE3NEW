namespace PPE3_Github_Tajek
{
    partial class Menu
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
            this.btnMiss1 = new System.Windows.Forms.Button();
            this.btnMiss2 = new System.Windows.Forms.Button();
            this.btnMiss3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMiss1
            // 
            this.btnMiss1.Location = new System.Drawing.Point(79, 58);
            this.btnMiss1.Name = "btnMiss1";
            this.btnMiss1.Size = new System.Drawing.Size(75, 23);
            this.btnMiss1.TabIndex = 0;
            this.btnMiss1.Text = "Mission1";
            this.btnMiss1.UseVisualStyleBackColor = true;
            // 
            // btnMiss2
            // 
            this.btnMiss2.Location = new System.Drawing.Point(229, 58);
            this.btnMiss2.Name = "btnMiss2";
            this.btnMiss2.Size = new System.Drawing.Size(75, 23);
            this.btnMiss2.TabIndex = 1;
            this.btnMiss2.Text = "Mission 2";
            this.btnMiss2.UseVisualStyleBackColor = true;
            this.btnMiss2.Click += new System.EventHandler(this.BtnMiss2_Click);
            // 
            // btnMiss3
            // 
            this.btnMiss3.Location = new System.Drawing.Point(387, 58);
            this.btnMiss3.Name = "btnMiss3";
            this.btnMiss3.Size = new System.Drawing.Size(75, 23);
            this.btnMiss3.TabIndex = 2;
            this.btnMiss3.Text = "Mission 3 ";
            this.btnMiss3.UseVisualStyleBackColor = true;
            this.btnMiss3.Click += new System.EventHandler(this.BtnMiss3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMiss3);
            this.Controls.Add(this.btnMiss2);
            this.Controls.Add(this.btnMiss1);
            this.Name = "Menu";
            this.Text = "Menu";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMiss1;
        private System.Windows.Forms.Button btnMiss2;
        private System.Windows.Forms.Button btnMiss3;
    }
}