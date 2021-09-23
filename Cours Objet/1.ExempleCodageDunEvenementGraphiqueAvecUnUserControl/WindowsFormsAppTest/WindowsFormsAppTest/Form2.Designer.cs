
namespace WindowsFormsAppTest
{
    partial class Form2
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
            this.ucAuthentification1 = new WindowsFormsAppTest.UCAuthentification();
            this.SuspendLayout();
            // 
            // ucAuthentification1
            // 
            this.ucAuthentification1.BackColor = System.Drawing.Color.Tomato;
            this.ucAuthentification1.Location = new System.Drawing.Point(27, 14);
            this.ucAuthentification1.Name = "ucAuthentification1";
            this.ucAuthentification1.Nom = "Patrick";
            this.ucAuthentification1.Size = new System.Drawing.Size(279, 155);
            this.ucAuthentification1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 181);
            this.Controls.Add(this.ucAuthentification1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private UCAuthentification ucAuthentification1;
    }
}