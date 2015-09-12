namespace BDProjekt
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
            this.idWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.nazwaWydawnictwaLlabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idWydawnictwaDataGridViewTextBoxColumn
            // 
            this.idWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "IdWydawnictwa";
            this.idWydawnictwaDataGridViewTextBoxColumn.HeaderText = "IdWydawnictwa";
            this.idWydawnictwaDataGridViewTextBoxColumn.Name = "idWydawnictwaDataGridViewTextBoxColumn";
            // 
            // nazwaWydawnictwaDataGridViewTextBoxColumn
            // 
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.HeaderText = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Name = "nazwaWydawnictwaDataGridViewTextBoxColumn";
            // 
            // egzemplarzsDataGridViewTextBoxColumn
            // 
            this.egzemplarzsDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.HeaderText = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.Name = "egzemplarzsDataGridViewTextBoxColumn";
            // 
            // wydawnictwoBindingSource
            // 
            this.wydawnictwoBindingSource.DataSource = typeof(BDProjekt.Wydawnictwo);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(306, 166);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(119, 168);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(225, 166);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(470, 168);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // nazwaWydawnictwaLlabel
            // 
            this.nazwaWydawnictwaLlabel.AutoSize = true;
            this.nazwaWydawnictwaLlabel.Location = new System.Drawing.Point(3, 173);
            this.nazwaWydawnictwaLlabel.Name = "nazwaWydawnictwaLlabel";
            this.nazwaWydawnictwaLlabel.Size = new System.Drawing.Size(110, 13);
            this.nazwaWydawnictwaLlabel.TabIndex = 9;
            this.nazwaWydawnictwaLlabel.Text = "Nazwa Wydawnictwa";
            // 
            // WydawnictwoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazwaWydawnictwaLlabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WydawnictwoControl";
            this.Size = new System.Drawing.Size(582, 298);
            this.Load += new System.EventHandler(this.WydawnictwoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wydawnictwoBindingSource;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label nazwaWydawnictwaLlabel;
    }
}
