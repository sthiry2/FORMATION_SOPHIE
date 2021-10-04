namespace MettreAJourIHMPendantUnTraitement
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonAvanceAvecInvoke = new System.Windows.Forms.Button();
            this.buttonSansInvoke = new System.Windows.Forms.Button();
            this.buttonThreadPrincipale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 54);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(780, 45);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonAvanceAvecInvoke
            // 
            this.buttonAvanceAvecInvoke.Location = new System.Drawing.Point(458, 252);
            this.buttonAvanceAvecInvoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAvanceAvecInvoke.Name = "buttonAvanceAvecInvoke";
            this.buttonAvanceAvecInvoke.Size = new System.Drawing.Size(460, 36);
            this.buttonAvanceAvecInvoke.TabIndex = 1;
            this.buttonAvanceAvecInvoke.Text = "Avance A partir d un Thread Secondaire Avec Invoke";
            this.buttonAvanceAvecInvoke.UseVisualStyleBackColor = true;
            this.buttonAvanceAvecInvoke.Click += new System.EventHandler(this.buttonAvanceAPartirDUnAutreThreadPArInvoke_Click);
            // 
            // buttonSansInvoke
            // 
            this.buttonSansInvoke.Location = new System.Drawing.Point(458, 204);
            this.buttonSansInvoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSansInvoke.Name = "buttonSansInvoke";
            this.buttonSansInvoke.Size = new System.Drawing.Size(460, 35);
            this.buttonSansInvoke.TabIndex = 2;
            this.buttonSansInvoke.Text = "Avance A partir d un Thread Secondaire Sans Invoke";
            this.buttonSansInvoke.UseVisualStyleBackColor = true;
            this.buttonSansInvoke.Click += new System.EventHandler(this.buttonAvanceAPartirDUnAutreThreadSansInvoke_Click);
            // 
            // buttonThreadPrincipale
            // 
            this.buttonThreadPrincipale.Location = new System.Drawing.Point(458, 159);
            this.buttonThreadPrincipale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThreadPrincipale.Name = "buttonThreadPrincipale";
            this.buttonThreadPrincipale.Size = new System.Drawing.Size(460, 35);
            this.buttonThreadPrincipale.TabIndex = 3;
            this.buttonThreadPrincipale.Text = "Avance A partir Thread Principal";
            this.buttonThreadPrincipale.UseVisualStyleBackColor = true;
            this.buttonThreadPrincipale.Click += new System.EventHandler(this.buttonAvanceAPartirDuThreadPrincipale_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSansInvoke;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 313);
            this.Controls.Add(this.buttonThreadPrincipale);
            this.Controls.Add(this.buttonSansInvoke);
            this.Controls.Add(this.buttonAvanceAvecInvoke);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonAvanceAvecInvoke;
        private System.Windows.Forms.Button buttonSansInvoke;
        private System.Windows.Forms.Button buttonThreadPrincipale;
    }
}

