
namespace WFToutEmbal
{
    partial class FormProduction
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
            this.labelNomProduction = new System.Windows.Forms.Label();
            this.labelNombreCaisseAProduire = new System.Windows.Forms.Label();
            this.labelNombreDeCaisseParHeure = new System.Windows.Forms.Label();
            this.textBoxNomDeProduction = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeCaisseAProduire = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeCaisseHeure = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomProduction
            // 
            this.labelNomProduction.AutoSize = true;
            this.labelNomProduction.Location = new System.Drawing.Point(132, 76);
            this.labelNomProduction.Name = "labelNomProduction";
            this.labelNomProduction.Size = new System.Drawing.Size(159, 20);
            this.labelNomProduction.TabIndex = 0;
            this.labelNomProduction.Text = "Nom de la production";
            // 
            // labelNombreCaisseAProduire
            // 
            this.labelNombreCaisseAProduire.AutoSize = true;
            this.labelNombreCaisseAProduire.Location = new System.Drawing.Point(132, 166);
            this.labelNombreCaisseAProduire.Name = "labelNombreCaisseAProduire";
            this.labelNombreCaisseAProduire.Size = new System.Drawing.Size(211, 20);
            this.labelNombreCaisseAProduire.TabIndex = 1;
            this.labelNombreCaisseAProduire.Text = "Nombre de caisse à produire";
            // 
            // labelNombreDeCaisseParHeure
            // 
            this.labelNombreDeCaisseParHeure.AutoSize = true;
            this.labelNombreDeCaisseParHeure.Location = new System.Drawing.Point(132, 260);
            this.labelNombreDeCaisseParHeure.Name = "labelNombreDeCaisseParHeure";
            this.labelNombreDeCaisseParHeure.Size = new System.Drawing.Size(208, 20);
            this.labelNombreDeCaisseParHeure.TabIndex = 2;
            this.labelNombreDeCaisseParHeure.Text = "Nombre de caisse par heure";
            // 
            // textBoxNomDeProduction
            // 
            this.textBoxNomDeProduction.Location = new System.Drawing.Point(373, 73);
            this.textBoxNomDeProduction.Name = "textBoxNomDeProduction";
            this.textBoxNomDeProduction.Size = new System.Drawing.Size(241, 26);
            this.textBoxNomDeProduction.TabIndex = 3;
            this.textBoxNomDeProduction.TextChanged += new System.EventHandler(this.textBoxNomDeProduction_TextChanged);
            // 
            // textBoxNombreDeCaisseAProduire
            // 
            this.textBoxNombreDeCaisseAProduire.Location = new System.Drawing.Point(373, 163);
            this.textBoxNombreDeCaisseAProduire.Name = "textBoxNombreDeCaisseAProduire";
            this.textBoxNombreDeCaisseAProduire.Size = new System.Drawing.Size(241, 26);
            this.textBoxNombreDeCaisseAProduire.TabIndex = 4;
            // 
            // textBoxNombreDeCaisseHeure
            // 
            this.textBoxNombreDeCaisseHeure.Location = new System.Drawing.Point(373, 257);
            this.textBoxNombreDeCaisseHeure.Name = "textBoxNombreDeCaisseHeure";
            this.textBoxNombreDeCaisseHeure.Size = new System.Drawing.Size(241, 26);
            this.textBoxNombreDeCaisseHeure.TabIndex = 5;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(373, 328);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(241, 35);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(136, 328);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(207, 35);
            this.buttonAnnuler.TabIndex = 7;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNombreDeCaisseHeure);
            this.Controls.Add(this.textBoxNombreDeCaisseAProduire);
            this.Controls.Add(this.textBoxNomDeProduction);
            this.Controls.Add(this.labelNombreDeCaisseParHeure);
            this.Controls.Add(this.labelNombreCaisseAProduire);
            this.Controls.Add(this.labelNomProduction);
            this.Name = "FormProduction";
            this.Text = "Production";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomProduction;
        private System.Windows.Forms.Label labelNombreCaisseAProduire;
        private System.Windows.Forms.Label labelNombreDeCaisseParHeure;
        private System.Windows.Forms.TextBox textBoxNomDeProduction;
        private System.Windows.Forms.TextBox textBoxNombreDeCaisseAProduire;
        private System.Windows.Forms.TextBox textBoxNombreDeCaisseHeure;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}