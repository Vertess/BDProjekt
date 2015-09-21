namespace BDProjekt.Controls
{
    partial class DostawaControl
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.oferentComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EdytujDostawe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Oferent_IdOferenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementyDostawies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tytolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladkaColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ofertaOferentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDostawyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tytolColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladkaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaHurtowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOfertyOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentIdOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyDostawyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDostawyDataGridViewTextBoxColumn,
            this.oferentComboBoxColumn,
            this.EdytujDostawe,
            this.Oferent_IdOferenta,
            this.ElementyDostawies,
            this.pracownikComboBoxColumn});
            this.dataGridView1.DataSource = this.dostawaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(283, 356);
            this.zatwierdzButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(112, 35);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytolColumn,
            this.wydawnictwoColumn,
            this.okladkaColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.dostawaDataGridViewTextBoxColumn,
            this.egzemplarzColumn,
            this.idEgzemplarzaDataGridViewTextBoxColumn,
            this.idDostawyDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.elementyDostawyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(402, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(463, 395);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytolColumn2,
            this.wydawnictwoColumn2,
            this.okladkaColumn1,
            this.cenaHurtowaDataGridViewTextBoxColumn,
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn,
            this.egzemplarzColumn1,
            this.oferentDataGridViewTextBoxColumn,
            this.idOfertyOferentaDataGridViewTextBoxColumn,
            this.oferentIdOferentaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ofertaOferentaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(871, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(500, 395);
            this.dataGridView3.TabIndex = 3;
            // 
            // oferentComboBoxColumn
            // 
            this.oferentComboBoxColumn.DataSource = this.oferentBindingSource;
            this.oferentComboBoxColumn.DisplayMember = "NazwaFirmy";
            this.oferentComboBoxColumn.HeaderText = "Oferent";
            this.oferentComboBoxColumn.Name = "oferentComboBoxColumn";
            this.oferentComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oferentComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oferentComboBoxColumn.ValueMember = "IdOferenta";
            // 
            // EdytujDostawe
            // 
            this.EdytujDostawe.DataPropertyName = "HeaderText";
            this.EdytujDostawe.HeaderText = "Edytuj";
            this.EdytujDostawe.Name = "EdytujDostawe";
            this.EdytujDostawe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EdytujDostawe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Oferent_IdOferenta
            // 
            this.Oferent_IdOferenta.DataPropertyName = "Oferent_IdOferenta";
            this.Oferent_IdOferenta.HeaderText = "Oferent_IdOferenta";
            this.Oferent_IdOferenta.Name = "Oferent_IdOferenta";
            this.Oferent_IdOferenta.Visible = false;
            // 
            // ElementyDostawies
            // 
            this.ElementyDostawies.DataPropertyName = "ElementyDostawies";
            this.ElementyDostawies.HeaderText = "ElementyDostawies";
            this.ElementyDostawies.Name = "ElementyDostawies";
            this.ElementyDostawies.Visible = false;
            // 
            // pracownikComboBoxColumn
            // 
            this.pracownikComboBoxColumn.DataSource = this.pracownikBindingSource;
            this.pracownikComboBoxColumn.DisplayMember = "Nazwisko";
            this.pracownikComboBoxColumn.HeaderText = "Pracownik";
            this.pracownikComboBoxColumn.Name = "pracownikComboBoxColumn";
            this.pracownikComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pracownikComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pracownikComboBoxColumn.ValueMember = "IdPracownika";
            this.pracownikComboBoxColumn.Visible = false;
            // 
            // tytolColumn
            // 
            this.tytolColumn.HeaderText = "Tytol";
            this.tytolColumn.Name = "tytolColumn";
            // 
            // wydawnictwoColumn
            // 
            this.wydawnictwoColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn.Name = "wydawnictwoColumn";
            // 
            // okladkaColumn
            // 
            this.okladkaColumn.HeaderText = "Okladka";
            this.okladkaColumn.Name = "okladkaColumn";
            this.okladkaColumn.Width = 60;
            // 
            // ofertaOferentaBindingSource
            // 
            this.ofertaOferentaBindingSource.DataSource = typeof(BDProjekt.OfertaOferenta);
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // dostawaDataGridViewTextBoxColumn
            // 
            this.dostawaDataGridViewTextBoxColumn.DataPropertyName = "Dostawa";
            this.dostawaDataGridViewTextBoxColumn.HeaderText = "Dostawa";
            this.dostawaDataGridViewTextBoxColumn.Name = "dostawaDataGridViewTextBoxColumn";
            this.dostawaDataGridViewTextBoxColumn.Visible = false;
            // 
            // egzemplarzColumn
            // 
            this.egzemplarzColumn.DataPropertyName = "Egzemplarz";
            this.egzemplarzColumn.HeaderText = "Egzemplarz";
            this.egzemplarzColumn.Name = "egzemplarzColumn";
            this.egzemplarzColumn.Visible = false;
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDostawyDataGridViewTextBoxColumn1
            // 
            this.idDostawyDataGridViewTextBoxColumn1.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn1.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn1.Name = "idDostawyDataGridViewTextBoxColumn1";
            this.idDostawyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // elementyDostawyBindingSource
            // 
            this.elementyDostawyBindingSource.DataSource = typeof(BDProjekt.ElementyDostawy);
            // 
            // idDostawyDataGridViewTextBoxColumn
            // 
            this.idDostawyDataGridViewTextBoxColumn.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.Name = "idDostawyDataGridViewTextBoxColumn";
            this.idDostawyDataGridViewTextBoxColumn.Width = 50;
            // 
            // oferentBindingSource
            // 
            this.oferentBindingSource.DataSource = typeof(BDProjekt.Oferent);
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataSource = typeof(BDProjekt.Pracownik);
            // 
            // dostawaBindingSource
            // 
            this.dostawaBindingSource.DataSource = typeof(BDProjekt.Dostawa);
            // 
            // tytolColumn2
            // 
            this.tytolColumn2.HeaderText = "Tytol";
            this.tytolColumn2.Name = "tytolColumn2";
            this.tytolColumn2.ReadOnly = true;
            // 
            // wydawnictwoColumn2
            // 
            this.wydawnictwoColumn2.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn2.Name = "wydawnictwoColumn2";
            this.wydawnictwoColumn2.ReadOnly = true;
            // 
            // okladkaColumn1
            // 
            this.okladkaColumn1.HeaderText = "Okladka";
            this.okladkaColumn1.Name = "okladkaColumn1";
            this.okladkaColumn1.ReadOnly = true;
            this.okladkaColumn1.Width = 60;
            // 
            // cenaHurtowaDataGridViewTextBoxColumn
            // 
            this.cenaHurtowaDataGridViewTextBoxColumn.DataPropertyName = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.HeaderText = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.Name = "cenaHurtowaDataGridViewTextBoxColumn";
            this.cenaHurtowaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaHurtowaDataGridViewTextBoxColumn.Width = 50;
            // 
            // egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarz_IdEgzemplarza";
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "Egzemplarz_IdEgzemplarza";
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn.Name = "egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn";
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn.Visible = false;
            // 
            // egzemplarzColumn1
            // 
            this.egzemplarzColumn1.DataPropertyName = "Egzemplarz";
            this.egzemplarzColumn1.HeaderText = "Egzemplarz";
            this.egzemplarzColumn1.Name = "egzemplarzColumn1";
            this.egzemplarzColumn1.ReadOnly = true;
            this.egzemplarzColumn1.Visible = false;
            // 
            // oferentDataGridViewTextBoxColumn
            // 
            this.oferentDataGridViewTextBoxColumn.DataPropertyName = "Oferent";
            this.oferentDataGridViewTextBoxColumn.HeaderText = "Oferent";
            this.oferentDataGridViewTextBoxColumn.Name = "oferentDataGridViewTextBoxColumn";
            this.oferentDataGridViewTextBoxColumn.ReadOnly = true;
            this.oferentDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOfertyOferentaDataGridViewTextBoxColumn
            // 
            this.idOfertyOferentaDataGridViewTextBoxColumn.DataPropertyName = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.HeaderText = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.Name = "idOfertyOferentaDataGridViewTextBoxColumn";
            this.idOfertyOferentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOfertyOferentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // oferentIdOferentaDataGridViewTextBoxColumn
            // 
            this.oferentIdOferentaDataGridViewTextBoxColumn.DataPropertyName = "Oferent_IdOferenta";
            this.oferentIdOferentaDataGridViewTextBoxColumn.HeaderText = "Oferent_IdOferenta";
            this.oferentIdOferentaDataGridViewTextBoxColumn.Name = "oferentIdOferentaDataGridViewTextBoxColumn";
            this.oferentIdOferentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.oferentIdOferentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // DostawaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DostawaControl";
            this.Size = new System.Drawing.Size(1435, 507);
            this.Load += new System.EventHandler(this.DostawaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyDostawyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oferentBindingSource;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource elementyDostawyBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ofertaOferentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oferentComboBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EdytujDostawe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oferent_IdOferenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementyDostawies;
        private System.Windows.Forms.DataGridViewComboBoxColumn pracownikComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okladkaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytolColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladkaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaHurtowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertyOferentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentIdOferentaDataGridViewTextBoxColumn;
    }
}
