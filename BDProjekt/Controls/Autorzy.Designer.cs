namespace BDProjekt
{
    partial class Autorzy
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchNazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.czyscNazwiskoButton = new System.Windows.Forms.Button();
            this.imieLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.szukajButton = new System.Windows.Forms.Button();
            this.idAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataUrodzeniaCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutoraDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(551, 301);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 35);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(771, 22);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchNazwiskoTextBox
            // 
            this.searchNazwiskoTextBox.Location = new System.Drawing.Point(771, 62);
            this.searchNazwiskoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchNazwiskoTextBox.Name = "searchNazwiskoTextBox";
            this.searchNazwiskoTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchNazwiskoTextBox.TabIndex = 5;
            this.searchNazwiskoTextBox.TextChanged += new System.EventHandler(this.searchNazwiskoTextBox_TextChanged);
            // 
            // czyscNazwiskoButton
            // 
            this.czyscNazwiskoButton.Location = new System.Drawing.Point(902, 216);
            this.czyscNazwiskoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.czyscNazwiskoButton.Name = "czyscNazwiskoButton";
            this.czyscNazwiskoButton.Size = new System.Drawing.Size(112, 35);
            this.czyscNazwiskoButton.TabIndex = 8;
            this.czyscNazwiskoButton.Text = "Czyść";
            this.czyscNazwiskoButton.UseVisualStyleBackColor = true;
            this.czyscNazwiskoButton.Click += new System.EventHandler(this.czyscNazwiskoButton_Click);
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(723, 29);
            this.imieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(39, 20);
            this.imieLabel.TabIndex = 9;
            this.imieLabel.Text = "Imie";
            this.imieLabel.Click += new System.EventHandler(this.imieLabel_Click);
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(683, 66);
            this.nazwiskoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.nazwiskoLabel.TabIndex = 10;
            this.nazwiskoLabel.Text = "Nazwisko";
            this.nazwiskoLabel.Click += new System.EventHandler(this.nazwiskoLabel_Click);
            // 
            // szukajButton
            // 
            this.szukajButton.Location = new System.Drawing.Point(750, 216);
            this.szukajButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(112, 35);
            this.szukajButton.TabIndex = 11;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = true;
            this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
            // 
            // idAutoraDataGridViewTextBoxColumn
            // 
            this.idAutoraDataGridViewTextBoxColumn.DataPropertyName = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.HeaderText = "IdAutora";
            this.idAutoraDataGridViewTextBoxColumn.Name = "idAutoraDataGridViewTextBoxColumn";
            this.idAutoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia (dd.mm.rrrr)";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BDProjekt.Autor);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(771, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "do";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(771, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // dataUrodzeniaCheckBox
            // 
            this.dataUrodzeniaCheckBox.AutoSize = true;
            this.dataUrodzeniaCheckBox.Location = new System.Drawing.Point(750, 98);
            this.dataUrodzeniaCheckBox.Name = "dataUrodzeniaCheckBox";
            this.dataUrodzeniaCheckBox.Size = new System.Drawing.Size(151, 24);
            this.dataUrodzeniaCheckBox.TabIndex = 17;
            this.dataUrodzeniaCheckBox.Text = "Data Urodzenia:";
            this.dataUrodzeniaCheckBox.UseVisualStyleBackColor = true;
            // 
            // Autorzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataUrodzeniaCheckBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.szukajButton);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieLabel);
            this.Controls.Add(this.czyscNazwiskoButton);
            this.Controls.Add(this.searchNazwiskoTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Autorzy";
            this.Size = new System.Drawing.Size(1095, 386);
            this.Load += new System.EventHandler(this.Autorzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.TextBox searchNazwiskoTextBox;
        private System.Windows.Forms.Button czyscNazwiskoButton;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox dataUrodzeniaCheckBox;

    }
}
