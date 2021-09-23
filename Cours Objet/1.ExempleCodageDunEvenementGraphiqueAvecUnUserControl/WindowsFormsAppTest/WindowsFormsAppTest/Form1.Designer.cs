
namespace WindowsFormsAppTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.ucAuthentification1 = new WindowsFormsAppTest.UCAuthentification();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucAuthentification1
            // 
            this.ucAuthentification1.BackColor = System.Drawing.Color.Tomato;
            this.ucAuthentification1.Location = new System.Drawing.Point(698, 43);
            this.ucAuthentification1.Name = "ucAuthentification1";
            this.ucAuthentification1.Nom = "";
            this.ucAuthentification1.Size = new System.Drawing.Size(279, 155);
            this.ucAuthentification1.TabIndex = 1;
            this.ucAuthentification1.AuthentificationReussi += new System.EventHandler<WindowsFormsAppTest.AuthentificationReussiEventArgs>(this.ucAuthentification1_AuthentificationReussi);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 501);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ucAuthentification1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UCAuthentification ucAuthentification1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

