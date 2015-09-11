namespace BDProjekt.Controls
{
    partial class EgzemplarzControl
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
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typOkladkiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ksiazkaComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wydawnictwoComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEgzemplarzaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.ilosccDataGridViewTextBoxColumn,
            this.typOkladkiDataGridViewCheckBoxColumn,
            this.ksiazkaComboBoxColumn,
            this.wydawnictwoComboBoxColumn});
            this.dataGridView1.DataSource = this.egzemplarzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // ilosccDataGridViewTextBoxColumn
            // 
            this.ilosccDataGridViewTextBoxColumn.DataPropertyName = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.HeaderText = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.Name = "ilosccDataGridViewTextBoxColumn";
            // 
            // typOkladkiDataGridViewCheckBoxColumn
            // 
            this.typOkladkiDataGridViewCheckBoxColumn.DataPropertyName = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.HeaderText = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.Name = "typOkladkiDataGridViewCheckBoxColumn";
            // 
            // ksiazkaComboBoxColumn
            // 
            this.ksiazkaComboBoxColumn.DataSource = this.ksiazkaBindingSource;
            this.ksiazkaComboBoxColumn.DisplayMember = "Tytul";
            this.ksiazkaComboBoxColumn.HeaderText = "Ksiazka";
            this.ksiazkaComboBoxColumn.Name = "ksiazkaComboBoxColumn";
            this.ksiazkaComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ksiazkaComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ksiazkaComboBoxColumn.ValueMember = "IdKsiazki";
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
            // 
            // wydawnictwoComboBoxColumn
            // 
            this.wydawnictwoComboBoxColumn.DataSource = this.wydawnictwoBindingSource;
            this.wydawnictwoComboBoxColumn.DisplayMember = "NazwaWydawnictwa";
            this.wydawnictwoComboBoxColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoComboBoxColumn.Name = "wydawnictwoComboBoxColumn";
            this.wydawnictwoComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wydawnictwoComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wydawnictwoComboBoxColumn.ValueMember = "IdWydawnictwa";
            // 
            // wydawnictwoBindingSource
            // 
            this.wydawnictwoBindingSource.DataSource = typeof(BDProjekt.Wydawnictwo);
            // 
            // egzemplarzBindingSource
            // 
            this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(573, 170);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // EgzemplarzControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EgzemplarzControl";
            this.Size = new System.Drawing.Size(652, 204);
            this.Load += new System.EventHandler(this.EgzemplarzControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.BindingSource wydawnictwoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ksiazkaComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wydawnictwoComboBoxColumn;
    }
}
