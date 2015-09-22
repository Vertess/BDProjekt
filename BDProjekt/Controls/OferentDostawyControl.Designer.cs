namespace BDProjekt.Controls
{
    partial class OferentDostawyControl
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
            this.tytulKsiazkiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaWydawnictwaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladkaColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDostawyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Szczegoly = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reklamacja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyDostawyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Szczegoly,
            this.Status,
            this.Reklamacja,
            this.idDostawyDataGridViewTextBoxColumn,
            this.elementyDostawiesDataGridViewTextBoxColumn,
            this.oferentDataGridViewTextBoxColumn,
            this.pracownikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dostawaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(368, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulKsiazkiColumn,
            this.nazwaWydawnictwaColumn,
            this.okladkaColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.egzemplarzDataGridViewTextBoxColumn,
            this.dostawaDataGridViewTextBoxColumn,
            this.idEgzemplarzaDataGridViewTextBoxColumn,
            this.idDostawyDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.elementyDostawyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(374, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(793, 416);
            this.dataGridView2.TabIndex = 7;
            // 
            // tytulKsiazkiColumn
            // 
            this.tytulKsiazkiColumn.HeaderText = "Tytuł Ksiazki";
            this.tytulKsiazkiColumn.Name = "tytulKsiazkiColumn";
            this.tytulKsiazkiColumn.ReadOnly = true;
            this.tytulKsiazkiColumn.Width = 150;
            // 
            // nazwaWydawnictwaColumn
            // 
            this.nazwaWydawnictwaColumn.HeaderText = "Wydawnictwo";
            this.nazwaWydawnictwaColumn.Name = "nazwaWydawnictwaColumn";
            this.nazwaWydawnictwaColumn.ReadOnly = true;
            this.nazwaWydawnictwaColumn.Width = 150;
            // 
            // okladkaColumn
            // 
            this.okladkaColumn.HeaderText = "Okladka";
            this.okladkaColumn.Name = "okladkaColumn";
            this.okladkaColumn.ReadOnly = true;
            this.okladkaColumn.Width = 70;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egzemplarzDataGridViewTextBoxColumn
            // 
            this.egzemplarzDataGridViewTextBoxColumn.DataPropertyName = "Egzemplarz";
            this.egzemplarzDataGridViewTextBoxColumn.HeaderText = "Egzemplarz";
            this.egzemplarzDataGridViewTextBoxColumn.Name = "egzemplarzDataGridViewTextBoxColumn";
            this.egzemplarzDataGridViewTextBoxColumn.ReadOnly = true;
            this.egzemplarzDataGridViewTextBoxColumn.Visible = false;
            // 
            // dostawaDataGridViewTextBoxColumn
            // 
            this.dostawaDataGridViewTextBoxColumn.DataPropertyName = "Dostawa";
            this.dostawaDataGridViewTextBoxColumn.HeaderText = "Dostawa";
            this.dostawaDataGridViewTextBoxColumn.Name = "dostawaDataGridViewTextBoxColumn";
            this.dostawaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostawaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
            this.idEgzemplarzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEgzemplarzaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDostawyDataGridViewTextBoxColumn1
            // 
            this.idDostawyDataGridViewTextBoxColumn1.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn1.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn1.Name = "idDostawyDataGridViewTextBoxColumn1";
            this.idDostawyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDostawyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // elementyDostawyBindingSource
            // 
            this.elementyDostawyBindingSource.DataSource = typeof(BDProjekt.ElementyDostawy);
            // 
            // dostawaBindingSource
            // 
            this.dostawaBindingSource.DataSource = typeof(BDProjekt.Dostawa);
            // 
            // Szczegoly
            // 
            this.Szczegoly.DataPropertyName = "IdDostawy";
            this.Szczegoly.HeaderText = "Dostawa";
            this.Szczegoly.Name = "Szczegoly";
            this.Szczegoly.ReadOnly = true;
            this.Szczegoly.Width = 70;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // Reklamacja
            // 
            this.Reklamacja.HeaderText = "reklamacja";
            this.Reklamacja.Name = "Reklamacja";
            this.Reklamacja.ReadOnly = true;
            // 
            // idDostawyDataGridViewTextBoxColumn
            // 
            this.idDostawyDataGridViewTextBoxColumn.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.Name = "idDostawyDataGridViewTextBoxColumn";
            this.idDostawyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDostawyDataGridViewTextBoxColumn.Visible = false;
            // 
            // elementyDostawiesDataGridViewTextBoxColumn
            // 
            this.elementyDostawiesDataGridViewTextBoxColumn.DataPropertyName = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.HeaderText = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.Name = "elementyDostawiesDataGridViewTextBoxColumn";
            this.elementyDostawiesDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementyDostawiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // oferentDataGridViewTextBoxColumn
            // 
            this.oferentDataGridViewTextBoxColumn.DataPropertyName = "Oferent";
            this.oferentDataGridViewTextBoxColumn.HeaderText = "Oferent";
            this.oferentDataGridViewTextBoxColumn.Name = "oferentDataGridViewTextBoxColumn";
            this.oferentDataGridViewTextBoxColumn.ReadOnly = true;
            this.oferentDataGridViewTextBoxColumn.Visible = false;
            // 
            // pracownikDataGridViewTextBoxColumn
            // 
            this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
            this.pracownikDataGridViewTextBoxColumn.ReadOnly = true;
            this.pracownikDataGridViewTextBoxColumn.Visible = false;
            // 
            // OferentDostawyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OferentDostawyControl";
            this.Size = new System.Drawing.Size(1257, 514);
            this.Load += new System.EventHandler(this.OferentDostawyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyDostawyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource elementyDostawyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulKsiazkiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaWydawnictwaColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okladkaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egzemplarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Szczegoly;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Reklamacja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyDostawiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
    }
}
