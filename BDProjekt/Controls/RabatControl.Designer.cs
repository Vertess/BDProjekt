namespace BDProjekt
{
    partial class RabatControl
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.opisrabatuLabel = new System.Windows.Forms.Label();
            this.wysokoscrabatuLabel = new System.Windows.Forms.Label();
            this.searchWysokoscRabatuTextBox = new System.Windows.Forms.TextBox();
            this.resetWysokoscRabatuButton = new System.Windows.Forms.Button();
            this.idRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wysokoscRabatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRabatuDataGridViewTextBoxColumn,
            this.opisRabatuDataGridViewTextBoxColumn,
            this.wysokoscRabatuDataGridViewTextBoxColumn,
            this.zamowieniesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rabatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(126, 162);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(529, 175);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // opisrabatuLabel
            // 
            this.opisrabatuLabel.AutoSize = true;
            this.opisrabatuLabel.Location = new System.Drawing.Point(59, 164);
            this.opisrabatuLabel.Name = "opisrabatuLabel";
            this.opisrabatuLabel.Size = new System.Drawing.Size(61, 13);
            this.opisrabatuLabel.TabIndex = 9;
            this.opisrabatuLabel.Text = "Opis rabatu";
            // 
            // wysokoscrabatuLabel
            // 
            this.wysokoscrabatuLabel.AutoSize = true;
            this.wysokoscrabatuLabel.Location = new System.Drawing.Point(59, 195);
            this.wysokoscrabatuLabel.Name = "wysokoscrabatuLabel";
            this.wysokoscrabatuLabel.Size = new System.Drawing.Size(90, 13);
            this.wysokoscrabatuLabel.TabIndex = 10;
            this.wysokoscrabatuLabel.Text = "Wysokość rabatu";
            // 
            // searchWysokoscRabatuTextBox
            // 
            this.searchWysokoscRabatuTextBox.Location = new System.Drawing.Point(155, 192);
            this.searchWysokoscRabatuTextBox.Name = "searchWysokoscRabatuTextBox";
            this.searchWysokoscRabatuTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchWysokoscRabatuTextBox.TabIndex = 11;
            // 
            // resetWysokoscRabatuButton
            // 
            this.resetWysokoscRabatuButton.Location = new System.Drawing.Point(382, 175);
            this.resetWysokoscRabatuButton.Name = "resetWysokoscRabatuButton";
            this.resetWysokoscRabatuButton.Size = new System.Drawing.Size(75, 23);
            this.resetWysokoscRabatuButton.TabIndex = 13;
            this.resetWysokoscRabatuButton.Text = "Czyść";
            this.resetWysokoscRabatuButton.UseVisualStyleBackColor = true;
            this.resetWysokoscRabatuButton.Click += new System.EventHandler(this.resetWysokoscRabatuButton_Click);
            // 
            // idRabatuDataGridViewTextBoxColumn
            // 
            this.idRabatuDataGridViewTextBoxColumn.DataPropertyName = "IdRabatu";
            this.idRabatuDataGridViewTextBoxColumn.HeaderText = "IdRabatu";
            this.idRabatuDataGridViewTextBoxColumn.Name = "idRabatuDataGridViewTextBoxColumn";
            // 
            // opisRabatuDataGridViewTextBoxColumn
            // 
            this.opisRabatuDataGridViewTextBoxColumn.DataPropertyName = "OpisRabatu";
            this.opisRabatuDataGridViewTextBoxColumn.HeaderText = "OpisRabatu";
            this.opisRabatuDataGridViewTextBoxColumn.Name = "opisRabatuDataGridViewTextBoxColumn";
            // 
            // wysokoscRabatuDataGridViewTextBoxColumn
            // 
            this.wysokoscRabatuDataGridViewTextBoxColumn.DataPropertyName = "WysokoscRabatu";
            this.wysokoscRabatuDataGridViewTextBoxColumn.HeaderText = "WysokoscRabatu";
            this.wysokoscRabatuDataGridViewTextBoxColumn.Name = "wysokoscRabatuDataGridViewTextBoxColumn";
            // 
            // zamowieniesDataGridViewTextBoxColumn
            // 
            this.zamowieniesDataGridViewTextBoxColumn.DataPropertyName = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.HeaderText = "Zamowienies";
            this.zamowieniesDataGridViewTextBoxColumn.Name = "zamowieniesDataGridViewTextBoxColumn";
            // 
            // rabatBindingSource
            // 
            this.rabatBindingSource.DataSource = typeof(BDProjekt.Rabat);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(301, 175);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // RabatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resetWysokoscRabatuButton);
            this.Controls.Add(this.searchWysokoscRabatuTextBox);
            this.Controls.Add(this.wysokoscrabatuLabel);
            this.Controls.Add(this.opisrabatuLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RabatControl";
            this.Size = new System.Drawing.Size(640, 245);
            this.Load += new System.EventHandler(this.RabatControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRabatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisRabatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wysokoscRabatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamowieniesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rabatBindingSource;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label opisrabatuLabel;
        private System.Windows.Forms.Label wysokoscrabatuLabel;
        private System.Windows.Forms.TextBox searchWysokoscRabatuTextBox;
        private System.Windows.Forms.Button resetWysokoscRabatuButton;
        private System.Windows.Forms.Button searchButton;
    }
}
