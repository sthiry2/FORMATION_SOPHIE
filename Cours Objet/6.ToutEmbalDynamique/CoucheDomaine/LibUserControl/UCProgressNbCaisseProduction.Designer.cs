
namespace LibUserControl
{
    partial class UCProgressNbCaisseProduction
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
            this.progressBarNbCaisseProduite = new System.Windows.Forms.ProgressBar();
            this.labelNomProduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarNbCaisseProduite
            // 
            this.progressBarNbCaisseProduite.Location = new System.Drawing.Point(253, 29);
            this.progressBarNbCaisseProduite.Name = "progressBarNbCaisseProduite";
            this.progressBarNbCaisseProduite.Size = new System.Drawing.Size(496, 37);
            this.progressBarNbCaisseProduite.TabIndex = 0;
            // 
            // labelNomProduction
            // 
            this.labelNomProduction.AutoSize = true;
            this.labelNomProduction.Location = new System.Drawing.Point(25, 38);
            this.labelNomProduction.Name = "labelNomProduction";
            this.labelNomProduction.Size = new System.Drawing.Size(85, 20);
            this.labelNomProduction.TabIndex = 1;
            this.labelNomProduction.Text = "Production";
            // 
            // UCProgressNbCaisseProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNomProduction);
            this.Controls.Add(this.progressBarNbCaisseProduite);
            this.Name = "UCProgressNbCaisseProduction";
            this.Size = new System.Drawing.Size(847, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarNbCaisseProduite;
        private System.Windows.Forms.Label labelNomProduction;
    }
}
