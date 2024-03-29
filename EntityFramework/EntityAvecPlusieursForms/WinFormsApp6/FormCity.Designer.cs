﻿namespace WinFormsApp6
{
    partial class FormCity
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonAjouterUnCitY = new Button();
            buttonSuprimerUnCity = new Button();
            buttonModifyUnCity = new Button();
            textBoxConsole = new TextBox();
            textBoxId = new TextBox();
            buttonClear = new Button();
            button1 = new Button();
            textBoxNom = new TextBox();
            labelNom = new Label();
            dataGridViewCities = new DataGridView();
            cityBindingSource = new BindingSource(components);
            countryBindingSource = new BindingSource(components);
            buttonSaveAll = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonAjouterUnCitY
            // 
            buttonAjouterUnCitY.Location = new Point(654, 52);
            buttonAjouterUnCitY.Name = "buttonAjouterUnCitY";
            buttonAjouterUnCitY.Size = new Size(121, 25);
            buttonAjouterUnCitY.TabIndex = 1;
            buttonAjouterUnCitY.Text = "AjouterUnCity";
            buttonAjouterUnCitY.UseVisualStyleBackColor = true;
            buttonAjouterUnCitY.Click += buttonAjouterUnCitY_Click;
            // 
            // buttonSuprimerUnCity
            // 
            buttonSuprimerUnCity.Location = new Point(653, 101);
            buttonSuprimerUnCity.Name = "buttonSuprimerUnCity";
            buttonSuprimerUnCity.Size = new Size(208, 26);
            buttonSuprimerUnCity.TabIndex = 2;
            buttonSuprimerUnCity.Text = "SupprimerUnCity Methode 1";
            buttonSuprimerUnCity.UseVisualStyleBackColor = true;
            buttonSuprimerUnCity.Click += buttonSuprimerUnCity_Click;
            // 
            // buttonModifyUnCity
            // 
            buttonModifyUnCity.Location = new Point(653, 151);
            buttonModifyUnCity.Name = "buttonModifyUnCity";
            buttonModifyUnCity.Size = new Size(122, 29);
            buttonModifyUnCity.TabIndex = 3;
            buttonModifyUnCity.Text = "ModifierUnCity";
            buttonModifyUnCity.UseVisualStyleBackColor = true;
            buttonModifyUnCity.Click += buttonModifyUnCity_Click;
            // 
            // textBoxConsole
            // 
            textBoxConsole.Location = new Point(14, 310);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Both;
            textBoxConsole.Size = new Size(1207, 247);
            textBoxConsole.TabIndex = 4;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(878, 101);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(28, 23);
            textBoxId.TabIndex = 5;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(1171, 278);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 26);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(916, 99);
            button1.Name = "button1";
            button1.Size = new Size(254, 27);
            button1.TabIndex = 7;
            button1.Text = "SupprimerUnCity Methode 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSuprimerUnCity_Click2;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(844, 155);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(100, 23);
            textBoxNom.TabIndex = 8;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(793, 158);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 9;
            labelNom.Text = "Nom";
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.AutoGenerateColumns = false;
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCities.DataSource = cityBindingSource;
            dataGridViewCities.Location = new Point(63, 42);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.RowTemplate.Height = 25;
            dataGridViewCities.Size = new Size(539, 245);
            dataGridViewCities.TabIndex = 10;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Models.Country);
            // 
            // buttonSaveAll
            // 
            buttonSaveAll.Location = new Point(644, 245);
            buttonSaveAll.Name = "buttonSaveAll";
            buttonSaveAll.Size = new Size(197, 42);
            buttonSaveAll.TabIndex = 11;
            buttonSaveAll.Text = "Sauvegarde Tout";
            buttonSaveAll.UseVisualStyleBackColor = true;
            buttonSaveAll.Click += buttonSaveAll_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CityId";
            dataGridViewTextBoxColumn1.HeaderText = "CityId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CityName";
            dataGridViewTextBoxColumn2.HeaderText = "CityName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CountryCode";
            dataGridViewTextBoxColumn3.HeaderText = "CountryCode";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "CountryCodeNavigation";
            dataGridViewTextBoxColumn4.HeaderText = "CountryCodeNavigation";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 569);
            Controls.Add(buttonSaveAll);
            Controls.Add(dataGridViewCities);
            Controls.Add(labelNom);
            Controls.Add(textBoxNom);
            Controls.Add(button1);
            Controls.Add(buttonClear);
            Controls.Add(textBoxId);
            Controls.Add(textBoxConsole);
            Controls.Add(buttonModifyUnCity);
            Controls.Add(buttonSuprimerUnCity);
            Controls.Add(buttonAjouterUnCitY);
            Name = "FormCity";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
        private Button buttonAjouterUnCitY;
        private Button buttonSuprimerUnCity;
        private Button buttonModifyUnCity;
        private TextBox textBoxConsole;
        private TextBox textBoxId;
        private Button buttonClear;
        private Button button1;
        private TextBox textBoxNom;
        private Label labelNom;
        private DataGridView dataGridViewCities;
        private BindingSource cityBindingSource;
        private BindingSource countryBindingSource;
        private Button buttonSaveAll;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}