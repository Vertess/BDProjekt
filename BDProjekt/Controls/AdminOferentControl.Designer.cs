namespace BDProjekt
{
    partial class AdminOferentControl
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
			this.oferentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ofertaOferentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nazwagatunkuLabel = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.idOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazwaFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dostawasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ofertaOferentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOferentaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nazwaFirmyDataGridViewTextBoxColumn,
            this.dostawasDataGridViewTextBoxColumn,
            this.ofertaOferentasDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.oferentBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(548, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// oferentBindingSource
			// 
			this.oferentBindingSource.DataSource = typeof(BDProjekt.Oferent);
			// 
			// ofertaOferentaBindingSource
			// 
			this.ofertaOferentaBindingSource.DataSource = typeof(BDProjekt.OfertaOferenta);
			// 
			// nazwagatunkuLabel
			// 
			this.nazwagatunkuLabel.AutoSize = true;
			this.nazwagatunkuLabel.Location = new System.Drawing.Point(3, 192);
			this.nazwagatunkuLabel.Name = "nazwagatunkuLabel";
			this.nazwagatunkuLabel.Size = new System.Drawing.Size(67, 13);
			this.nazwagatunkuLabel.TabIndex = 15;
			this.nazwagatunkuLabel.Text = "Nazwa Firmy";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(280, 185);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 14;
			this.resetButton.Text = "Czyść";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(93, 187);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchTextBox.TabIndex = 13;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(199, 185);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 12;
			this.searchButton.Text = "Szukaj";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(416, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Zatwierdź";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// idOferentaDataGridViewTextBoxColumn
			// 
			this.idOferentaDataGridViewTextBoxColumn.DataPropertyName = "IdOferenta";
			this.idOferentaDataGridViewTextBoxColumn.HeaderText = "IdOferenta";
			this.idOferentaDataGridViewTextBoxColumn.Name = "idOferentaDataGridViewTextBoxColumn";
			// 
			// adresDataGridViewTextBoxColumn
			// 
			this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
			this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
			this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
			// 
			// nazwaFirmyDataGridViewTextBoxColumn
			// 
			this.nazwaFirmyDataGridViewTextBoxColumn.DataPropertyName = "NazwaFirmy";
			this.nazwaFirmyDataGridViewTextBoxColumn.HeaderText = "NazwaFirmy";
			this.nazwaFirmyDataGridViewTextBoxColumn.Name = "nazwaFirmyDataGridViewTextBoxColumn";
			// 
			// dostawasDataGridViewTextBoxColumn
			// 
			this.dostawasDataGridViewTextBoxColumn.DataPropertyName = "Dostawas";
			this.dostawasDataGridViewTextBoxColumn.HeaderText = "Dostawas";
			this.dostawasDataGridViewTextBoxColumn.Name = "dostawasDataGridViewTextBoxColumn";
			this.dostawasDataGridViewTextBoxColumn.Visible = false;
			// 
			// ofertaOferentasDataGridViewTextBoxColumn
			// 
			this.ofertaOferentasDataGridViewTextBoxColumn.DataPropertyName = "OfertaOferentas";
			this.ofertaOferentasDataGridViewTextBoxColumn.HeaderText = "OfertaOferentas";
			this.ofertaOferentasDataGridViewTextBoxColumn.Name = "ofertaOferentasDataGridViewTextBoxColumn";
			this.ofertaOferentasDataGridViewTextBoxColumn.Visible = false;
			// 
			// AdminOferentControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nazwagatunkuLabel);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "AdminOferentControl";
			this.Size = new System.Drawing.Size(677, 385);
			this.Load += new System.EventHandler(this.AdminOferentControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oferentBindingSource;
        private System.Windows.Forms.BindingSource ofertaOferentaBindingSource;
        private System.Windows.Forms.Label nazwagatunkuLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOferentaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dostawasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ofertaOferentasDataGridViewTextBoxColumn;
    }
}
