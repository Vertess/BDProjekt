namespace BDProjekt
{
    partial class Autorzy
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
            this.idAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchNazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.czyscNazwiskoButton = new System.Windows.Forms.Button();
            this.imieLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutoraDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAutoraDataGridViewTextBoxColumn
            // 
            this.idAutoraDataGridViewTextBoxColumn.DataPropertyName = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.HeaderText = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.Name = "idAutoraDataGridViewTextBoxColumn";
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BDProjekt.Autor);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(438, 194);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(123, 170);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchNazwiskoTextBox
            // 
            this.searchNazwiskoTextBox.Location = new System.Drawing.Point(123, 196);
            this.searchNazwiskoTextBox.Name = "searchNazwiskoTextBox";
            this.searchNazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchNazwiskoTextBox.TabIndex = 5;
            this.searchNazwiskoTextBox.TextChanged += new System.EventHandler(this.searchNazwiskoTextBox_TextChanged);
            // 
            // czyscNazwiskoButton
            // 
            this.czyscNazwiskoButton.Location = new System.Drawing.Point(238, 168);
            this.czyscNazwiskoButton.Name = "czyscNazwiskoButton";
            this.czyscNazwiskoButton.Size = new System.Drawing.Size(75, 23);
            this.czyscNazwiskoButton.TabIndex = 8;
            this.czyscNazwiskoButton.Text = "Czyść";
            this.czyscNazwiskoButton.UseVisualStyleBackColor = true;
            this.czyscNazwiskoButton.Click += new System.EventHandler(this.czyscNazwiskoButton_Click);
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(91, 175);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(26, 13);
            this.imieLabel.TabIndex = 9;
            this.imieLabel.Text = "Imie";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(64, 199);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(53, 13);
            this.nazwiskoLabel.TabIndex = 10;
            this.nazwiskoLabel.Text = "Nazwisko";
            // 
            // Autorzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieLabel);
            this.Controls.Add(this.czyscNazwiskoButton);
            this.Controls.Add(this.searchNazwiskoTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Autorzy";
            this.Size = new System.Drawing.Size(631, 263);
            this.Load += new System.EventHandler(this.Autorzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchNazwiskoTextBox;
        private System.Windows.Forms.Button czyscNazwiskoButton;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nazwiskoLabel;

    }
}
