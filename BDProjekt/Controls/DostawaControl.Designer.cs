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
            this.ElementyDostawies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oferentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatwierdzButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDostawyDataGridViewTextBoxColumn,
            this.ElementyDostawies,
            this.oferentComboBoxColumn,
            this.pracownikComboBoxColumn});
            this.dataGridView1.DataSource = this.dostawaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDostawyDataGridViewTextBoxColumn
            // 
            this.idDostawyDataGridViewTextBoxColumn.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.Name = "idDostawyDataGridViewTextBoxColumn";
            // 
            // ElementyDostawies
            // 
            this.ElementyDostawies.DataPropertyName = "ElementyDostawies";
            this.ElementyDostawies.HeaderText = "ElementyDostawies";
            this.ElementyDostawies.Name = "ElementyDostawies";
            // 
            // oferentComboBoxColumn
            // 
            this.oferentComboBoxColumn.DataSource = this.oferentBindingSource;
            this.oferentComboBoxColumn.DisplayMember = "NazwaFirmy";
            this.oferentComboBoxColumn.HeaderText = "Oferent";
            this.oferentComboBoxColumn.Name = "oferentComboBoxColumn";
            this.oferentComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oferentComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oferentComboBoxColumn.ValueMember = "IdOferenta";
            // 
            // oferentBindingSource
            // 
            this.oferentBindingSource.DataSource = typeof(BDProjekt.Oferent);
            // 
            // pracownikComboBoxColumn
            // 
            this.pracownikComboBoxColumn.DataSource = this.pracownikBindingSource;
            this.pracownikComboBoxColumn.DisplayMember = "Nazwisko";
            this.pracownikComboBoxColumn.HeaderText = "Pracownik";
            this.pracownikComboBoxColumn.Name = "pracownikComboBoxColumn";
            this.pracownikComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pracownikComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pracownikComboBoxColumn.ValueMember = "IdPracownika";
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataSource = typeof(BDProjekt.Pracownik);
            // 
            // dostawaBindingSource
            // 
            this.dostawaBindingSource.DataSource = typeof(BDProjekt.Dostawa);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(404, 174);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.zatwierdzButton.TabIndex = 1;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // DostawaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DostawaControl";
            this.Size = new System.Drawing.Size(488, 251);
            this.Load += new System.EventHandler(this.DostawaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oferentBindingSource;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementyDostawies;
        private System.Windows.Forms.DataGridViewComboBoxColumn oferentComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pracownikComboBoxColumn;
    }
}
