namespace BDProjekt.Controls
{
    partial class DostawaControl
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
            this.idDostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDostawyDataGridViewTextBoxColumn,
            this.oferentDataGridViewTextBoxColumn,
            this.pracownikDataGridViewTextBoxColumn,
            this.elementyDostawiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dostawaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDostawyDataGridViewTextBoxColumn
            // 
            this.idDostawyDataGridViewTextBoxColumn.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.Name = "idDostawyDataGridViewTextBoxColumn";
            // 
            // oferentDataGridViewTextBoxColumn
            // 
            this.oferentDataGridViewTextBoxColumn.DataPropertyName = "Oferent";
            this.oferentDataGridViewTextBoxColumn.HeaderText = "Oferent";
            this.oferentDataGridViewTextBoxColumn.Name = "oferentDataGridViewTextBoxColumn";
            // 
            // pracownikDataGridViewTextBoxColumn
            // 
            this.pracownikDataGridViewTextBoxColumn.DataPropertyName = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.pracownikDataGridViewTextBoxColumn.Name = "pracownikDataGridViewTextBoxColumn";
            // 
            // elementyDostawiesDataGridViewTextBoxColumn
            // 
            this.elementyDostawiesDataGridViewTextBoxColumn.DataPropertyName = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.HeaderText = "ElementyDostawies";
            this.elementyDostawiesDataGridViewTextBoxColumn.Name = "elementyDostawiesDataGridViewTextBoxColumn";
            // 
            // dostawaBindingSource
            // 
            this.dostawaBindingSource.DataSource = typeof(BDProjekt.Dostawa);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(404, 191);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(20, 191);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(127, 187);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(208, 187);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // DostawaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DostawaControl";
            this.Size = new System.Drawing.Size(482, 281);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyDostawiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
    }
}
