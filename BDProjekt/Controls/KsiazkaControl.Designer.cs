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
			this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gatunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.egzemplarzsDataGridViewTextBoxColumn,
            this.gatunekDataGridViewTextBoxColumn});
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
		private System.Windows.Forms.DataGridViewComboBoxColumn gatunekDataGridViewTextBoxColumn;
	}
}
