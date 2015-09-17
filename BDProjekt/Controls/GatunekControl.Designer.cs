namespace BDProjekt
{
    partial class GatunekControl
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.nazwagatunkuLabel = new System.Windows.Forms.Label();
            this.idGatunkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaGatunkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGatunkuDataGridViewTextBoxColumn,
            this.nazwaGatunkuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gatunekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(140, 261);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(246, 259);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(327, 259);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Czyść";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // nazwagatunkuLabel
            // 
            this.nazwagatunkuLabel.AutoSize = true;
            this.nazwagatunkuLabel.Location = new System.Drawing.Point(50, 266);
            this.nazwagatunkuLabel.Name = "nazwagatunkuLabel";
            this.nazwagatunkuLabel.Size = new System.Drawing.Size(84, 13);
            this.nazwagatunkuLabel.TabIndex = 10;
            this.nazwagatunkuLabel.Text = "Nazwa Gatunku";
            // 
            // idGatunkuDataGridViewTextBoxColumn
            // 
            this.idGatunkuDataGridViewTextBoxColumn.DataPropertyName = "IdGatunku";
            this.idGatunkuDataGridViewTextBoxColumn.HeaderText = "IdGatunku";
            this.idGatunkuDataGridViewTextBoxColumn.Name = "idGatunkuDataGridViewTextBoxColumn";
            // 
            // nazwaGatunkuDataGridViewTextBoxColumn
            // 
            this.nazwaGatunkuDataGridViewTextBoxColumn.DataPropertyName = "NazwaGatunku";
            this.nazwaGatunkuDataGridViewTextBoxColumn.HeaderText = "NazwaGatunku";
            this.nazwaGatunkuDataGridViewTextBoxColumn.Name = "nazwaGatunkuDataGridViewTextBoxColumn";
            // 
            // gatunekBindingSource
            // 
            this.gatunekBindingSource.DataSource = typeof(BDProjekt.Gatunek);
            // 
            // GatunekControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazwagatunkuLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GatunekControl";
            this.Size = new System.Drawing.Size(622, 348);
            this.Load += new System.EventHandler(this.GatunekControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gatunekBindingSource;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idGatunkuDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nazwaGatunkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label nazwagatunkuLabel;

    }
}
