namespace BDProjekt.Controls
{
    partial class OferentOfertyControl
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.TytolKsiazki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaWydawnictwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ofertaOferentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typOkladkiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdEgzemplarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ksiazka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wydawnictwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ksiazka2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wydawnictwo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypOkladki = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cenaHurtowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOfertyOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egzemplarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).BeginInit();
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
            this.TytolKsiazki,
            this.NazwaWydawnictwa,
            this.typOkladkiDataGridViewCheckBoxColumn,
            this.Dodaj,
            this.IdEgzemplarza,
            this.Ksiazka,
            this.Wydawnictwo});
            this.dataGridView1.DataSource = this.egzemplarzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(571, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ksiazka";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ksiazka";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "daj nazwy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ksiazka2,
            this.Wydawnictwo2,
            this.TypOkladki,
            this.cenaHurtowaDataGridViewTextBoxColumn,
            this.idOfertyOferentaDataGridViewTextBoxColumn,
            this.Egzemplarz});
            this.dataGridView2.DataSource = this.ofertaOferentaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(567, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(649, 215);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Egzemplarz";
            this.dataGridViewTextBoxColumn3.HeaderText = "Egzemplarz";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TytolKsiazki
            // 
            this.TytolKsiazki.DataPropertyName = "int";
            this.TytolKsiazki.HeaderText = "Ksiazka";
            this.TytolKsiazki.Name = "TytolKsiazki";
            this.TytolKsiazki.ReadOnly = true;
            // 
            // NazwaWydawnictwa
            // 
            this.NazwaWydawnictwa.HeaderText = "Wydawnictwo";
            this.NazwaWydawnictwa.Name = "NazwaWydawnictwa";
            this.NazwaWydawnictwa.ReadOnly = true;
            // 
            // Dodaj
            // 
            this.Dodaj.DataPropertyName = "\"Dodaj\"";
            this.Dodaj.HeaderText = "Dodaj";
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.ReadOnly = true;
            // 
            // ofertaOferentaBindingSource
            // 
            this.ofertaOferentaBindingSource.DataSource = typeof(BDProjekt.OfertaOferenta);
            // 
            // typOkladkiDataGridViewCheckBoxColumn
            // 
            this.typOkladkiDataGridViewCheckBoxColumn.DataPropertyName = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.HeaderText = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.Name = "typOkladkiDataGridViewCheckBoxColumn";
            this.typOkladkiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typOkladkiDataGridViewCheckBoxColumn.Width = 30;
            // 
            // IdEgzemplarza
            // 
            this.IdEgzemplarza.DataPropertyName = "IdEgzemplarza";
            this.IdEgzemplarza.HeaderText = "IdEgzemplarza";
            this.IdEgzemplarza.Name = "IdEgzemplarza";
            this.IdEgzemplarza.ReadOnly = true;
            this.IdEgzemplarza.Visible = false;
            // 
            // Ksiazka
            // 
            this.Ksiazka.DataPropertyName = "Ksiazka";
            this.Ksiazka.HeaderText = "Ksiazka";
            this.Ksiazka.Name = "Ksiazka";
            this.Ksiazka.ReadOnly = true;
            this.Ksiazka.Visible = false;
            // 
            // Wydawnictwo
            // 
            this.Wydawnictwo.DataPropertyName = "Wydawnictwo";
            this.Wydawnictwo.HeaderText = "Wydawnictwo";
            this.Wydawnictwo.Name = "Wydawnictwo";
            this.Wydawnictwo.ReadOnly = true;
            this.Wydawnictwo.Visible = false;
            // 
            // egzemplarzBindingSource
            // 
            this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
            // 
            // Ksiazka2
            // 
            this.Ksiazka2.HeaderText = "Ksiazka";
            this.Ksiazka2.Name = "Ksiazka2";
            this.Ksiazka2.ReadOnly = true;
            // 
            // Wydawnictwo2
            // 
            this.Wydawnictwo2.HeaderText = "Wydawnictwo";
            this.Wydawnictwo2.Name = "Wydawnictwo2";
            this.Wydawnictwo2.ReadOnly = true;
            // 
            // TypOkladki
            // 
            this.TypOkladki.HeaderText = "TypOkladki";
            this.TypOkladki.Name = "TypOkladki";
            this.TypOkladki.ReadOnly = true;
            this.TypOkladki.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypOkladki.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cenaHurtowaDataGridViewTextBoxColumn
            // 
            this.cenaHurtowaDataGridViewTextBoxColumn.DataPropertyName = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.HeaderText = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.Name = "cenaHurtowaDataGridViewTextBoxColumn";
            // 
            // idOfertyOferentaDataGridViewTextBoxColumn
            // 
            this.idOfertyOferentaDataGridViewTextBoxColumn.DataPropertyName = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.HeaderText = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.Name = "idOfertyOferentaDataGridViewTextBoxColumn";
            this.idOfertyOferentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Egzemplarz
            // 
            this.Egzemplarz.DataPropertyName = "Egzemplarz";
            this.Egzemplarz.HeaderText = "Egzemplarz";
            this.Egzemplarz.Name = "Egzemplarz";
            this.Egzemplarz.Visible = false;
            // 
            // OferentOfertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OferentOfertyControl";
            this.Size = new System.Drawing.Size(2415, 518);
            this.Load += new System.EventHandler(this.OferentOfertyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksiazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ofertaOferentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TytolKsiazki;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaWydawnictwa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEgzemplarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ksiazka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wydawnictwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ksiazka2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wydawnictwo2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TypOkladki;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaHurtowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertyOferentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egzemplarz;
    }
}
