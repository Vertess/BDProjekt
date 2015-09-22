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
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.opisLabel = new System.Windows.Forms.Label();
            this.tytulLabel = new System.Windows.Forms.Label();
            this.searchOpisTextBox = new System.Windows.Forms.TextBox();
            this.searchTytulTextBox = new System.Windows.Forms.TextBox();
            this.resetTytulButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tytulDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.gatunekComboBoxColumn,
            this.autorzyKsiazkisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ksiazkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += Funkcje.Instance.dataGridView1_DataError;
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
            this.zatwierdzButton.Location = new System.Drawing.Point(546, 234);
            this.zatwierdzButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(112, 35);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(4, 242);
            this.opisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(120, 20);
            this.opisLabel.TabIndex = 2;
            this.opisLabel.Text = "Fragment opisu";
            // 
            // tytulLabel
            // 
            this.tytulLabel.AutoSize = true;
            this.tytulLabel.Location = new System.Drawing.Point(0, 282);
            this.tytulLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tytulLabel.Name = "tytulLabel";
            this.tytulLabel.Size = new System.Drawing.Size(43, 20);
            this.tytulLabel.TabIndex = 3;
            this.tytulLabel.Text = "Tytuł";
            // 
            // searchOpisTextBox
            // 
            this.searchOpisTextBox.Location = new System.Drawing.Point(132, 237);
            this.searchOpisTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchOpisTextBox.Name = "searchOpisTextBox";
            this.searchOpisTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchOpisTextBox.TabIndex = 4;
            // 
            // searchTytulTextBox
            // 
            this.searchTytulTextBox.Location = new System.Drawing.Point(57, 277);
            this.searchTytulTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTytulTextBox.Name = "searchTytulTextBox";
            this.searchTytulTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchTytulTextBox.TabIndex = 5;
            // 
            // resetTytulButton
            // 
            this.resetTytulButton.Location = new System.Drawing.Point(424, 266);
            this.resetTytulButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetTytulButton.Name = "resetTytulButton";
            this.resetTytulButton.Size = new System.Drawing.Size(112, 35);
            this.resetTytulButton.TabIndex = 9;
            this.resetTytulButton.Text = "Czyść";
            this.resetTytulButton.UseVisualStyleBackColor = true;
            this.resetTytulButton.Click += new System.EventHandler(this.resetTytulButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(303, 266);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 300;
            // 
            // gatunekComboBoxColumn
            // 
            this.gatunekComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gatunekComboBoxColumn.DataPropertyName = "Gatunek_IdGatunku";
            this.gatunekComboBoxColumn.DataSource = this.gatunekBindingSource;
            this.gatunekComboBoxColumn.DisplayMember = "NazwaGatunku";
            this.gatunekComboBoxColumn.HeaderText = "Gatunek";
            this.gatunekComboBoxColumn.Name = "gatunekComboBoxColumn";
            this.gatunekComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gatunekComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gatunekComboBoxColumn.ValueMember = "IdGatunku";
            // 
            // autorzyKsiazkisDataGridViewTextBoxColumn
            // 
            this.autorzyKsiazkisDataGridViewTextBoxColumn.HeaderText = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Name = "autorzyKsiazkisDataGridViewTextBoxColumn";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Visible = false;
            // 
            // KsiazkaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resetTytulButton);
            this.Controls.Add(this.searchTytulTextBox);
            this.Controls.Add(this.searchOpisTextBox);
            this.Controls.Add(this.tytulLabel);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KsiazkaControl";
            this.Size = new System.Drawing.Size(1108, 386);
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
		private System.Windows.Forms.Button resetTytulButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gatunekComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyKsiazkisDataGridViewTextBoxColumn;
	}
}
