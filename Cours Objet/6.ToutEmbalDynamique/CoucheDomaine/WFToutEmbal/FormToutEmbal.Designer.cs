
namespace WFToutEmbal
{
    partial class FormToutEmbal
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
            this.ajouterUneProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUCProgress = new System.Windows.Forms.Panel();
            this.demarrerLaPremiereProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneProductionToolStripMenuItem,
            this.demarrerLaPremiereProductionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterUneProductionToolStripMenuItem
            // 
            this.ajouterUneProductionToolStripMenuItem.Name = "ajouterUneProductionToolStripMenuItem";
            this.ajouterUneProductionToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.ajouterUneProductionToolStripMenuItem.Text = "Ajouter une production";
            this.ajouterUneProductionToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneProductionToolStripMenuItem_Click);
            // 
            // panelUCProgress
            // 
            this.panelUCProgress.AutoScroll = true;
            this.panelUCProgress.Location = new System.Drawing.Point(12, 266);
            this.panelUCProgress.Name = "panelUCProgress";
            this.panelUCProgress.Size = new System.Drawing.Size(953, 172);
            this.panelUCProgress.TabIndex = 2;
            // 
            // demarrerLaPremiereProductionToolStripMenuItem
            // 
            this.demarrerLaPremiereProductionToolStripMenuItem.Name = "demarrerLaPremiereProductionToolStripMenuItem";
            this.demarrerLaPremiereProductionToolStripMenuItem.Size = new System.Drawing.Size(284, 29);
            this.demarrerLaPremiereProductionToolStripMenuItem.Text = "Demarrer toutes les productions";
            this.demarrerLaPremiereProductionToolStripMenuItem.Click += new System.EventHandler(this.demarrerLaPremiereProductionToolStripMenuItem_Click);
            // 
            // FormToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.panelUCProgress);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormToutEmbal";
            this.Text = "FormToutEmbal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneProductionToolStripMenuItem;
        private System.Windows.Forms.Panel panelUCProgress;
        private System.Windows.Forms.ToolStripMenuItem demarrerLaPremiereProductionToolStripMenuItem;
    }
}