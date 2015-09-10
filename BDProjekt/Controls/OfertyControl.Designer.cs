namespace BDProjekt.Controls
{
    partial class OfertyControl
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
            this.ofertaOferentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.oferentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOfertyOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaHurtowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egzemplarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oferentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfertyOferentaDataGridViewTextBoxColumn,
            this.cenaHurtowaDataGridViewTextBoxColumn,
            this.egzemplarzDataGridViewTextBoxColumn,
            this.oferentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ofertaOferentaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ofertaOferentaBindingSource
            // 
            this.ofertaOferentaBindingSource.DataSource = typeof(BDProjekt.OfertaOferenta);
            // 
            // egzemplarzBindingSource
            // 
            this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(391, 230);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // oferentBindingSource
            // 
            this.oferentBindingSource.DataSource = typeof(BDProjekt.Oferent);
            // 
            // idOfertyOferentaDataGridViewTextBoxColumn
            // 
            this.idOfertyOferentaDataGridViewTextBoxColumn.DataPropertyName = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.HeaderText = "IdOfertyOferenta";
            this.idOfertyOferentaDataGridViewTextBoxColumn.Name = "idOfertyOferentaDataGridViewTextBoxColumn";
            // 
            // cenaHurtowaDataGridViewTextBoxColumn
            // 
            this.cenaHurtowaDataGridViewTextBoxColumn.DataPropertyName = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.HeaderText = "CenaHurtowa";
            this.cenaHurtowaDataGridViewTextBoxColumn.Name = "cenaHurtowaDataGridViewTextBoxColumn";
            // 
            // egzemplarzDataGridViewTextBoxColumn
            // 
            this.egzemplarzDataGridViewTextBoxColumn.DataSource = this.egzemplarzBindingSource;
            this.egzemplarzDataGridViewTextBoxColumn.HeaderText = "Egzemplarz";
            this.egzemplarzDataGridViewTextBoxColumn.Name = "egzemplarzDataGridViewTextBoxColumn";
            this.egzemplarzDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.egzemplarzDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.egzemplarzDataGridViewTextBoxColumn.ValueMember = "IdEgzemplarza";
            // 
            // oferentDataGridViewTextBoxColumn
            // 
            this.oferentDataGridViewTextBoxColumn.DataSource = this.oferentBindingSource;
            this.oferentDataGridViewTextBoxColumn.DisplayMember = "NazwaFirmy";
            this.oferentDataGridViewTextBoxColumn.HeaderText = "Oferent";
            this.oferentDataGridViewTextBoxColumn.Name = "oferentDataGridViewTextBoxColumn";
            this.oferentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oferentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oferentDataGridViewTextBoxColumn.ValueMember = "IdOferenta";
            // 
            // OfertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OfertyControl";
            this.Size = new System.Drawing.Size(470, 313);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaOferentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.BindingSource ofertaOferentaBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertyOferentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaHurtowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn egzemplarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oferentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oferentBindingSource;
    }
}
