﻿namespace BDProjekt.Controls
{
    partial class OfertyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.zatwierdzButton = new System.Windows.Forms.Button();
			this.CenaHurtowaLabel = new System.Windows.Forms.Label();
			this.searchCenaHurtowaTextBox = new System.Windows.Forms.TextBox();
			this.searchCenaHurtowaButton = new System.Windows.Forms.Button();
			this.resetCenaHurtowaButton = new System.Windows.Forms.Button();
			this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oferentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ofertaOferentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idOfertyOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cenaHurtowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.egzemplarzComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.oferentComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfertyOferentaDataGridViewTextBoxColumn,
            this.cenaHurtowaDataGridViewTextBoxColumn,
            this.egzemplarzComboBoxColumn,
            this.oferentComboBoxColumn});
			this.dataGridView1.DataSource = this.ofertaOferentaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(27, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(445, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// zatwierdzButton
			// 
			this.zatwierdzButton.Location = new System.Drawing.Point(395, 190);
			this.zatwierdzButton.Name = "zatwierdzButton";
			this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
			this.zatwierdzButton.TabIndex = 1;
			this.zatwierdzButton.Text = "Zatwierdź";
			this.zatwierdzButton.UseVisualStyleBackColor = true;
			this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
			// 
			// CenaHurtowaLabel
			// 
			this.CenaHurtowaLabel.AutoSize = true;
			this.CenaHurtowaLabel.Location = new System.Drawing.Point(29, 199);
			this.CenaHurtowaLabel.Name = "CenaHurtowaLabel";
			this.CenaHurtowaLabel.Size = new System.Drawing.Size(35, 13);
			this.CenaHurtowaLabel.TabIndex = 2;
			this.CenaHurtowaLabel.Text = "Cena ";
			// 
			// searchCenaHurtowaTextBox
			// 
			this.searchCenaHurtowaTextBox.Location = new System.Drawing.Point(70, 196);
			this.searchCenaHurtowaTextBox.Name = "searchCenaHurtowaTextBox";
			this.searchCenaHurtowaTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchCenaHurtowaTextBox.TabIndex = 3;
			// 
			// searchCenaHurtowaButton
			// 
			this.searchCenaHurtowaButton.Location = new System.Drawing.Point(176, 194);
			this.searchCenaHurtowaButton.Name = "searchCenaHurtowaButton";
			this.searchCenaHurtowaButton.Size = new System.Drawing.Size(75, 23);
			this.searchCenaHurtowaButton.TabIndex = 4;
			this.searchCenaHurtowaButton.Text = "Szukaj";
			this.searchCenaHurtowaButton.UseVisualStyleBackColor = true;
			this.searchCenaHurtowaButton.Click += new System.EventHandler(this.searchCenaHurtowaButton_Click);
			// 
			// resetCenaHurtowaButton
			// 
			this.resetCenaHurtowaButton.Location = new System.Drawing.Point(257, 194);
			this.resetCenaHurtowaButton.Name = "resetCenaHurtowaButton";
			this.resetCenaHurtowaButton.Size = new System.Drawing.Size(75, 23);
			this.resetCenaHurtowaButton.TabIndex = 5;
			this.resetCenaHurtowaButton.Text = "Czyść";
			this.resetCenaHurtowaButton.UseVisualStyleBackColor = true;
			this.resetCenaHurtowaButton.Click += new System.EventHandler(this.resetCenaHurtowaButton_Click);
			// 
			// egzemplarzBindingSource
			// 
			this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
			// 
			// oferentBindingSource
			// 
			this.oferentBindingSource.DataSource = typeof(BDProjekt.Oferent);
			// 
			// ofertaOferentaBindingSource
			// 
			this.ofertaOferentaBindingSource.DataSource = typeof(BDProjekt.OfertaOferenta);
			// 
			// idOfertyOferentaDataGridViewTextBoxColumn
			// 
			this.idOfertyOferentaDataGridViewTextBoxColumn.DataPropertyName = "IdOfertyOferenta";
			this.idOfertyOferentaDataGridViewTextBoxColumn.HeaderText = "IdOfertyOferenta";
			this.idOfertyOferentaDataGridViewTextBoxColumn.Name = "idOfertyOferentaDataGridViewTextBoxColumn";
			// 
			// cenaHurtowaDataGridViewTextBoxColumn
			// 
			this.cenaHurtowaDataGridViewTextBoxColumn.DataPropertyName = "CenaHurtowa";
			this.cenaHurtowaDataGridViewTextBoxColumn.HeaderText = "CenaHurtowa";
			this.cenaHurtowaDataGridViewTextBoxColumn.Name = "cenaHurtowaDataGridViewTextBoxColumn";
			// 
			// egzemplarzComboBoxColumn
			// 
			this.egzemplarzComboBoxColumn.DataPropertyName = "Egzemplarz_IdEgzemplarza";
			this.egzemplarzComboBoxColumn.DataSource = this.egzemplarzBindingSource;
			this.egzemplarzComboBoxColumn.DisplayMember = "IdEgzemplarza";
			this.egzemplarzComboBoxColumn.HeaderText = "Egzemplarz";
			this.egzemplarzComboBoxColumn.Name = "egzemplarzComboBoxColumn";
			this.egzemplarzComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.egzemplarzComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.egzemplarzComboBoxColumn.ValueMember = "IdEgzemplarza";
			// 
			// oferentComboBoxColumn
			// 
			this.oferentComboBoxColumn.DataPropertyName = "Oferent_IdOferenta";
			this.oferentComboBoxColumn.DataSource = this.oferentBindingSource;
			this.oferentComboBoxColumn.DisplayMember = "NazwaFirmy";
			this.oferentComboBoxColumn.HeaderText = "Oferent";
			this.oferentComboBoxColumn.Name = "oferentComboBoxColumn";
			this.oferentComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.oferentComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.oferentComboBoxColumn.ValueMember = "IdOferenta";
			// 
			// OfertyControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.resetCenaHurtowaButton);
			this.Controls.Add(this.searchCenaHurtowaButton);
			this.Controls.Add(this.searchCenaHurtowaTextBox);
			this.Controls.Add(this.CenaHurtowaLabel);
			this.Controls.Add(this.zatwierdzButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "OfertyControl";
			this.Size = new System.Drawing.Size(473, 279);
			this.Load += new System.EventHandler(this.OfertyControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.BindingSource ofertaOferentaBindingSource;
        private System.Windows.Forms.BindingSource oferentBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.Label CenaHurtowaLabel;
        private System.Windows.Forms.TextBox searchCenaHurtowaTextBox;
        private System.Windows.Forms.Button searchCenaHurtowaButton;
		private System.Windows.Forms.Button resetCenaHurtowaButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOfertyOferentaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cenaHurtowaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn egzemplarzComboBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn oferentComboBoxColumn;
    }
}
