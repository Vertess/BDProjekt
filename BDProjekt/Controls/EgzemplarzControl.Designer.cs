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
            this.ksiazkaComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wydawnictwoComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.idEgzemplarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typOkladkiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wydawnictwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egzemplarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenaLabel = new System.Windows.Forms.Label();
            this.iloscLabel = new System.Windows.Forms.Label();
            this.typLabel = new System.Windows.Forms.Label();
            this.searchCenaTextBox = new System.Windows.Forms.TextBox();
            this.searchIloscTextBox = new System.Windows.Forms.TextBox();
            this.searchTypTextBox = new System.Windows.Forms.TextBox();
            this.searchCenaButton = new System.Windows.Forms.Button();
            this.resetCenaButton = new System.Windows.Forms.Button();
            this.searchIloscButton = new System.Windows.Forms.Button();
            this.resetIloscButton = new System.Windows.Forms.Button();
            this.searchTypButton = new System.Windows.Forms.Button();
            this.resetTypButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
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
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(574, 156);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
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
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(3, 156);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(32, 13);
            this.cenaLabel.TabIndex = 2;
            this.cenaLabel.Text = "Cena";
            // 
            // iloscLabel
            // 
            this.iloscLabel.AutoSize = true;
            this.iloscLabel.Location = new System.Drawing.Point(3, 180);
            this.iloscLabel.Name = "iloscLabel";
            this.iloscLabel.Size = new System.Drawing.Size(29, 13);
            this.iloscLabel.TabIndex = 3;
            this.iloscLabel.Text = "Ilość";
            // 
            // typLabel
            // 
            this.typLabel.AutoSize = true;
            this.typLabel.Location = new System.Drawing.Point(1, 206);
            this.typLabel.Name = "typLabel";
            this.typLabel.Size = new System.Drawing.Size(66, 13);
            this.typLabel.TabIndex = 4;
            this.typLabel.Text = "Typ Okładki";
            // 
            // searchCenaTextBox
            // 
            this.searchCenaTextBox.Location = new System.Drawing.Point(44, 153);
            this.searchCenaTextBox.Name = "searchCenaTextBox";
            this.searchCenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchCenaTextBox.TabIndex = 5;
            this.searchCenaTextBox.TextChanged += new System.EventHandler(this.searchCenaTextBox_TextChanged);
            // 
            // searchIloscTextBox
            // 
            this.searchIloscTextBox.Location = new System.Drawing.Point(44, 176);
            this.searchIloscTextBox.Name = "searchIloscTextBox";
            this.searchIloscTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchIloscTextBox.TabIndex = 6;
            this.searchIloscTextBox.TextChanged += new System.EventHandler(this.searchIloscTextBox_TextChanged);
            // 
            // searchTypTextBox
            // 
            this.searchTypTextBox.Location = new System.Drawing.Point(75, 203);
            this.searchTypTextBox.Name = "searchTypTextBox";
            this.searchTypTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTypTextBox.TabIndex = 7;
            this.searchTypTextBox.TextChanged += new System.EventHandler(this.searchTypTextBox_TextChanged);
            // 
            // searchCenaButton
            // 
            this.searchCenaButton.Location = new System.Drawing.Point(150, 151);
            this.searchCenaButton.Name = "searchCenaButton";
            this.searchCenaButton.Size = new System.Drawing.Size(75, 23);
            this.searchCenaButton.TabIndex = 8;
            this.searchCenaButton.Text = "Szukaj";
            this.searchCenaButton.UseVisualStyleBackColor = true;
            // 
            // resetCenaButton
            // 
            this.resetCenaButton.Location = new System.Drawing.Point(231, 151);
            this.resetCenaButton.Name = "resetCenaButton";
            this.resetCenaButton.Size = new System.Drawing.Size(75, 23);
            this.resetCenaButton.TabIndex = 9;
            this.resetCenaButton.Text = "Czyść";
            this.resetCenaButton.UseVisualStyleBackColor = true;
            this.resetCenaButton.Click += new System.EventHandler(this.resetCenaButton_Click);
            // 
            // searchIloscButton
            // 
            this.searchIloscButton.Location = new System.Drawing.Point(150, 174);
            this.searchIloscButton.Name = "searchIloscButton";
            this.searchIloscButton.Size = new System.Drawing.Size(75, 23);
            this.searchIloscButton.TabIndex = 10;
            this.searchIloscButton.Text = "Szukaj";
            this.searchIloscButton.UseVisualStyleBackColor = true;
            // 
            // resetIloscButton
            // 
            this.resetIloscButton.Location = new System.Drawing.Point(231, 175);
            this.resetIloscButton.Name = "resetIloscButton";
            this.resetIloscButton.Size = new System.Drawing.Size(75, 23);
            this.resetIloscButton.TabIndex = 11;
            this.resetIloscButton.Text = "Czyść";
            this.resetIloscButton.UseVisualStyleBackColor = true;
            this.resetIloscButton.Click += new System.EventHandler(this.resetIloscButton_Click);
            // 
            // searchTypButton
            // 
            this.searchTypButton.Location = new System.Drawing.Point(181, 203);
            this.searchTypButton.Name = "searchTypButton";
            this.searchTypButton.Size = new System.Drawing.Size(75, 23);
            this.searchTypButton.TabIndex = 12;
            this.searchTypButton.Text = "Szukaj";
            this.searchTypButton.UseVisualStyleBackColor = true;
            // 
            // resetTypButton
            // 
            this.resetTypButton.Location = new System.Drawing.Point(262, 203);
            this.resetTypButton.Name = "resetTypButton";
            this.resetTypButton.Size = new System.Drawing.Size(75, 23);
            this.resetTypButton.TabIndex = 13;
            this.resetTypButton.Text = "Czyść";
            this.resetTypButton.UseVisualStyleBackColor = true;
            this.resetTypButton.Click += new System.EventHandler(this.resetTypButton_Click);
            // 
            // EgzemplarzControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetTypButton);
            this.Controls.Add(this.searchTypButton);
            this.Controls.Add(this.resetIloscButton);
            this.Controls.Add(this.searchIloscButton);
            this.Controls.Add(this.resetCenaButton);
            this.Controls.Add(this.searchCenaButton);
            this.Controls.Add(this.searchTypTextBox);
            this.Controls.Add(this.searchIloscTextBox);
            this.Controls.Add(this.searchCenaTextBox);
            this.Controls.Add(this.typLabel);
            this.Controls.Add(this.iloscLabel);
            this.Controls.Add(this.cenaLabel);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EgzemplarzControl";
            this.Size = new System.Drawing.Size(652, 263);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgzemplarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typOkladkiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ksiazkaComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wydawnictwoComboBoxColumn;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label iloscLabel;
        private System.Windows.Forms.Label typLabel;
        private System.Windows.Forms.TextBox searchCenaTextBox;
        private System.Windows.Forms.TextBox searchIloscTextBox;
        private System.Windows.Forms.TextBox searchTypTextBox;
        private System.Windows.Forms.Button searchCenaButton;
        private System.Windows.Forms.Button resetCenaButton;
        private System.Windows.Forms.Button searchIloscButton;
        private System.Windows.Forms.Button resetIloscButton;
        private System.Windows.Forms.Button searchTypButton;
        private System.Windows.Forms.Button resetTypButton;
    }
}
