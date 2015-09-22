namespace BDProjekt.Controls
{
    partial class KlientZamowienieControl
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.odswierzbutton = new System.Windows.Forms.Button();
            this.idRodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajWysylkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realizacjaZamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowienyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajWysylkiColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kosztZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RabatColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PracownikColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Realizacjazamowienia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientIdKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikIdPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabatIdRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyZamowieniasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjaZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizacjaZamowieniaBindingSource)).BeginInit();
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
            this.RodzajWysylkiColumn,
            this.kosztZamowieniaDataGridViewTextBoxColumn,
            this.RabatColumn,
            this.PracownikColumn,
            this.Realizacjazamowienia,
            this.pracownikDataGridViewTextBoxColumn,
            this.klientIdKlientaDataGridViewTextBoxColumn,
            this.rabatDataGridViewTextBoxColumn,
            this.rodzajWysylkiDataGridViewTextBoxColumn,
            this.pracownikIdPracownikaDataGridViewTextBoxColumn,
            this.rabatIdRabatuDataGridViewTextBoxColumn,
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn,
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn,
            this.elementyZamowieniasDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.realizacjaZamowieniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowienyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1184, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRodzajWysylkiDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.zamowieniesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rodzajWysylkiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(376, 162);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rodzaje wysyłki";
            // 
            // odswierzbutton
            // 
            this.odswierzbutton.Location = new System.Drawing.Point(740, 254);
            this.odswierzbutton.Name = "odswierzbutton";
            this.odswierzbutton.Size = new System.Drawing.Size(158, 67);
            this.odswierzbutton.TabIndex = 4;
            this.odswierzbutton.Text = "odswierz";
            this.odswierzbutton.UseVisualStyleBackColor = true;
            this.odswierzbutton.Click += new System.EventHandler(this.odswierzbutton_Click);
            // 
            // idRodzajWysylkiDataGridViewTextBoxColumn
            // 
            this.idRodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "IdRodzajWysylki";
            this.idRodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "IdRodzajWysylki";
            this.idRodzajWysylkiDataGridViewTextBoxColumn.Name = "idRodzajWysylkiDataGridViewTextBoxColumn";
            this.idRodzajWysylkiDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // zamowieniesDataGridViewTextBoxColumn
            // 
            this.zamowieniesDataGridViewTextBoxColumn.DataPropertyName = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.HeaderText = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.Name = "zamowieniesDataGridViewTextBoxColumn";
            this.zamowieniesDataGridViewTextBoxColumn.Visible = false;
            // 
            // rodzajWysylkiBindingSource
            // 
            this.rodzajWysylkiBindingSource.DataSource = typeof(BDProjekt.RodzajWysylki);
            // 
            // rabatBindingSource
            // 
            this.rabatBindingSource.DataSource = typeof(BDProjekt.Rabat);
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataSource = typeof(BDProjekt.Pracownik);
            // 
            // realizacjaZamowieniaBindingSource
            // 
            this.realizacjaZamowieniaBindingSource.DataSource = typeof(BDProjekt.RealizacjaZamowienia);
            // 
            // zamowienyBindingSource
            // 
            this.zamowienyBindingSource.DataSource = typeof(BDProjekt.Zamowieny);
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RodzajWysylkiColumn
            // 
            this.RodzajWysylkiColumn.DataPropertyName = "RodzajuWysylki_IdRodzajWysylki";
            this.RodzajWysylkiColumn.DataSource = this.rodzajWysylkiBindingSource;
            this.RodzajWysylkiColumn.DisplayMember = "Nazwa";
            this.RodzajWysylkiColumn.HeaderText = "Rodzaj wysylki";
            this.RodzajWysylkiColumn.Name = "RodzajWysylkiColumn";
            this.RodzajWysylkiColumn.ReadOnly = true;
            this.RodzajWysylkiColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RodzajWysylkiColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RodzajWysylkiColumn.ValueMember = "IdRodzajWysylki";
            // 
            // kosztZamowieniaDataGridViewTextBoxColumn
            // 
            this.kosztZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "KosztZamowienia";
            this.kosztZamowieniaDataGridViewTextBoxColumn.HeaderText = "KosztZamowienia";
            this.kosztZamowieniaDataGridViewTextBoxColumn.Name = "kosztZamowieniaDataGridViewTextBoxColumn";
            this.kosztZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RabatColumn
            // 
            this.RabatColumn.DataPropertyName = "Rabat_IdRabatu";
            this.RabatColumn.DataSource = this.rabatBindingSource;
            this.RabatColumn.DisplayMember = "WysokoscRabatu";
            this.RabatColumn.HeaderText = "Rabat";
            this.RabatColumn.Name = "RabatColumn";
            this.RabatColumn.ReadOnly = true;
            this.RabatColumn.ValueMember = "IdRabatu";
            // 
            // PracownikColumn
            // 
            this.PracownikColumn.DataPropertyName = "Pracownik_IdPracownika";
            this.PracownikColumn.DataSource = this.pracownikBindingSource;
            this.PracownikColumn.DisplayMember = "Login";
            this.PracownikColumn.HeaderText = "Pracownik";
            this.PracownikColumn.Name = "PracownikColumn";
            this.PracownikColumn.ReadOnly = true;
            this.PracownikColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PracownikColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PracownikColumn.ValueMember = "IdPracownika";
            // 
            // Realizacjazamowienia
            // 
            this.Realizacjazamowienia.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
            this.Realizacjazamowienia.DataSource = this.realizacjaZamowieniaBindingSource;
            this.Realizacjazamowienia.DisplayMember = "StatusZamowienia";
            this.Realizacjazamowienia.HeaderText = "Status";
            this.Realizacjazamowienia.Name = "Realizacjazamowienia";
            this.Realizacjazamowienia.ReadOnly = true;
            this.Realizacjazamowienia.ValueMember = "IdRealizacji";
            // 
            // pracownikDataGridViewTextBoxColumn
            // 
            this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
            this.pracownikDataGridViewTextBoxColumn.Visible = false;
            // 
            // klientIdKlientaDataGridViewTextBoxColumn
            // 
            this.klientIdKlientaDataGridViewTextBoxColumn.DataPropertyName = "Klient_IdKlienta";
            this.klientIdKlientaDataGridViewTextBoxColumn.HeaderText = "Klient_IdKlienta";
            this.klientIdKlientaDataGridViewTextBoxColumn.Name = "klientIdKlientaDataGridViewTextBoxColumn";
            this.klientIdKlientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // rabatDataGridViewTextBoxColumn
            // 
            this.rabatDataGridViewTextBoxColumn.DataPropertyName = "Rabat";
            this.rabatDataGridViewTextBoxColumn.HeaderText = "Rabat";
            this.rabatDataGridViewTextBoxColumn.Name = "rabatDataGridViewTextBoxColumn";
            this.rabatDataGridViewTextBoxColumn.Visible = false;
            // 
            // rodzajWysylkiDataGridViewTextBoxColumn
            // 
            this.rodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajWysylki";
            this.rodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajWysylki";
            this.rodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajWysylkiDataGridViewTextBoxColumn";
            this.rodzajWysylkiDataGridViewTextBoxColumn.Visible = false;
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
            this.klientDataGridViewTextBoxColumn.Visible = false;
            // 
            // realizacjaZamowieniaDataGridViewTextBoxColumn
            // 
            this.realizacjaZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia";
            this.realizacjaZamowieniaDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia";
            this.realizacjaZamowieniaDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaDataGridViewTextBoxColumn";
            this.realizacjaZamowieniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // KlientZamowienieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.odswierzbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlientZamowienieControl";
            this.Size = new System.Drawing.Size(1245, 520);
            this.Load += new System.EventHandler(this.KlientZamowienieControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizacjaZamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
        private System.Windows.Forms.BindingSource rodzajWysylkiBindingSource;
        private System.Windows.Forms.BindingSource rabatBindingSource;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.BindingSource realizacjaZamowieniaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRodzajWysylkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowieniesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odswierzbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RodzajWysylkiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RabatColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn PracownikColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Realizacjazamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIdKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajWysylkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIdPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabatIdRabatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyZamowieniasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjaZamowieniaDataGridViewTextBoxColumn;
    }
}
