namespace WinFormsApp6
{
    partial class FormUnCity
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
            textBoxNom = new TextBox();
            labelCity = new Label();
            labelIdCity = new Label();
            textBox1 = new TextBox();
            labelCodeCountry = new Label();
            comboBox1 = new ComboBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(117, 62);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 0;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(44, 65);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(58, 15);
            labelCity.TabIndex = 1;
            labelCity.Text = "NomCity:";
            // 
            // labelIdCity
            // 
            labelIdCity.AutoSize = true;
            labelIdCity.Location = new Point(44, 26);
            labelIdCity.Name = "labelIdCity";
            labelIdCity.Size = new Size(41, 15);
            labelIdCity.TabIndex = 2;
            labelIdCity.Text = "IdCity:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // labelCodeCountry
            // 
            labelCodeCountry.AutoSize = true;
            labelCodeCountry.Location = new Point(44, 108);
            labelCodeCountry.Name = "labelCodeCountry";
            labelCodeCountry.Size = new Size(81, 15);
            labelCodeCountry.TabIndex = 4;
            labelCodeCountry.Text = "CodeCountry:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(370, 23);
            comboBox1.TabIndex = 5;
            // 
            // buttonValider
            // 
            buttonValider.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValider.Location = new Point(415, 190);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormUnCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 249);
            Controls.Add(buttonValider);
            Controls.Add(comboBox1);
            Controls.Add(labelCodeCountry);
            Controls.Add(textBox1);
            Controls.Add(labelIdCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxNom);
            Name = "FormUnCity";
            Text = "FormUnCity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNom;
        private Label labelCity;
        private Label labelIdCity;
        private TextBox textBox1;
        private Label labelCodeCountry;
        private ComboBox comboBox1;
        private Button buttonValider;
    }
}