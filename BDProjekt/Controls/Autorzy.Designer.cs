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
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.resetButton = new System.Windows.Forms.Button();
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
			this.dataGridView1.Location = new System.Drawing.Point(42, 18);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(542, 191);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
			this.confirmButton.Location = new System.Drawing.Point(509, 215);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(75, 23);
			this.confirmButton.TabIndex = 1;
			this.confirmButton.Text = "Zatwierdź";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(148, 215);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Szukaj";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(42, 215);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchTextBox.TabIndex = 3;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(229, 215);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 4;
			this.resetButton.Text = "Czyść";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// Autorzy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button resetButton;

    }
}
