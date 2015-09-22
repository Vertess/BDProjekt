namespace BDProjekt.Controls
{
    partial class AdminKlientControl
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
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szukajButton = new System.Windows.Forms.Button();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.czyscNazwiskoButton = new System.Windows.Forms.Button();
            this.searchNazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.searchLoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.zamowieniesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1083, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(BDProjekt.Klient);
            // 
            // szukajButton
            // 
            this.szukajButton.Location = new System.Drawing.Point(326, 352);
            this.szukajButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(112, 35);
            this.szukajButton.TabIndex = 18;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = true;
            this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(57, 400);
            this.nazwiskoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(76, 20);
            this.nazwiskoLabel.TabIndex = 17;
            this.nazwiskoLabel.Text = "Nazwisko";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(98, 363);
            this.imieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(39, 20);
            this.imieLabel.TabIndex = 16;
            this.imieLabel.Text = "Imie";
            // 
            // czyscNazwiskoButton
            // 
            this.czyscNazwiskoButton.Location = new System.Drawing.Point(447, 352);
            this.czyscNazwiskoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.czyscNazwiskoButton.Name = "czyscNazwiskoButton";
            this.czyscNazwiskoButton.Size = new System.Drawing.Size(112, 35);
            this.czyscNazwiskoButton.TabIndex = 15;
            this.czyscNazwiskoButton.Text = "Czyść";
            this.czyscNazwiskoButton.UseVisualStyleBackColor = true;
            this.czyscNazwiskoButton.Click += new System.EventHandler(this.czyscNazwiskoButton_Click);
            // 
            // searchNazwiskoTextBox
            // 
            this.searchNazwiskoTextBox.Location = new System.Drawing.Point(146, 395);
            this.searchNazwiskoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchNazwiskoTextBox.Name = "searchNazwiskoTextBox";
            this.searchNazwiskoTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchNazwiskoTextBox.TabIndex = 14;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(146, 355);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchTextBox.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(618, 392);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 35);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // searchLoginTextBox
            // 
            this.searchLoginTextBox.Location = new System.Drawing.Point(146, 435);
            this.searchLoginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchLoginTextBox.Name = "searchLoginTextBox";
            this.searchLoginTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchLoginTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Login";
            // 
            // searchEmailTextBox
            // 
            this.searchEmailTextBox.Location = new System.Drawing.Point(146, 475);
            this.searchEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchEmailTextBox.Name = "searchEmailTextBox";
            this.searchEmailTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchEmailTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // idKlientaDataGridViewTextBoxColumn
            // 
            this.idKlientaDataGridViewTextBoxColumn.DataPropertyName = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn.HeaderText = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn.Name = "idKlientaDataGridViewTextBoxColumn";
            this.idKlientaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "Haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // zamowieniesDataGridViewTextBoxColumn
            // 
            this.zamowieniesDataGridViewTextBoxColumn.DataPropertyName = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.HeaderText = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.Name = "zamowieniesDataGridViewTextBoxColumn";
            this.zamowieniesDataGridViewTextBoxColumn.Visible = false;
            // 
            // AdminKlientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchLoginTextBox);
            this.Controls.Add(this.szukajButton);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieLabel);
            this.Controls.Add(this.czyscNazwiskoButton);
            this.Controls.Add(this.searchNazwiskoTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminKlientControl";
            this.Size = new System.Drawing.Size(1160, 648);
            this.Load += new System.EventHandler(this.AdminKlientControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Button czyscNazwiskoButton;
        private System.Windows.Forms.TextBox searchNazwiskoTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox searchLoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchEmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowieniesDataGridViewTextBoxColumn;
    }
}
