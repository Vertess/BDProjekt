namespace BDProjekt
{
    partial class AdminPracownikControl
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
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.searchLoginTextBox = new System.Windows.Forms.TextBox();
			this.szukajButton = new System.Windows.Forms.Button();
			this.nazwiskoLabel = new System.Windows.Forms.Label();
			this.imieLabel = new System.Windows.Forms.Label();
			this.czyscNazwiskoButton = new System.Windows.Forms.Button();
			this.searchNazwiskoTextBox = new System.Windows.Forms.TextBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.confirmButton = new System.Windows.Forms.Button();
			this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dostawasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zamowieniesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPracownikaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn,
            this.dostawasDataGridViewTextBoxColumn,
            this.zamowieniesDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.pracownikBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(12, 12);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(727, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// pracownikBindingSource
			// 
			this.pracownikBindingSource.DataSource = typeof(BDProjekt.Pracownik);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Login";
			// 
			// searchLoginTextBox
			// 
			this.searchLoginTextBox.Location = new System.Drawing.Point(74, 234);
			this.searchLoginTextBox.Name = "searchLoginTextBox";
			this.searchLoginTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchLoginTextBox.TabIndex = 30;
			// 
			// szukajButton
			// 
			this.szukajButton.Location = new System.Drawing.Point(194, 180);
			this.szukajButton.Name = "szukajButton";
			this.szukajButton.Size = new System.Drawing.Size(75, 23);
			this.szukajButton.TabIndex = 29;
			this.szukajButton.Text = "Szukaj";
			this.szukajButton.UseVisualStyleBackColor = true;
			this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
			// 
			// nazwiskoLabel
			// 
			this.nazwiskoLabel.AutoSize = true;
			this.nazwiskoLabel.Location = new System.Drawing.Point(15, 211);
			this.nazwiskoLabel.Name = "nazwiskoLabel";
			this.nazwiskoLabel.Size = new System.Drawing.Size(53, 13);
			this.nazwiskoLabel.TabIndex = 28;
			this.nazwiskoLabel.Text = "Nazwisko";
			// 
			// imieLabel
			// 
			this.imieLabel.AutoSize = true;
			this.imieLabel.Location = new System.Drawing.Point(42, 187);
			this.imieLabel.Name = "imieLabel";
			this.imieLabel.Size = new System.Drawing.Size(26, 13);
			this.imieLabel.TabIndex = 27;
			this.imieLabel.Text = "Imie";
			// 
			// czyscNazwiskoButton
			// 
			this.czyscNazwiskoButton.Location = new System.Drawing.Point(275, 180);
			this.czyscNazwiskoButton.Name = "czyscNazwiskoButton";
			this.czyscNazwiskoButton.Size = new System.Drawing.Size(75, 23);
			this.czyscNazwiskoButton.TabIndex = 26;
			this.czyscNazwiskoButton.Text = "Czyść";
			this.czyscNazwiskoButton.UseVisualStyleBackColor = true;
			this.czyscNazwiskoButton.Click += new System.EventHandler(this.czyscNazwiskoButton_Click);
			// 
			// searchNazwiskoTextBox
			// 
			this.searchNazwiskoTextBox.Location = new System.Drawing.Point(74, 208);
			this.searchNazwiskoTextBox.Name = "searchNazwiskoTextBox";
			this.searchNazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchNazwiskoTextBox.TabIndex = 25;
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(74, 182);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(100, 20);
			this.searchTextBox.TabIndex = 24;
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(389, 206);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(75, 23);
			this.confirmButton.TabIndex = 23;
			this.confirmButton.Text = "Zatwierdź";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// idPracownikaDataGridViewTextBoxColumn
			// 
			this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
			this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "IdPracownika";
			this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
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
			// dostawasDataGridViewTextBoxColumn
			// 
			this.dostawasDataGridViewTextBoxColumn.DataPropertyName = "Dostawas";
			this.dostawasDataGridViewTextBoxColumn.HeaderText = "Dostawas";
			this.dostawasDataGridViewTextBoxColumn.Name = "dostawasDataGridViewTextBoxColumn";
			this.dostawasDataGridViewTextBoxColumn.Visible = false;
			// 
			// zamowieniesDataGridViewTextBoxColumn
			// 
			this.zamowieniesDataGridViewTextBoxColumn.DataPropertyName = "Zamowienies";
			this.zamowieniesDataGridViewTextBoxColumn.HeaderText = "Zamowienies";
			this.zamowieniesDataGridViewTextBoxColumn.Name = "zamowieniesDataGridViewTextBoxColumn";
			this.zamowieniesDataGridViewTextBoxColumn.Visible = false;
			// 
			// AdminPracownikControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.searchLoginTextBox);
			this.Controls.Add(this.szukajButton);
			this.Controls.Add(this.nazwiskoLabel);
			this.Controls.Add(this.imieLabel);
			this.Controls.Add(this.czyscNazwiskoButton);
			this.Controls.Add(this.searchNazwiskoTextBox);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.dataGridView2);
			this.Name = "AdminPracownikControl";
			this.Size = new System.Drawing.Size(769, 401);
			this.Load += new System.EventHandler(this.AdminPracownikControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchLoginTextBox;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Button czyscNazwiskoButton;
        private System.Windows.Forms.TextBox searchNazwiskoTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dostawasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zamowieniesDataGridViewTextBoxColumn;
    }
}
