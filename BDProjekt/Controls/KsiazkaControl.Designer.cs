namespace BDProjekt
{
	partial class KsiazkaControl
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
<<<<<<< HEAD
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.zatwierdzButton = new System.Windows.Forms.Button();
			this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gatunekComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
=======
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
>>>>>>> d25ef7b789b062acfa77e8e09545e1a4171e9b69
            this.opisDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.autorzyKsiazkisDataGridViewTextBoxColumn,
            this.egzemplarzsDataGridViewTextBoxColumn,
<<<<<<< HEAD
            this.gatunekComboBoxColumn});
			this.dataGridView1.DataSource = this.ksiazkaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 42);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// zatwierdzButton
			// 
			this.zatwierdzButton.Location = new System.Drawing.Point(469, 224);
			this.zatwierdzButton.Name = "zatwierdzButton";
			this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
			this.zatwierdzButton.TabIndex = 1;
			this.zatwierdzButton.Text = "Zatwierdź";
			this.zatwierdzButton.UseVisualStyleBackColor = true;
			this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
			// 
			// gatunekBindingSource
			// 
			this.gatunekBindingSource.DataSource = typeof(BDProjekt.Gatunek);
			// 
			// ksiazkaBindingSource
			// 
			this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
			// 
			// opisDataGridViewTextBoxColumn
			// 
			this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
			this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
			this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
			// 
			// tytulDataGridViewTextBoxColumn
			// 
			this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
			this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
			this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
			// 
			// autorzyKsiazkisDataGridViewTextBoxColumn
			// 
			this.autorzyKsiazkisDataGridViewTextBoxColumn.DataPropertyName = "AutorzyKsiazkis";
			this.autorzyKsiazkisDataGridViewTextBoxColumn.HeaderText = "AutorzyKsiazkis";
			this.autorzyKsiazkisDataGridViewTextBoxColumn.Name = "autorzyKsiazkisDataGridViewTextBoxColumn";
			// 
			// egzemplarzsDataGridViewTextBoxColumn
			// 
			this.egzemplarzsDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarzs";
			this.egzemplarzsDataGridViewTextBoxColumn.HeaderText = "Egzemplarzs";
			this.egzemplarzsDataGridViewTextBoxColumn.Name = "egzemplarzsDataGridViewTextBoxColumn";
			// 
			// gatunekComboBoxColumn
			// 
			this.gatunekComboBoxColumn.DataSource = this.gatunekBindingSource;
			this.gatunekComboBoxColumn.DisplayMember = "NazwaGatunku";
			this.gatunekComboBoxColumn.HeaderText = "Gatunek";
			this.gatunekComboBoxColumn.Name = "gatunekComboBoxColumn";
			this.gatunekComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.gatunekComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.gatunekComboBoxColumn.ValueMember = "IdGatunku";
			// 
			// KsiazkaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.zatwierdzButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "KsiazkaControl";
			this.Size = new System.Drawing.Size(580, 277);
			this.Load += new System.EventHandler(this.KsiazkaControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
			this.ResumeLayout(false);
=======
            this.gatunekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ksiazkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // autorzyKsiazkisDataGridViewTextBoxColumn
            // 
            this.autorzyKsiazkisDataGridViewTextBoxColumn.DataPropertyName = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.HeaderText = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Name = "autorzyKsiazkisDataGridViewTextBoxColumn";
            // 
            // egzemplarzsDataGridViewTextBoxColumn
            // 
            this.egzemplarzsDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.HeaderText = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.Name = "egzemplarzsDataGridViewTextBoxColumn";
            // 
            // gatunekDataGridViewTextBoxColumn
            // 
            this.gatunekDataGridViewTextBoxColumn.DataPropertyName = "Gatunek";
            this.gatunekDataGridViewTextBoxColumn.DataSource = this.gatunekBindingSource;
            this.gatunekDataGridViewTextBoxColumn.DisplayMember = "NazwaGatunku";
            this.gatunekDataGridViewTextBoxColumn.HeaderText = "Gatunek";
            this.gatunekDataGridViewTextBoxColumn.Name = "gatunekDataGridViewTextBoxColumn";
            this.gatunekDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gatunekDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gatunekDataGridViewTextBoxColumn.ValueMember = "IdGatunku";
            // 
            // gatunekBindingSource
            // 
            this.gatunekBindingSource.DataSource = typeof(BDProjekt.Gatunek);
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(469, 224);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(190, 227);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(3, 227);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(109, 227);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // KsiazkaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KsiazkaControl";
            this.Size = new System.Drawing.Size(580, 277);
            this.Load += new System.EventHandler(this.KsiazkaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> d25ef7b789b062acfa77e8e09545e1a4171e9b69

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource ksiazkaBindingSource;
		private System.Windows.Forms.Button zatwierdzButton;
		private System.Windows.Forms.BindingSource gatunekBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn autorzyKsiazkisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzsDataGridViewTextBoxColumn;
<<<<<<< HEAD
		private System.Windows.Forms.DataGridViewComboBoxColumn gatunekComboBoxColumn;
=======
		private System.Windows.Forms.DataGridViewComboBoxColumn gatunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
>>>>>>> d25ef7b789b062acfa77e8e09545e1a4171e9b69
	}
}
