namespace BDProjekt.Controls
{
    partial class KlientZamowControl
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tytulColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypOkladki = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ilosccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idEgzemplarzaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyZamowieniasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaOferentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zamowienyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tytulColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladkaColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZamowieniaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowienyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyZamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nowaButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rodzajWysylkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.potwierdzButton = new System.Windows.Forms.Button();
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealizacjaZamowienia_IdRealizacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyZamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulColumn2,
            this.wydawnictwoColumn2,
            this.TypOkladki,
            this.ilosccDataGridViewTextBoxColumn,
            this.AddColumn,
            this.idEgzemplarzaDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn,
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn,
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn,
            this.ksiazkaDataGridViewTextBoxColumn,
            this.wydawnictwoDataGridViewTextBoxColumn,
            this.elementyDostawiesDataGridViewTextBoxColumn,
            this.elementyZamowieniasDataGridViewTextBoxColumn,
            this.ofertaOferentasDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.egzemplarzBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(721, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(518, 319);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // tytulColumn2
            // 
            this.tytulColumn2.HeaderText = "Tytul";
            this.tytulColumn2.Name = "tytulColumn2";
            this.tytulColumn2.ReadOnly = true;
            this.tytulColumn2.Width = 75;
            // 
            // wydawnictwoColumn2
            // 
            this.wydawnictwoColumn2.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn2.Name = "wydawnictwoColumn2";
            this.wydawnictwoColumn2.ReadOnly = true;
            this.wydawnictwoColumn2.Width = 75;
            // 
            // TypOkladki
            // 
            this.TypOkladki.DataPropertyName = "TypOkladki";
            this.TypOkladki.HeaderText = "TypOkladki";
            this.TypOkladki.Name = "TypOkladki";
            this.TypOkladki.ReadOnly = true;
            this.TypOkladki.Width = 60;
            // 
            // ilosccDataGridViewTextBoxColumn
            // 
            this.ilosccDataGridViewTextBoxColumn.DataPropertyName = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.HeaderText = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.Name = "ilosccDataGridViewTextBoxColumn";
            this.ilosccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddColumn
            // 
            this.AddColumn.HeaderText = "Add";
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.ReadOnly = true;
            this.AddColumn.Width = 40;
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn1
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn1.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn1.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn1.Name = "idEgzemplarzaDataGridViewTextBoxColumn1";
            this.idEgzemplarzaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idEgzemplarzaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ksiazkaIdKsiazkiDataGridViewTextBoxColumn
            // 
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "Ksiazka_IdKsiazki";
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn.HeaderText = "Ksiazka_IdKsiazki";
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn.Name = "ksiazkaIdKsiazkiDataGridViewTextBoxColumn";
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ksiazkaIdKsiazkiDataGridViewTextBoxColumn.Visible = false;
            // 
            // wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn
            // 
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "Wydawnictwo_IdWydawnictwa";
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn.HeaderText = "Wydawnictwo_IdWydawnictwa";
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn.Name = "wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn";
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ksiazkaDataGridViewTextBoxColumn
            // 
            this.ksiazkaDataGridViewTextBoxColumn.DataPropertyName = "Ksiazka";
            this.ksiazkaDataGridViewTextBoxColumn.HeaderText = "Ksiazka";
            this.ksiazkaDataGridViewTextBoxColumn.Name = "ksiazkaDataGridViewTextBoxColumn";
            this.ksiazkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ksiazkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // wydawnictwoDataGridViewTextBoxColumn
            // 
            this.wydawnictwoDataGridViewTextBoxColumn.DataPropertyName = "Wydawnictwo";
            this.wydawnictwoDataGridViewTextBoxColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoDataGridViewTextBoxColumn.Name = "wydawnictwoDataGridViewTextBoxColumn";
            this.wydawnictwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.wydawnictwoDataGridViewTextBoxColumn.Visible = false;
            // 
            // elementyDostawiesDataGridViewTextBoxColumn
            // 
            this.elementyDostawiesDataGridViewTextBoxColumn.DataPropertyName = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.HeaderText = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.Name = "elementyDostawiesDataGridViewTextBoxColumn";
            this.elementyDostawiesDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementyDostawiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // elementyZamowieniasDataGridViewTextBoxColumn
            // 
            this.elementyZamowieniasDataGridViewTextBoxColumn.DataPropertyName = "ElementyZamowienias";
            this.elementyZamowieniasDataGridViewTextBoxColumn.HeaderText = "ElementyZamowienias";
            this.elementyZamowieniasDataGridViewTextBoxColumn.Name = "elementyZamowieniasDataGridViewTextBoxColumn";
            this.elementyZamowieniasDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementyZamowieniasDataGridViewTextBoxColumn.Visible = false;
            // 
            // ofertaOferentasDataGridViewTextBoxColumn
            // 
            this.ofertaOferentasDataGridViewTextBoxColumn.DataPropertyName = "OfertaOferentas";
            this.ofertaOferentasDataGridViewTextBoxColumn.HeaderText = "OfertaOferentas";
            this.ofertaOferentasDataGridViewTextBoxColumn.Name = "ofertaOferentasDataGridViewTextBoxColumn";
            this.ofertaOferentasDataGridViewTextBoxColumn.ReadOnly = true;
            this.ofertaOferentasDataGridViewTextBoxColumn.Visible = false;
            // 
            // egzemplarzBindingSource
            // 
            this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.Rabat,
            this.dataGridViewTextBoxColumn1,
            this.RealizacjaZamowienia_IdRealizacji});
            this.dataGridView1.DataSource = this.zamowienyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(191, 319);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // zamowienyBindingSource
            // 
            this.zamowienyBindingSource.DataSource = typeof(BDProjekt.Zamowieny);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulColumn,
            this.wydawnictwoColumn,
            this.okladkaColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.idEgzemplarzaDataGridViewTextBoxColumn,
            this.idZamowieniaDataGridViewTextBoxColumn1,
            this.egzemplarzDataGridViewTextBoxColumn,
            this.zamowienyDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.elementyZamowieniaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(202, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(513, 319);
            this.dataGridView2.TabIndex = 6;
            // 
            // tytulColumn
            // 
            this.tytulColumn.HeaderText = "Tytul";
            this.tytulColumn.Name = "tytulColumn";
            this.tytulColumn.Width = 75;
            // 
            // wydawnictwoColumn
            // 
            this.wydawnictwoColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn.Name = "wydawnictwoColumn";
            this.wydawnictwoColumn.Width = 75;
            // 
            // okladkaColumn
            // 
            this.okladkaColumn.HeaderText = "Okladka";
            this.okladkaColumn.Name = "okladkaColumn";
            this.okladkaColumn.Width = 60;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idZamowieniaDataGridViewTextBoxColumn1
            // 
            this.idZamowieniaDataGridViewTextBoxColumn1.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn1.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn1.Name = "idZamowieniaDataGridViewTextBoxColumn1";
            this.idZamowieniaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // egzemplarzDataGridViewTextBoxColumn
            // 
            this.egzemplarzDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarz";
            this.egzemplarzDataGridViewTextBoxColumn.HeaderText = "Egzemplarz";
            this.egzemplarzDataGridViewTextBoxColumn.Name = "egzemplarzDataGridViewTextBoxColumn";
            this.egzemplarzDataGridViewTextBoxColumn.Visible = false;
            // 
            // zamowienyDataGridViewTextBoxColumn
            // 
            this.zamowienyDataGridViewTextBoxColumn.DataPropertyName = "Zamowieny";
            this.zamowienyDataGridViewTextBoxColumn.HeaderText = "Zamowieny";
            this.zamowienyDataGridViewTextBoxColumn.Name = "zamowienyDataGridViewTextBoxColumn";
            this.zamowienyDataGridViewTextBoxColumn.Visible = false;
            // 
            // elementyZamowieniaBindingSource
            // 
            this.elementyZamowieniaBindingSource.DataSource = typeof(BDProjekt.ElementyZamowienia);
            // 
            // nowaButton
            // 
            this.nowaButton.Location = new System.Drawing.Point(283, 364);
            this.nowaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nowaButton.Name = "nowaButton";
            this.nowaButton.Size = new System.Drawing.Size(204, 35);
            this.nowaButton.TabIndex = 5;
            this.nowaButton.Text = "Nowe zamowienie";
            this.nowaButton.UseVisualStyleBackColor = true;
            this.nowaButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rodzajWysylkiBindingSource;
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "IdRodzajWysylki";
            // 
            // rodzajWysylkiBindingSource
            // 
            this.rodzajWysylkiBindingSource.DataSource = typeof(BDProjekt.RodzajWysylki);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rodzaj Wysyłki";
            // 
            // potwierdzButton
            // 
            this.potwierdzButton.Location = new System.Drawing.Point(569, 328);
            this.potwierdzButton.Name = "potwierdzButton";
            this.potwierdzButton.Size = new System.Drawing.Size(146, 34);
            this.potwierdzButton.TabIndex = 10;
            this.potwierdzButton.Text = "Potwierdz zamowienie";
            this.potwierdzButton.UseVisualStyleBackColor = true;
            this.potwierdzButton.Click += new System.EventHandler(this.potwierdzButton_Click);
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idZamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idZamowieniaDataGridViewTextBoxColumn.Width = 70;
            // 
            // Rabat
            // 
            this.Rabat.DataPropertyName = "Rabat";
            this.Rabat.HeaderText = "Rabat";
            this.Rabat.Name = "Rabat";
            this.Rabat.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KosztZamowienia";
            this.dataGridViewTextBoxColumn1.HeaderText = "KosztZamowienia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // RealizacjaZamowienia_IdRealizacji
            // 
            this.RealizacjaZamowienia_IdRealizacji.DataPropertyName = "RealizacjaZamowienia_IdRealizacji";
            this.RealizacjaZamowienia_IdRealizacji.HeaderText = "RealizacjaZamowienia_IdRealizacji";
            this.RealizacjaZamowienia_IdRealizacji.Name = "RealizacjaZamowienia_IdRealizacji";
            this.RealizacjaZamowienia_IdRealizacji.Visible = false;
            // 
            // KlientZamowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.potwierdzButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nowaButton);
            this.Name = "KlientZamowControl";
            this.Size = new System.Drawing.Size(1303, 437);
            this.Load += new System.EventHandler(this.KlientZamowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyZamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajWysylkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button nowaButton;
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okladkaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowienyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource elementyZamowieniaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TypOkladki;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AddColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksiazkaIdKsiazkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoIdWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksiazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyDostawiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyZamowieniasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofertaOferentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource rodzajWysylkiBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potwierdzButton;
        private System.Windows.Forms.DataGridViewButtonColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealizacjaZamowienia_IdRealizacji;
    }
}
