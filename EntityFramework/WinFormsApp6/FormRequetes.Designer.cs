namespace WinFormsApp6
{
    partial class FormRequetes
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
            buttonSelect = new Button();
            buttonSelectWhere = new Button();
            buttonSelectAvecLink = new Button();
            SuspendLayout();
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(51, 36);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(103, 23);
            buttonSelect.TabIndex = 0;
            buttonSelect.Text = "buttonSelect";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonSelectWhere
            // 
            buttonSelectWhere.Location = new Point(51, 95);
            buttonSelectWhere.Name = "buttonSelectWhere";
            buttonSelectWhere.Size = new Size(149, 28);
            buttonSelectWhere.TabIndex = 1;
            buttonSelectWhere.Text = "buttonSelectWhere";
            buttonSelectWhere.UseVisualStyleBackColor = true;
            buttonSelectWhere.Click += buttonSelectWhere_Click;
            // 
            // buttonSelectAvecLink
            // 
            buttonSelectAvecLink.Location = new Point(51, 341);
            buttonSelectAvecLink.Name = "buttonSelectAvecLink";
            buttonSelectAvecLink.Size = new Size(167, 23);
            buttonSelectAvecLink.TabIndex = 2;
            buttonSelectAvecLink.Text = "buttonSelectAvecLink";
            buttonSelectAvecLink.UseVisualStyleBackColor = true;
            buttonSelectAvecLink.Click += buttonSelectAvecLink_Click;
            // 
            // FormRequetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSelectAvecLink);
            Controls.Add(buttonSelectWhere);
            Controls.Add(buttonSelect);
            Name = "FormRequetes";
            Text = "FormRequetes";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSelect;
        private Button buttonSelectWhere;
        private Button buttonSelectAvecLink;
    }
}