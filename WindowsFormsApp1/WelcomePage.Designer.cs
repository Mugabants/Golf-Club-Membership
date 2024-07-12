namespace WindowsFormsApp1
{
    partial class welcomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proceedToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGolfClubInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proceedToLoginToolStripMenuItem,
            this.viewGolfClubInfoToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proceedToLoginToolStripMenuItem
            // 
            this.proceedToLoginToolStripMenuItem.Name = "proceedToLoginToolStripMenuItem";
            this.proceedToLoginToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.proceedToLoginToolStripMenuItem.Text = "Proceed to Login";
            this.proceedToLoginToolStripMenuItem.Click += new System.EventHandler(this.proceedToLoginToolStripMenuItem_Click);
            // 
            // viewGolfClubInfoToolStripMenuItem
            // 
            this.viewGolfClubInfoToolStripMenuItem.Name = "viewGolfClubInfoToolStripMenuItem";
            this.viewGolfClubInfoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.viewGolfClubInfoToolStripMenuItem.Text = "View Golf Club Info";
            this.viewGolfClubInfoToolStripMenuItem.Click += new System.EventHandler(this.viewGolfClubInfoToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO THE CHAPMAN GOLF CLUB";
            // 
            // welcomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "welcomepage";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proceedToLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGolfClubInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

