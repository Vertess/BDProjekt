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
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.searchCenaTextBox = new System.Windows.Forms.TextBox();
            this.searchIloscTextBox = new System.Windows.Forms.TextBox();
            this.resetTypButton = new System.Windows.Forms.Button();
            this.szukajButton = new System.Windows.Forms.Button();
            this.cenaCheckBox = new System.Windows.Forms.CheckBox();
            this.iloscCheckBox = new System.Windows.Forms.CheckBox();
            this.ksiazkaComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wydawnictwoComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typOkladkiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ilosccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ksiazkaComboBoxColumn,
            this.wydawnictwoComboBoxColumn,
            this.typOkladkiDataGridViewCheckBoxColumn,
            this.ilosccDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.idEgzemplarzaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.egzemplarzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += Funkcje.Instance.dataGridView1_DataError;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(BDProjekt.Ksiazka);
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
            this.zatwierdzButton.Location = new System.Drawing.Point(861, 240);
            this.zatwierdzButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(112, 35);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // searchCenaTextBox
            // 
            this.searchCenaTextBox.Location = new System.Drawing.Point(112, 235);
            this.searchCenaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCenaTextBox.Name = "searchCenaTextBox";
            this.searchCenaTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchCenaTextBox.TabIndex = 5;
            // 
            // searchIloscTextBox
            // 
            this.searchIloscTextBox.Location = new System.Drawing.Point(112, 271);
            this.searchIloscTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchIloscTextBox.Name = "searchIloscTextBox";
            this.searchIloscTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchIloscTextBox.TabIndex = 6;
            // 
            // resetTypButton
            // 
            this.resetTypButton.Location = new System.Drawing.Point(422, 268);
            this.resetTypButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetTypButton.Name = "resetTypButton";
            this.resetTypButton.Size = new System.Drawing.Size(112, 35);
            this.resetTypButton.TabIndex = 13;
            this.resetTypButton.Text = "Czyść";
            this.resetTypButton.UseVisualStyleBackColor = true;
            this.resetTypButton.Click += new System.EventHandler(this.resetTypButton_Click);
            // 
            // szukajButton
            // 
            this.szukajButton.Location = new System.Drawing.Point(300, 268);
            this.szukajButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(112, 35);
            this.szukajButton.TabIndex = 14;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = true;
            this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
            // 
            // cenaCheckBox
            // 
            this.cenaCheckBox.AutoSize = true;
            this.cenaCheckBox.Location = new System.Drawing.Point(20, 237);
            this.cenaCheckBox.Name = "cenaCheckBox";
            this.cenaCheckBox.Size = new System.Drawing.Size(73, 24);
            this.cenaCheckBox.TabIndex = 15;
            this.cenaCheckBox.Text = "Cena";
            this.cenaCheckBox.UseVisualStyleBackColor = true;
            // 
            // iloscCheckBox
            // 
            this.iloscCheckBox.AutoSize = true;
            this.iloscCheckBox.Location = new System.Drawing.Point(20, 271);
            this.iloscCheckBox.Name = "iloscCheckBox";
            this.iloscCheckBox.Size = new System.Drawing.Size(68, 24);
            this.iloscCheckBox.TabIndex = 16;
            this.iloscCheckBox.Text = "Ilosc";
            this.iloscCheckBox.UseVisualStyleBackColor = true;
            // 
            // ksiazkaComboBoxColumn
            // 
            this.ksiazkaComboBoxColumn.DataPropertyName = "Ksiazka_IdKsiazki";
            this.ksiazkaComboBoxColumn.DataSource = this.ksiazkaBindingSource;
            this.ksiazkaComboBoxColumn.DisplayMember = "Tytul";
            this.ksiazkaComboBoxColumn.HeaderText = "Ksiazka";
            this.ksiazkaComboBoxColumn.Name = "ksiazkaComboBoxColumn";
            this.ksiazkaComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ksiazkaComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ksiazkaComboBoxColumn.ValueMember = "IdKsiazki";
            // 
            // wydawnictwoComboBoxColumn
            // 
            this.wydawnictwoComboBoxColumn.DataPropertyName = "Wydawnictwo_IdWydawnictwa";
            this.wydawnictwoComboBoxColumn.DataSource = this.wydawnictwoBindingSource;
            this.wydawnictwoComboBoxColumn.DisplayMember = "NazwaWydawnictwa";
            this.wydawnictwoComboBoxColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoComboBoxColumn.Name = "wydawnictwoComboBoxColumn";
            this.wydawnictwoComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wydawnictwoComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wydawnictwoComboBoxColumn.ValueMember = "IdWydawnictwa";
            // 
            // typOkladkiDataGridViewCheckBoxColumn
            // 
            this.typOkladkiDataGridViewCheckBoxColumn.DataPropertyName = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.HeaderText = "TypOkladki";
            this.typOkladkiDataGridViewCheckBoxColumn.Name = "typOkladkiDataGridViewCheckBoxColumn";
            // 
            // ilosccDataGridViewTextBoxColumn
            // 
            this.ilosccDataGridViewTextBoxColumn.DataPropertyName = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.HeaderText = "Iloscc";
            this.ilosccDataGridViewTextBoxColumn.Name = "ilosccDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // idEgzemplarzaDataGridViewTextBoxColumn
            // 
            this.idEgzemplarzaDataGridViewTextBoxColumn.DataPropertyName = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.HeaderText = "IdEgzemplarza";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Name = "idEgzemplarzaDataGridViewTextBoxColumn";
            this.idEgzemplarzaDataGridViewTextBoxColumn.Visible = false;
            // 
            // EgzemplarzControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iloscCheckBox);
            this.Controls.Add(this.cenaCheckBox);
            this.Controls.Add(this.szukajButton);
            this.Controls.Add(this.resetTypButton);
            this.Controls.Add(this.searchIloscTextBox);
            this.Controls.Add(this.searchCenaTextBox);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EgzemplarzControl";
            this.Size = new System.Drawing.Size(978, 405);
            this.Load += new System.EventHandler(this.EgzemplarzControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydawnictwoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzemplarzBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private System.Windows.Forms.BindingSource egzemplarzBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.BindingSource wydawnictwoBindingSource;
        private System.Windows.Forms.TextBox searchCenaTextBox;
        private System.Windows.Forms.TextBox searchIloscTextBox;
        private System.Windows.Forms.Button resetTypButton;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.CheckBox cenaCheckBox;
        private System.Windows.Forms.CheckBox iloscCheckBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn ksiazkaComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wydawnictwoComboBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
    }
}
