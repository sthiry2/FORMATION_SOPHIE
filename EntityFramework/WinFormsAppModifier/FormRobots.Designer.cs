namespace WinFormsAppModifier
{
    partial class FormRobots
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
            dataGridView1 = new DataGridView();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(392, 160);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(483, 92);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(75, 23);
            buttonAjouter.TabIndex = 1;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(483, 136);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(75, 23);
            buttonModifier.TabIndex = 2;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // FormRobots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModifier);
            Controls.Add(buttonAjouter);
            Controls.Add(dataGridView1);
            Name = "FormRobots";
            Text = "FormRobots";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAjouter;
        private Button buttonModifier;
    }
}