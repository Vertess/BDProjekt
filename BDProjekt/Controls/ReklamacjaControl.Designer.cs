namespace BDProjekt
{
    partial class ReklamacjaControl
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
            this.nazwaWydawnictwaLlabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.idReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idTypuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjeReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reklamacjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReklamacjiDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.typDataGridViewCheckBoxColumn,
            this.idTypuDataGridViewTextBoxColumn,
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn,
            this.realizacjeReklamacjiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reklamacjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nazwaWydawnictwaLlabel
            // 
            this.nazwaWydawnictwaLlabel.AutoSize = true;
            this.nazwaWydawnictwaLlabel.Location = new System.Drawing.Point(28, 192);
            this.nazwaWydawnictwaLlabel.Name = "nazwaWydawnictwaLlabel";
            this.nazwaWydawnictwaLlabel.Size = new System.Drawing.Size(28, 13);
            this.nazwaWydawnictwaLlabel.TabIndex = 14;
            this.nazwaWydawnictwaLlabel.Text = "Opis";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(278, 187);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(62, 189);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(413, 189);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // idReklamacjiDataGridViewTextBoxColumn
            // 
            this.idReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.HeaderText = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.Name = "idReklamacjiDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // typDataGridViewCheckBoxColumn
            // 
            this.typDataGridViewCheckBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewCheckBoxColumn.HeaderText = "Typ";
            this.typDataGridViewCheckBoxColumn.Name = "typDataGridViewCheckBoxColumn";
            // 
            // idTypuDataGridViewTextBoxColumn
            // 
            this.idTypuDataGridViewTextBoxColumn.DataPropertyName = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.HeaderText = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.Name = "idTypuDataGridViewTextBoxColumn";
            // 
            // realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn
            // 
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjeReklamacji_IdRealizacji";
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjeReklamacji_IdRealizacji";
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.Name = "realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn";
            // 
            // realizacjeReklamacjiDataGridViewTextBoxColumn
            // 
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.Name = "realizacjeReklamacjiDataGridViewTextBoxColumn";
            // 
            // reklamacjaBindingSource
            // 
            this.reklamacjaBindingSource.DataSource = typeof(BDProjekt.Reklamacja);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(197, 187);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ReklamacjaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nazwaWydawnictwaLlabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReklamacjaControl";
            this.Size = new System.Drawing.Size(675, 307);
            this.Load += new System.EventHandler(this.ReklamacjaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReklamacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjeReklamacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reklamacjaBindingSource;
        private System.Windows.Forms.Label nazwaWydawnictwaLlabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button searchButton;
    }
}
