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
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typOkladkiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ksiazkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wydawnictwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
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
            this.ksiazkaDataGridViewTextBoxColumn,
            this.wydawnictwoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.egzemplarzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // egzemplarzBindingSource
            // 
            this.egzemplarzBindingSource.DataSource = typeof(BDProjekt.Egzemplarz);
            // 
            // wydawnictwoBindingSource
            // 
            this.wydawnictwoBindingSource.DataSource = typeof(BDProjekt.Wydawnictwo);
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
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
            this.typOkladkiDataGridViewCheckBoxColumn.DataSource = this.egzemplarzBindingSource;
            this.typOkladkiDataGridViewCheckBoxColumn.DisplayMember = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.HeaderText = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.Name = "typOkladkiDataGridViewCheckBoxColumn";
            this.typOkladkiDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ksiazkaDataGridViewTextBoxColumn
            // 
            this.ksiazkaDataGridViewTextBoxColumn.DataSource = this.ksiazkaBindingSource;
            this.ksiazkaDataGridViewTextBoxColumn.DisplayMember = "Tytul";
            this.ksiazkaDataGridViewTextBoxColumn.HeaderText = "Ksiazka";
            this.ksiazkaDataGridViewTextBoxColumn.Name = "ksiazkaDataGridViewTextBoxColumn";
            this.ksiazkaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ksiazkaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ksiazkaDataGridViewTextBoxColumn.ValueMember = "IdKsiazki";
            // 
            // wydawnictwoDataGridViewTextBoxColumn
            // 
            this.wydawnictwoDataGridViewTextBoxColumn.DataSource = this.wydawnictwoBindingSource;
            this.wydawnictwoDataGridViewTextBoxColumn.DisplayMember = "NazwaWydawnictwa";
            this.wydawnictwoDataGridViewTextBoxColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoDataGridViewTextBoxColumn.Name = "wydawnictwoDataGridViewTextBoxColumn";
            this.wydawnictwoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wydawnictwoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wydawnictwoDataGridViewTextBoxColumn.ValueMember = "IdWydawnictwa";
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(582, 265);
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
            this.Size = new System.Drawing.Size(658, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn ksiazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn wydawnictwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wydawnictwoBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
    }
}
