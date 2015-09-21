namespace BDProjekt.Controls
{
    partial class ZamowieniaControl
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
			this.zamowienyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nazwaWydawnictwaLlabel = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.confirmButton = new System.Windows.Forms.Button();
			this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kosztZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.klientIdKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pracownikIdPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rabatIdRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elementyZamowieniasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rabatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.realizacjaZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.kosztZamowieniaDataGridViewTextBoxColumn,
            this.klientIdKlientaDataGridViewTextBoxColumn,
            this.pracownikIdPracownikaDataGridViewTextBoxColumn,
            this.rabatIdRabatuDataGridViewTextBoxColumn,
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn,
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn,
            this.elementyZamowieniasDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.pracownikDataGridViewTextBoxColumn,
            this.rabatDataGridViewTextBoxColumn,
            this.realizacjaZamowieniaDataGridViewTextBoxColumn,
            this.rodzajWysylkiDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.zamowienyBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(789, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// zamowienyBindingSource
			// 
			this.zamowienyBindingSource.DataSource = typeof(BDProjekt.Zamowieny);
			// 
			// nazwaWydawnictwaLlabel
			// 
			this.nazwaWydawnictwaLlabel.AutoSize = true;
			this.nazwaWydawnictwaLlabel.Location = new System.Drawing.Point(13, 175);
			this.nazwaWydawnictwaLlabel.Name = "nazwaWydawnictwaLlabel";
			this.nazwaWydawnictwaLlabel.Size = new System.Drawing.Size(110, 13);
			this.nazwaWydawnictwaLlabel.TabIndex = 14;
			this.nazwaWydawnictwaLlabel.Text = "Nazwa Wydawnictwa";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(316, 168);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 13;
			this.resetButton.Text = "Czyść";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(129, 170);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchTextBox.TabIndex = 12;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(235, 168);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 11;
			this.searchButton.Text = "Szukaj";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(480, 170);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(75, 23);
			this.confirmButton.TabIndex = 10;
			this.confirmButton.Text = "Zatwierdź";
			this.confirmButton.UseVisualStyleBackColor = true;
			// 
			// idZamowieniaDataGridViewTextBoxColumn
			// 
			this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
			this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
			this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
			// 
			// kosztZamowieniaDataGridViewTextBoxColumn
			// 
			this.kosztZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "KosztZamowienia";
			this.kosztZamowieniaDataGridViewTextBoxColumn.HeaderText = "KosztZamowienia";
			this.kosztZamowieniaDataGridViewTextBoxColumn.Name = "kosztZamowieniaDataGridViewTextBoxColumn";
			// 
			// klientIdKlientaDataGridViewTextBoxColumn
			// 
			this.klientIdKlientaDataGridViewTextBoxColumn.DataPropertyName = "Klient_IdKlienta";
			this.klientIdKlientaDataGridViewTextBoxColumn.HeaderText = "Klient_IdKlienta";
			this.klientIdKlientaDataGridViewTextBoxColumn.Name = "klientIdKlientaDataGridViewTextBoxColumn";
			this.klientIdKlientaDataGridViewTextBoxColumn.Visible = false;
			// 
			// pracownikIdPracownikaDataGridViewTextBoxColumn
			// 
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_IdPracownika";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.HeaderText = "Pracownik_IdPracownika";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.Name = "pracownikIdPracownikaDataGridViewTextBoxColumn";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.Visible = false;
			// 
			// rabatIdRabatuDataGridViewTextBoxColumn
			// 
			this.rabatIdRabatuDataGridViewTextBoxColumn.DataPropertyName = "Rabat_IdRabatu";
			this.rabatIdRabatuDataGridViewTextBoxColumn.HeaderText = "Rabat_IdRabatu";
			this.rabatIdRabatuDataGridViewTextBoxColumn.Name = "rabatIdRabatuDataGridViewTextBoxColumn";
			this.rabatIdRabatuDataGridViewTextBoxColumn.Visible = false;
			// 
			// realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn
			// 
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia_IdRealizacji";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.Visible = false;
			// 
			// rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn
			// 
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajuWysylki_IdRodzajWysylki";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajuWysylki_IdRodzajWysylki";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.Visible = false;
			// 
			// elementyZamowieniasDataGridViewTextBoxColumn
			// 
			this.elementyZamowieniasDataGridViewTextBoxColumn.DataPropertyName = "ElementyZamowienias";
			this.elementyZamowieniasDataGridViewTextBoxColumn.HeaderText = "ElementyZamowienias";
			this.elementyZamowieniasDataGridViewTextBoxColumn.Name = "elementyZamowieniasDataGridViewTextBoxColumn";
			this.elementyZamowieniasDataGridViewTextBoxColumn.Visible = false;
			// 
			// klientDataGridViewTextBoxColumn
			// 
			this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
			this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
			this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
			// 
			// pracownikDataGridViewTextBoxColumn
			// 
			this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik";
			this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
			this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
			// 
			// rabatDataGridViewTextBoxColumn
			// 
			this.rabatDataGridViewTextBoxColumn.DataPropertyName = "Rabat";
			this.rabatDataGridViewTextBoxColumn.HeaderText = "Rabat";
			this.rabatDataGridViewTextBoxColumn.Name = "rabatDataGridViewTextBoxColumn";
			// 
			// realizacjaZamowieniaDataGridViewTextBoxColumn
			// 
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaDataGridViewTextBoxColumn";
			// 
			// rodzajWysylkiDataGridViewTextBoxColumn
			// 
			this.rodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajWysylki";
			this.rodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajWysylki";
			this.rodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajWysylkiDataGridViewTextBoxColumn";
			// 
			// ZamowieniaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nazwaWydawnictwaLlabel);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ZamowieniaControl";
			this.Size = new System.Drawing.Size(805, 278);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
        private System.Windows.Forms.Label nazwaWydawnictwaLlabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kosztZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn klientIdKlientaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIdPracownikaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rabatIdRabatuDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn elementyZamowieniasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rabatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn realizacjaZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rodzajWysylkiDataGridViewTextBoxColumn;
    }
}
