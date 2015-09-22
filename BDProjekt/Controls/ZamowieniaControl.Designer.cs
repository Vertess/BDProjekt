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
			this.idZamowieniaLabel = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.IdZamowieniaTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.confirmButton = new System.Windows.Forms.Button();
			this.idKlientLabel = new System.Windows.Forms.Label();
			this.idKlientaTextBox = new System.Windows.Forms.TextBox();
			this.idPracownikaTextBox = new System.Windows.Forms.TextBox();
			this.idPracownikaLabel = new System.Windows.Forms.Label();
			this.elementyButton = new System.Windows.Forms.Button();
			this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kosztZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.klientIdKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pracownikIdPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rabatIdRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elementyZamowieniasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rabatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.rabatBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.realizacjaZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.realizacjaZamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.rodzajWysylkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.zamowienyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.realizacjaZamowieniaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
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
			// idZamowieniaLabel
			// 
			this.idZamowieniaLabel.AutoSize = true;
			this.idZamowieniaLabel.Location = new System.Drawing.Point(13, 175);
			this.idZamowieniaLabel.Name = "idZamowieniaLabel";
			this.idZamowieniaLabel.Size = new System.Drawing.Size(76, 13);
			this.idZamowieniaLabel.TabIndex = 14;
			this.idZamowieniaLabel.Text = "Id Zamowienia";
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
			// IdZamowieniaTextBox
			// 
			this.IdZamowieniaTextBox.Location = new System.Drawing.Point(129, 170);
			this.IdZamowieniaTextBox.Name = "IdZamowieniaTextBox";
			this.IdZamowieniaTextBox.Size = new System.Drawing.Size(100, 20);
			this.IdZamowieniaTextBox.TabIndex = 12;
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
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// idKlientLabel
			// 
			this.idKlientLabel.AutoSize = true;
			this.idKlientLabel.Location = new System.Drawing.Point(13, 204);
			this.idKlientLabel.Name = "idKlientLabel";
			this.idKlientLabel.Size = new System.Drawing.Size(51, 13);
			this.idKlientLabel.TabIndex = 15;
			this.idKlientLabel.Text = "Id Klienta";
			// 
			// idKlientaTextBox
			// 
			this.idKlientaTextBox.Location = new System.Drawing.Point(129, 197);
			this.idKlientaTextBox.Name = "idKlientaTextBox";
			this.idKlientaTextBox.Size = new System.Drawing.Size(100, 20);
			this.idKlientaTextBox.TabIndex = 16;
			// 
			// idPracownikaTextBox
			// 
			this.idPracownikaTextBox.Location = new System.Drawing.Point(129, 223);
			this.idPracownikaTextBox.Name = "idPracownikaTextBox";
			this.idPracownikaTextBox.Size = new System.Drawing.Size(100, 20);
			this.idPracownikaTextBox.TabIndex = 18;
			// 
			// idPracownikaLabel
			// 
			this.idPracownikaLabel.AutoSize = true;
			this.idPracownikaLabel.Location = new System.Drawing.Point(13, 230);
			this.idPracownikaLabel.Name = "idPracownikaLabel";
			this.idPracownikaLabel.Size = new System.Drawing.Size(75, 13);
			this.idPracownikaLabel.TabIndex = 17;
			this.idPracownikaLabel.Text = "Id Pracownika";
			// 
			// elementyButton
			// 
			this.elementyButton.Location = new System.Drawing.Point(480, 220);
			this.elementyButton.Name = "elementyButton";
			this.elementyButton.Size = new System.Drawing.Size(137, 23);
			this.elementyButton.TabIndex = 19;
			this.elementyButton.Text = "Elementy Zamowienia";
			this.elementyButton.UseVisualStyleBackColor = true;
			this.elementyButton.Click += new System.EventHandler(this.elementyButton_Click);
			// 
			// idZamowieniaDataGridViewTextBoxColumn
			// 
			this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
			this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
			this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
			this.idZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// kosztZamowieniaDataGridViewTextBoxColumn
			// 
			this.kosztZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "KosztZamowienia";
			this.kosztZamowieniaDataGridViewTextBoxColumn.HeaderText = "KosztZamowienia";
			this.kosztZamowieniaDataGridViewTextBoxColumn.Name = "kosztZamowieniaDataGridViewTextBoxColumn";
			this.kosztZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// klientIdKlientaDataGridViewTextBoxColumn
			// 
			this.klientIdKlientaDataGridViewTextBoxColumn.DataPropertyName = "Klient_IdKlienta";
			this.klientIdKlientaDataGridViewTextBoxColumn.HeaderText = "Klient_IdKlienta";
			this.klientIdKlientaDataGridViewTextBoxColumn.Name = "klientIdKlientaDataGridViewTextBoxColumn";
			this.klientIdKlientaDataGridViewTextBoxColumn.ReadOnly = true;
			this.klientIdKlientaDataGridViewTextBoxColumn.Visible = false;
			// 
			// pracownikIdPracownikaDataGridViewTextBoxColumn
			// 
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_IdPracownika";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.HeaderText = "Pracownik_IdPracownika";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.Name = "pracownikIdPracownikaDataGridViewTextBoxColumn";
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
			this.pracownikIdPracownikaDataGridViewTextBoxColumn.Visible = false;
			// 
			// rabatIdRabatuDataGridViewTextBoxColumn
			// 
			this.rabatIdRabatuDataGridViewTextBoxColumn.DataPropertyName = "Rabat_IdRabatu";
			this.rabatIdRabatuDataGridViewTextBoxColumn.HeaderText = "Rabat_IdRabatu";
			this.rabatIdRabatuDataGridViewTextBoxColumn.Name = "rabatIdRabatuDataGridViewTextBoxColumn";
			this.rabatIdRabatuDataGridViewTextBoxColumn.ReadOnly = true;
			this.rabatIdRabatuDataGridViewTextBoxColumn.Visible = false;
			// 
			// realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn
			// 
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia_IdRealizacji";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn";
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.ReadOnly = true;
			this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.Visible = false;
			// 
			// rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn
			// 
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajuWysylki_IdRodzajWysylki";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajuWysylki_IdRodzajWysylki";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn";
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.ReadOnly = true;
			this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.Visible = false;
			// 
			// elementyZamowieniasDataGridViewTextBoxColumn
			// 
			this.elementyZamowieniasDataGridViewTextBoxColumn.DataPropertyName = "ElementyZamowienias";
			this.elementyZamowieniasDataGridViewTextBoxColumn.HeaderText = "ElementyZamowienias";
			this.elementyZamowieniasDataGridViewTextBoxColumn.Name = "elementyZamowieniasDataGridViewTextBoxColumn";
			this.elementyZamowieniasDataGridViewTextBoxColumn.ReadOnly = true;
			this.elementyZamowieniasDataGridViewTextBoxColumn.Visible = false;
			// 
			// klientDataGridViewTextBoxColumn
			// 
			this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient_IdKlienta";
			this.klientDataGridViewTextBoxColumn.DataSource = this.klientBindingSource;
			this.klientDataGridViewTextBoxColumn.DisplayMember = "Login";
			this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
			this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
			this.klientDataGridViewTextBoxColumn.ReadOnly = true;
			this.klientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.klientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.klientDataGridViewTextBoxColumn.ValueMember = "IdKlienta";
			// 
			// klientBindingSource
			// 
			this.klientBindingSource.DataSource = typeof(BDProjekt.Klient);
			// 
			// pracownikDataGridViewTextBoxColumn
			// 
			this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_IdPracownika";
			this.pracownikDataGridViewTextBoxColumn.DataSource = this.pracownikBindingSource;
			this.pracownikDataGridViewTextBoxColumn.DisplayMember = "Login";
			this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
			this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
			this.pracownikDataGridViewTextBoxColumn.ReadOnly = true;
			this.pracownikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.pracownikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.pracownikDataGridViewTextBoxColumn.ValueMember = "IdPracownika";
			// 
			// pracownikBindingSource
			// 
			this.pracownikBindingSource.DataSource = typeof(BDProjekt.Pracownik);
			// 
			// rabatDataGridViewTextBoxColumn
			// 
			this.rabatDataGridViewTextBoxColumn.DataPropertyName = "Rabat_IdRabatu";
			this.rabatDataGridViewTextBoxColumn.DataSource = this.rabatBindingSource;
			this.rabatDataGridViewTextBoxColumn.DisplayMember = "WysokoscRabatu";
			this.rabatDataGridViewTextBoxColumn.HeaderText = "Rabat";
			this.rabatDataGridViewTextBoxColumn.Name = "rabatDataGridViewTextBoxColumn";
			this.rabatDataGridViewTextBoxColumn.ReadOnly = true;
			this.rabatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.rabatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.rabatDataGridViewTextBoxColumn.ValueMember = "IdRabatu";
			// 
			// rabatBindingSource
			// 
			this.rabatBindingSource.DataSource = typeof(BDProjekt.Rabat);
			// 
			// realizacjaZamowieniaDataGridViewTextBoxColumn
			// 
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.DataSource = this.realizacjaZamowieniaBindingSource;
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.DisplayMember = "StatusZamowienia";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaDataGridViewTextBoxColumn";
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.realizacjaZamowieniaDataGridViewTextBoxColumn.ValueMember = "IdRealizacji";
			// 
			// realizacjaZamowieniaBindingSource
			// 
			this.realizacjaZamowieniaBindingSource.DataSource = typeof(BDProjekt.RealizacjaZamowienia);
			// 
			// rodzajWysylkiDataGridViewTextBoxColumn
			// 
			this.rodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajuWysylki_IdRodzajWysylki";
			this.rodzajWysylkiDataGridViewTextBoxColumn.DataSource = this.rodzajWysylkiBindingSource;
			this.rodzajWysylkiDataGridViewTextBoxColumn.DisplayMember = "Nazwa";
			this.rodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajWysylki";
			this.rodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajWysylkiDataGridViewTextBoxColumn";
			this.rodzajWysylkiDataGridViewTextBoxColumn.ReadOnly = true;
			this.rodzajWysylkiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.rodzajWysylkiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.rodzajWysylkiDataGridViewTextBoxColumn.ValueMember = "IdRodzajWysylki";
			// 
			// rodzajWysylkiBindingSource
			// 
			this.rodzajWysylkiBindingSource.DataSource = typeof(BDProjekt.RodzajWysylki);
			// 
			// zamowienyBindingSource
			// 
			this.zamowienyBindingSource.DataSource = typeof(BDProjekt.Zamowieny);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(663, 173);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ZamowieniaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.elementyButton);
			this.Controls.Add(this.idPracownikaTextBox);
			this.Controls.Add(this.idPracownikaLabel);
			this.Controls.Add(this.idKlientaTextBox);
			this.Controls.Add(this.idKlientLabel);
			this.Controls.Add(this.idZamowieniaLabel);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.IdZamowieniaTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ZamowieniaControl";
			this.Size = new System.Drawing.Size(805, 278);
			this.Load += new System.EventHandler(this.ZamowieniaControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.realizacjaZamowieniaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
        private System.Windows.Forms.Label idZamowieniaLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox IdZamowieniaTextBox;
        private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.Label idKlientLabel;
		private System.Windows.Forms.TextBox idKlientaTextBox;
		private System.Windows.Forms.TextBox idPracownikaTextBox;
		private System.Windows.Forms.Label idPracownikaLabel;
		private System.Windows.Forms.BindingSource klientBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kosztZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn klientIdKlientaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIdPracownikaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rabatIdRabatuDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn elementyZamowieniasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn klientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn pracownikDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource pracownikBindingSource;
		private System.Windows.Forms.DataGridViewComboBoxColumn rabatDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource rabatBindingSource;
		private System.Windows.Forms.DataGridViewComboBoxColumn realizacjaZamowieniaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource realizacjaZamowieniaBindingSource;
		private System.Windows.Forms.DataGridViewComboBoxColumn rodzajWysylkiDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource rodzajWysylkiBindingSource;
		private System.Windows.Forms.Button elementyButton;
		private System.Windows.Forms.Button button1;
    }
}
