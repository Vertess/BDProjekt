namespace BDProjekt.Controls
{
    partial class OferentReklamacjeControl
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
            this.idReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idTypuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizacjeReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reklamacjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReklamacjiDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.typDataGridViewCheckBoxColumn,
            this.idTypuDataGridViewTextBoxColumn,
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn,
            this.realizacjeReklamacjiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reklamacjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(689, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // idReklamacjiDataGridViewTextBoxColumn
            // 
            this.idReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.HeaderText = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.Name = "idReklamacjiDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // typDataGridViewCheckBoxColumn
            // 
            this.typDataGridViewCheckBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewCheckBoxColumn.HeaderText = "Typ";
            this.typDataGridViewCheckBoxColumn.Name = "typDataGridViewCheckBoxColumn";
            // 
            // idTypuDataGridViewTextBoxColumn
            // 
            this.idTypuDataGridViewTextBoxColumn.DataPropertyName = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.HeaderText = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.Name = "idTypuDataGridViewTextBoxColumn";
            // 
            // realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn
            // 
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjeReklamacji_IdRealizacji";
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjeReklamacji_IdRealizacji";
            this.realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn.Name = "realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn";
            // 
            // realizacjeReklamacjiDataGridViewTextBoxColumn
            // 
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.Name = "realizacjeReklamacjiDataGridViewTextBoxColumn";
            // 
            // reklamacjaBindingSource
            // 
            this.reklamacjaBindingSource.DataSource = typeof(BDProjekt.Reklamacja);
            // 
            // OferentReklamacjeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "OferentReklamacjeControl";
            this.Size = new System.Drawing.Size(960, 478);
            this.Load += new System.EventHandler(this.OferentReklamacjeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReklamacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjeReklamacjiIdRealizacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjeReklamacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reklamacjaBindingSource;

    }
}
