
namespace WindowsFormsAppTest
{
    partial class UCAuthentification
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(33, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(46, 20);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom:";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(33, 78);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(44, 20);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mdp:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(110, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 26);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(110, 78);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(100, 26);
            this.textBoxMdp.TabIndex = 3;
            this.textBoxMdp.TextChanged += new System.EventHandler(this.textBoxMdp_TextChanged);
            // 
            // UCAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelNom);
            this.Name = "UCAuthentification";
            this.Size = new System.Drawing.Size(279, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxMdp;
    }
}
