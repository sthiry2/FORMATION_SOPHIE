namespace WinFormsApp6
{
    partial class FormCountry
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
            dataGridViewCountries = new DataGridView();
            buttonSupprimerCountry = new Button();
            buttonClear = new Button();
            textBoxId = new TextBox();
            textBoxConsole = new TextBox();
            buttonModifyUn = new Button();
            buttonSuprimerUn = new Button();
            buttonAjouterUn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            dataGridViewCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries.Location = new Point(102, 40);
            dataGridViewCountries.Name = "dataGridViewCountries";
            dataGridViewCountries.RowTemplate.Height = 25;
            dataGridViewCountries.Size = new Size(572, 226);
            dataGridViewCountries.TabIndex = 0;
            // 
            // buttonSupprimerCountry
            // 
            buttonSupprimerCountry.Location = new Point(969, 86);
            buttonSupprimerCountry.Name = "buttonSupprimerCountry";
            buttonSupprimerCountry.Size = new Size(254, 27);
            buttonSupprimerCountry.TabIndex = 14;
            buttonSupprimerCountry.Text = "SupprimerUnCountry Methode 2";
            buttonSupprimerCountry.UseVisualStyleBackColor = true;
            buttonSupprimerCountry.Click += buttonSupprimerCountry_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(1224, 265);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 26);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(931, 88);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(28, 23);
            textBoxId.TabIndex = 12;
            // 
            // textBoxConsole
            // 
            textBoxConsole.Location = new Point(67, 297);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Both;
            textBoxConsole.Size = new Size(1207, 247);
            textBoxConsole.TabIndex = 11;
            // 
            // buttonModifyUn
            // 
            buttonModifyUn.Location = new Point(706, 138);
            buttonModifyUn.Name = "buttonModifyUn";
            buttonModifyUn.Size = new Size(122, 29);
            buttonModifyUn.TabIndex = 10;
            buttonModifyUn.Text = "ModifierUnCountry";
            buttonModifyUn.UseVisualStyleBackColor = true;
            buttonModifyUn.Click += buttonModifyUn_Click;
            // 
            // buttonSuprimerUn
            // 
            buttonSuprimerUn.Location = new Point(706, 86);
            buttonSuprimerUn.Name = "buttonSuprimerUn";
            buttonSuprimerUn.Size = new Size(208, 26);
            buttonSuprimerUn.TabIndex = 9;
            buttonSuprimerUn.Text = "SupprimerUnCountry Methode 1";
            buttonSuprimerUn.UseVisualStyleBackColor = true;
            buttonSuprimerUn.Click += buttonSuprimerUn_Click;
            // 
            // buttonAjouterUn
            // 
            buttonAjouterUn.Location = new Point(707, 39);
            buttonAjouterUn.Name = "buttonAjouterUn";
            buttonAjouterUn.Size = new Size(121, 25);
            buttonAjouterUn.TabIndex = 8;
            buttonAjouterUn.Text = "AjouterUnCountry";
            buttonAjouterUn.UseVisualStyleBackColor = true;
            buttonAjouterUn.Click += buttonAjouterUn_Click;
            // 
            // FormCountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 650);
            Controls.Add(buttonSupprimerCountry);
            Controls.Add(buttonClear);
            Controls.Add(textBoxId);
            Controls.Add(textBoxConsole);
            Controls.Add(buttonModifyUn);
            Controls.Add(buttonSuprimerUn);
            Controls.Add(buttonAjouterUn);
            Controls.Add(dataGridViewCountries);
            Name = "FormCountry";
            Text = "FormCountry";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCountries;
        private Button buttonSupprimerCountry;
        private Button buttonClear;
        private TextBox textBoxId;
        private TextBox textBoxConsole;
        private Button buttonModifyUn;
        private Button buttonSuprimerUn;
        private Button buttonAjouterUn;
    }
}