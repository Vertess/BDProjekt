namespace BDProjekt.Controls
{
    partial class OferentDostawyControl
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
            this.oferentIdOferentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikIdPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementyDostawiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.oferentIdOferentaDataGridViewTextBoxColumn,
            this.pracownikIdPracownikaDataGridViewTextBoxColumn,
            this.oferentDataGridViewTextBoxColumn,
            this.pracownikDataGridViewTextBoxColumn,
            this.elementyDostawiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dostawaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDostawyDataGridViewTextBoxColumn
            // 
            this.idDostawyDataGridViewTextBoxColumn.DataPropertyName = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.HeaderText = "IdDostawy";
            this.idDostawyDataGridViewTextBoxColumn.Name = "idDostawyDataGridViewTextBoxColumn";
            // 
            // oferentIdOferentaDataGridViewTextBoxColumn
            // 
            this.oferentIdOferentaDataGridViewTextBoxColumn.DataPropertyName = "Oferent_IdOferenta";
            this.oferentIdOferentaDataGridViewTextBoxColumn.HeaderText = "Oferent_IdOferenta";
            this.oferentIdOferentaDataGridViewTextBoxColumn.Name = "oferentIdOferentaDataGridViewTextBoxColumn";
            // 
            // pracownikIdPracownikaDataGridViewTextBoxColumn
            // 
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_IdPracownika";
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.HeaderText = "Pracownik_IdPracownika";
            this.pracownikIdPracownikaDataGridViewTextBoxColumn.Name = "pracownikIdPracownikaDataGridViewTextBoxColumn";
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
            // OferentDostawyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "OferentDostawyControl";
            this.Size = new System.Drawing.Size(1257, 514);
            this.Load += new System.EventHandler(this.OferentDostawyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentIdOferentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIdPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementyDostawiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
    }
}
