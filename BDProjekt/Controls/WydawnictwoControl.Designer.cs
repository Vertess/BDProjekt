﻿namespace BDProjekt
{
    partial class WydawnictwoControl
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
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.nazwaWydawnictwaLlabel = new System.Windows.Forms.Label();
            this.idWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWydawnictwaDataGridViewTextBoxColumn,
            this.nazwaWydawnictwaDataGridViewTextBoxColumn,
            this.egzemplarzsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wydawnictwoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // wydawnictwoBindingSource
            // 
            this.wydawnictwoBindingSource.DataSource = typeof(BDProjekt.Wydawnictwo);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(459, 255);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 35);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(178, 258);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(338, 255);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(705, 258);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 35);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nazwaWydawnictwaLlabel
            // 
            this.nazwaWydawnictwaLlabel.AutoSize = true;
            this.nazwaWydawnictwaLlabel.Location = new System.Drawing.Point(4, 266);
            this.nazwaWydawnictwaLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwaWydawnictwaLlabel.Name = "nazwaWydawnictwaLlabel";
            this.nazwaWydawnictwaLlabel.Size = new System.Drawing.Size(157, 20);
            this.nazwaWydawnictwaLlabel.TabIndex = 9;
            this.nazwaWydawnictwaLlabel.Text = "Nazwa Wydawnictwa";
            // 
            // idWydawnictwaDataGridViewTextBoxColumn
            // 
            this.idWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "IdWydawnictwa";
            this.idWydawnictwaDataGridViewTextBoxColumn.HeaderText = "IdWydawnictwa";
            this.idWydawnictwaDataGridViewTextBoxColumn.Name = "idWydawnictwaDataGridViewTextBoxColumn";
            this.idWydawnictwaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaWydawnictwaDataGridViewTextBoxColumn
            // 
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.HeaderText = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Name = "nazwaWydawnictwaDataGridViewTextBoxColumn";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Width = 200;
            // 
            // egzemplarzsDataGridViewTextBoxColumn
            // 
            this.egzemplarzsDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.HeaderText = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.Name = "egzemplarzsDataGridViewTextBoxColumn";
            this.egzemplarzsDataGridViewTextBoxColumn.Visible = false;
            // 
            // WydawnictwoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazwaWydawnictwaLlabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WydawnictwoControl";
            this.Size = new System.Drawing.Size(873, 458);
            this.Load += new System.EventHandler(this.WydawnictwoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wydawnictwoBindingSource;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label nazwaWydawnictwaLlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzsDataGridViewTextBoxColumn;
    }
}
