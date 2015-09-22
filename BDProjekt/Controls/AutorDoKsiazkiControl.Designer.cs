namespace BDProjekt.Controls
{
    partial class AutorDoKsiazkiControl
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.imieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUrodzeniaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorIdAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyKsiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idKsiazkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekIdGatunkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyKsiazkisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DodajColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyKsiazkisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyKsiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.idKsiazkiDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.gatunekIdGatunkuDataGridViewTextBoxColumn,
            this.autorzyKsiazkisDataGridViewTextBoxColumn,
            this.egzemplarzsDataGridViewTextBoxColumn,
            this.gatunekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ksiazkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieColumn,
            this.NazwiskoColumn,
            this.DataUrodzeniaColumn,
            this.autorIdAutoraDataGridViewTextBoxColumn,
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.ksiazkaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.autorzyKsiazkiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(249, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(474, 281);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodajColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.idAutoraDataGridViewTextBoxColumn,
            this.autorzyKsiazkisDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.autorBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(729, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(505, 278);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // imieColumn
            // 
            this.imieColumn.HeaderText = "Imie";
            this.imieColumn.Name = "imieColumn";
            this.imieColumn.ReadOnly = true;
            this.imieColumn.Width = 80;
            // 
            // NazwiskoColumn
            // 
            this.NazwiskoColumn.HeaderText = "Nazwisko";
            this.NazwiskoColumn.Name = "NazwiskoColumn";
            this.NazwiskoColumn.ReadOnly = true;
            this.NazwiskoColumn.Width = 80;
            // 
            // DataUrodzeniaColumn
            // 
            this.DataUrodzeniaColumn.HeaderText = "Data Urodzenia";
            this.DataUrodzeniaColumn.Name = "DataUrodzeniaColumn";
            this.DataUrodzeniaColumn.ReadOnly = true;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BDProjekt.Autor);
            // 
            // autorIdAutoraDataGridViewTextBoxColumn
            // 
            this.autorIdAutoraDataGridViewTextBoxColumn.DataPropertyName = "Autor_IdAutora";
            this.autorIdAutoraDataGridViewTextBoxColumn.HeaderText = "Autor_IdAutora";
            this.autorIdAutoraDataGridViewTextBoxColumn.Name = "autorIdAutoraDataGridViewTextBoxColumn";
            this.autorIdAutoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorIdAutoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // idKsiazkaIdKsiazkiDataGridViewTextBoxColumn
            // 
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "IdKsiazka_IdKsiazki";
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn.HeaderText = "IdKsiazka_IdKsiazki";
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn.Name = "idKsiazkaIdKsiazkiDataGridViewTextBoxColumn";
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKsiazkaIdKsiazkiDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Visible = false;
            // 
            // ksiazkaDataGridViewTextBoxColumn
            // 
            this.ksiazkaDataGridViewTextBoxColumn.DataPropertyName = "Ksiazka";
            this.ksiazkaDataGridViewTextBoxColumn.HeaderText = "Ksiazka";
            this.ksiazkaDataGridViewTextBoxColumn.Name = "ksiazkaDataGridViewTextBoxColumn";
            this.ksiazkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ksiazkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorzyKsiazkiBindingSource
            // 
            this.autorzyKsiazkiBindingSource.DataSource = typeof(BDProjekt.AutorzyKsiazki);
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tytulDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idKsiazkiDataGridViewTextBoxColumn
            // 
            this.idKsiazkiDataGridViewTextBoxColumn.DataPropertyName = "IdKsiazki";
            this.idKsiazkiDataGridViewTextBoxColumn.HeaderText = "IdKsiazki";
            this.idKsiazkiDataGridViewTextBoxColumn.Name = "idKsiazkiDataGridViewTextBoxColumn";
            this.idKsiazkiDataGridViewTextBoxColumn.Visible = false;
            this.idKsiazkiDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Visible = false;
            // 
            // gatunekIdGatunkuDataGridViewTextBoxColumn
            // 
            this.gatunekIdGatunkuDataGridViewTextBoxColumn.DataPropertyName = "Gatunek_IdGatunku";
            this.gatunekIdGatunkuDataGridViewTextBoxColumn.HeaderText = "Gatunek_IdGatunku";
            this.gatunekIdGatunkuDataGridViewTextBoxColumn.Name = "gatunekIdGatunkuDataGridViewTextBoxColumn";
            this.gatunekIdGatunkuDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorzyKsiazkisDataGridViewTextBoxColumn
            // 
            this.autorzyKsiazkisDataGridViewTextBoxColumn.DataPropertyName = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.HeaderText = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Name = "autorzyKsiazkisDataGridViewTextBoxColumn";
            this.autorzyKsiazkisDataGridViewTextBoxColumn.Visible = false;
            // 
            // egzemplarzsDataGridViewTextBoxColumn
            // 
            this.egzemplarzsDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.HeaderText = "Egzemplarzs";
            this.egzemplarzsDataGridViewTextBoxColumn.Name = "egzemplarzsDataGridViewTextBoxColumn";
            this.egzemplarzsDataGridViewTextBoxColumn.Visible = false;
            // 
            // gatunekDataGridViewTextBoxColumn
            // 
            this.gatunekDataGridViewTextBoxColumn.DataPropertyName = "Gatunek";
            this.gatunekDataGridViewTextBoxColumn.HeaderText = "Gatunek";
            this.gatunekDataGridViewTextBoxColumn.Name = "gatunekDataGridViewTextBoxColumn";
            this.gatunekDataGridViewTextBoxColumn.Visible = false;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
            // 
            // DodajColumn
            // 
            this.DodajColumn.HeaderText = "Add";
            this.DodajColumn.Name = "DodajColumn";
            this.DodajColumn.ReadOnly = true;
            this.DodajColumn.Width = 50;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 80;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "Data Urodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAutoraDataGridViewTextBoxColumn
            // 
            this.idAutoraDataGridViewTextBoxColumn.DataPropertyName = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.HeaderText = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.Name = "idAutoraDataGridViewTextBoxColumn";
            this.idAutoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAutoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorzyKsiazkisDataGridViewTextBoxColumn1
            // 
            this.autorzyKsiazkisDataGridViewTextBoxColumn1.DataPropertyName = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn1.HeaderText = "AutorzyKsiazkis";
            this.autorzyKsiazkisDataGridViewTextBoxColumn1.Name = "autorzyKsiazkisDataGridViewTextBoxColumn1";
            this.autorzyKsiazkisDataGridViewTextBoxColumn1.ReadOnly = true;
            this.autorzyKsiazkisDataGridViewTextBoxColumn1.Visible = false;
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(584, 287);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(105, 40);
            this.zatwierdzButton.TabIndex = 3;
            this.zatwierdzButton.Text = "Zatwierdz";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // AutorDoKsiazkiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AutorDoKsiazkiControl";
            this.Size = new System.Drawing.Size(1268, 462);
            this.Load += new System.EventHandler(this.AutorDoKsiazkiControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyKsiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKsiazkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatunekIdGatunkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyKsiazkisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource autorzyKsiazkiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUrodzeniaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorIdAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKsiazkaIdKsiazkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksiazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DodajColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyKsiazkisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button zatwierdzButton;
    }
}
