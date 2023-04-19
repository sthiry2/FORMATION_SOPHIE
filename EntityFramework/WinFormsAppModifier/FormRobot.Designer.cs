namespace WinFormsAppModifier
{
    partial class FormRobot
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
            labelX = new Label();
            labelY = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            buttonValiderOuModifier = new Button();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(155, 119);
            labelX.Name = "labelX";
            labelX.Size = new Size(17, 15);
            labelX.TabIndex = 0;
            labelX.Text = "X:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(155, 188);
            labelY.Name = "labelY";
            labelY.Size = new Size(17, 15);
            labelY.TabIndex = 1;
            labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(203, 118);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(209, 188);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // buttonValiderOuModifier
            // 
            buttonValiderOuModifier.DialogResult = DialogResult.OK;
            buttonValiderOuModifier.Location = new Point(397, 273);
            buttonValiderOuModifier.Name = "buttonValiderOuModifier";
            buttonValiderOuModifier.Size = new Size(75, 23);
            buttonValiderOuModifier.TabIndex = 4;
            buttonValiderOuModifier.Text = "Valider";
            buttonValiderOuModifier.UseVisualStyleBackColor = true;
            buttonValiderOuModifier.Click += buttonValiderOuModifier_Click;
            // 
            // FormRobot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 324);
            Controls.Add(buttonValiderOuModifier);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Name = "FormRobot";
            Text = "FormRobot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private Label labelY;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonValiderOuModifier;
    }
}