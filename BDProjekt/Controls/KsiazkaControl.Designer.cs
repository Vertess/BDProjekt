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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.opisLabel = new System.Windows.Forms.Label();
            this.tytulLabel = new System.Windows.Forms.Label();
            this.searchOpisTextBox = new System.Windows.Forms.TextBox();
            this.searchTytulTextBox = new System.Windows.Forms.TextBox();
            this.searchOpisButton = new System.Windows.Forms.Button();
            this.resetOpisButton = new System.Windows.Forms.Button();
            this.searchTytulButton = new System.Windows.Forms.Button();
            this.resetTytulButton = new System.Windows.Forms.Button();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.opisDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.autorzyKsiazkisDataGridViewTextBoxColumn,
            this.gatunekComboBoxColumn});
            this.dataGridView1.DataSource = this.ksiazkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(364, 152);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(3, 157);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(79, 13);
            this.opisLabel.TabIndex = 2;
            this.opisLabel.Text = "Fragment opisu";
            // 
            // tytulLabel
            // 
            this.tytulLabel.AutoSize = true;
            this.tytulLabel.Location = new System.Drawing.Point(0, 183);
            this.tytulLabel.Name = "tytulLabel";
            this.tytulLabel.Size = new System.Drawing.Size(32, 13);
            this.tytulLabel.TabIndex = 3;
            this.tytulLabel.Text = "Tytuł";
            // 
            // searchOpisTextBox
            // 
            this.searchOpisTextBox.Location = new System.Drawing.Point(88, 154);
            this.searchOpisTextBox.Name = "searchOpisTextBox";
            this.searchOpisTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchOpisTextBox.TabIndex = 4;
            this.searchOpisTextBox.TextChanged += new System.EventHandler(this.searchOpisTextBox_TextChanged);
            // 
            // searchTytulTextBox
            // 
            this.searchTytulTextBox.Location = new System.Drawing.Point(38, 180);
            this.searchTytulTextBox.Name = "searchTytulTextBox";
            this.searchTytulTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTytulTextBox.TabIndex = 5;
            this.searchTytulTextBox.TextChanged += new System.EventHandler(this.searchTytulTextBox_TextChanged);
            // 
            // searchOpisButton
            // 
            this.searchOpisButton.Location = new System.Drawing.Point(194, 152);
            this.searchOpisButton.Name = "searchOpisButton";
            this.searchOpisButton.Size = new System.Drawing.Size(75, 23);
            this.searchOpisButton.TabIndex = 6;
            this.searchOpisButton.Text = "Szukaj";
            this.searchOpisButton.UseVisualStyleBackColor = true;
            this.searchOpisButton.Click += new System.EventHandler(this.searchOpisButton_Click);
            // 
            // resetOpisButton
            // 
            this.resetOpisButton.Location = new System.Drawing.Point(275, 152);
            this.resetOpisButton.Name = "resetOpisButton";
            this.resetOpisButton.Size = new System.Drawing.Size(75, 23);
            this.resetOpisButton.TabIndex = 7;
            this.resetOpisButton.Text = "Czyść";
            this.resetOpisButton.UseVisualStyleBackColor = true;
            this.resetOpisButton.Click += new System.EventHandler(this.resetOpisButton_Click);
            // 
            // searchTytulButton
            // 
            this.searchTytulButton.Location = new System.Drawing.Point(144, 178);
            this.searchTytulButton.Name = "searchTytulButton";
            this.searchTytulButton.Size = new System.Drawing.Size(75, 23);
            this.searchTytulButton.TabIndex = 8;
            this.searchTytulButton.Text = "Szukaj";
            this.searchTytulButton.UseVisualStyleBackColor = true;
            this.searchTytulButton.Click += new System.EventHandler(this.searchTytulButton_Click);
            // 
            // resetTytulButton
            // 
            this.resetTytulButton.Location = new System.Drawing.Point(225, 178);
            this.resetTytulButton.Name = "resetTytulButton";
            this.resetTytulButton.Size = new System.Drawing.Size(75, 23);
            this.resetTytulButton.TabIndex = 9;
            this.resetTytulButton.Text = "Czyść";
            this.resetTytulButton.UseVisualStyleBackColor = true;
            this.resetTytulButton.Click += new System.EventHandler(this.resetTytulButton_Click);
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
            this.autorzyKsiazkisDataGridViewTextBoxColumn.HeaderText = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Name = "autorzyKsiazkisDataGridViewTextBoxColumn";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gatunekComboBoxColumn
            // 
            this.gatunekComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.Controls.Add(this.resetTytulButton);
            this.Controls.Add(this.searchTytulButton);
            this.Controls.Add(this.resetOpisButton);
            this.Controls.Add(this.searchOpisButton);
            this.Controls.Add(this.searchTytulTextBox);
            this.Controls.Add(this.searchOpisTextBox);
            this.Controls.Add(this.tytulLabel);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KsiazkaControl";
            this.Size = new System.Drawing.Size(739, 251);
            this.Load += new System.EventHandler(this.KsiazkaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource ksiazkaBindingSource;
		private System.Windows.Forms.BindingSource gatunekBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.Label tytulLabel;
        private System.Windows.Forms.TextBox searchOpisTextBox;
        private System.Windows.Forms.TextBox searchTytulTextBox;
        private System.Windows.Forms.Button searchOpisButton;
        private System.Windows.Forms.Button resetOpisButton;
        private System.Windows.Forms.Button searchTytulButton;
        private System.Windows.Forms.Button resetTytulButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyKsiazkisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gatunekComboBoxColumn;
	}
}
