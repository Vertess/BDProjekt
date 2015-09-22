namespace BDProjekt.Controls
{
	partial class ElementyZamowieniaControl
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
			this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elementyZamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elementyZamowieniaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEgzemplarzaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.elementyZamowieniaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 15);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(245, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// idEgzemplarzaDataGridViewTextBoxColumn
			// 
			this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
			this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
			this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
			this.idEgzemplarzaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iloscDataGridViewTextBoxColumn
			// 
			this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
			this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
			this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
			this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// elementyZamowieniaBindingSource
			// 
			this.elementyZamowieniaBindingSource.DataSource = typeof(BDProjekt.ElementyZamowienia);
			// 
			// egzemplarzBindingSource
			// 
			this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
			// 
			// ElementyZamowieniaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Name = "ElementyZamowieniaControl";
			this.Size = new System.Drawing.Size(273, 294);
			this.Load += new System.EventHandler(this.ElementyZamowieniaControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elementyZamowieniaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource egzemplarzBindingSource;
		public System.Windows.Forms.BindingSource elementyZamowieniaBindingSource;
	}
}
