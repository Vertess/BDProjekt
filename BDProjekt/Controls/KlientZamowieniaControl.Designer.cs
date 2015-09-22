namespace BDProjekt.Controls
{
    partial class KlientZamowieniaControl
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(995, 325);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // pracownikIdPracownikaDataGridViewTextBoxColumn
            // 
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_IdPracownika";
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.HeaderText = "Pracownik_IdPracownika";
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.Name = "pracownikIdPracownikaDataGridViewTextBoxColumn";
            // 
            // rabatIdRabatuDataGridViewTextBoxColumn
            // 
            this.rabatIdRabatuDataGridViewTextBoxColumn.DataPropertyName = "Rabat_IdRabatu";
            this.rabatIdRabatuDataGridViewTextBoxColumn.HeaderText = "Rabat_IdRabatu";
            this.rabatIdRabatuDataGridViewTextBoxColumn.Name = "rabatIdRabatuDataGridViewTextBoxColumn";
            // 
            // realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn
            // 
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjaZamowienia_IdRealizacji";
            this.realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn.Name = "realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn";
            // 
            // rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn
            // 
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.DataPropertyName = "RodzajuWysylki_IdRodzajWysylki";
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.HeaderText = "RodzajuWysylki_IdRodzajWysylki";
            this.rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn.Name = "rodzajuWysylkiIdRodzajWysylkiDataGridViewTextBoxColumn";
            // 
            // elementyZamowieniasDataGridViewTextBoxColumn
            // 
            this.elementyZamowieniasDataGridViewTextBoxColumn.DataPropertyName = "ElementyZamowienias";
            this.elementyZamowieniasDataGridViewTextBoxColumn.HeaderText = "ElementyZamowienias";
            this.elementyZamowieniasDataGridViewTextBoxColumn.Name = "elementyZamowieniasDataGridViewTextBoxColumn";
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
            // KlientZamowieniaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlientZamowieniaControl";
            this.Size = new System.Drawing.Size(1186, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
    }
}
