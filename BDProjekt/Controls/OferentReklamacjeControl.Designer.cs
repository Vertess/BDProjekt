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
            this.OferentReklamacjeDataGridView = new System.Windows.Forms.DataGridView();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.dostawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realizacjeReklamacjiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reklamacjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdDostawy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizacja = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.realizacjeReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idTypuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReklamacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OferentReklamacjeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizacjeReklamacjiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OferentReklamacjeDataGridView
            // 
            this.OferentReklamacjeDataGridView.AllowUserToAddRows = false;
            this.OferentReklamacjeDataGridView.AllowUserToDeleteRows = false;
            this.OferentReklamacjeDataGridView.AutoGenerateColumns = false;
            this.OferentReklamacjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OferentReklamacjeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDostawy,
            this.opisDataGridViewTextBoxColumn,
            this.Realizacja,
            this.realizacjeReklamacjiDataGridViewTextBoxColumn,
            this.typDataGridViewCheckBoxColumn,
            this.idTypuDataGridViewTextBoxColumn,
            this.idReklamacjiDataGridViewTextBoxColumn});
            this.OferentReklamacjeDataGridView.DataSource = this.reklamacjaBindingSource;
            this.OferentReklamacjeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OferentReklamacjeDataGridView.Name = "OferentReklamacjeDataGridView";
            this.OferentReklamacjeDataGridView.RowTemplate.Height = 28;
            this.OferentReklamacjeDataGridView.Size = new System.Drawing.Size(941, 368);
            this.OferentReklamacjeDataGridView.TabIndex = 0;
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(991, 115);
            this.zatwierdzButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(124, 93);
            this.zatwierdzButton.TabIndex = 2;
            this.zatwierdzButton.Text = "Zaladuj / Zatwierdź zmiany";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // dostawaBindingSource
            // 
            this.dostawaBindingSource.DataSource = typeof(BDProjekt.Dostawa);
            // 
            // realizacjeReklamacjiBindingSource
            // 
            this.realizacjeReklamacjiBindingSource.DataSource = typeof(BDProjekt.RealizacjeReklamacji);
            // 
            // reklamacjaBindingSource
            // 
            this.reklamacjaBindingSource.DataSource = typeof(BDProjekt.Reklamacja);
            // 
            // IdDostawy
            // 
            this.IdDostawy.DataPropertyName = "IdTypu";
            this.IdDostawy.DataSource = this.dostawaBindingSource;
            this.IdDostawy.DisplayMember = "IdDostawy";
            this.IdDostawy.HeaderText = "Id Dostawy";
            this.IdDostawy.Name = "IdDostawy";
            this.IdDostawy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdDostawy.ValueMember = "IdDostawy";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 300;
            // 
            // Realizacja
            // 
            this.Realizacja.DataPropertyName = "RealizacjeReklamacji_IdRealizacji";
            this.Realizacja.DataSource = this.realizacjeReklamacjiBindingSource;
            this.Realizacja.DisplayMember = "Opis";
            this.Realizacja.HeaderText = "Realizacja";
            this.Realizacja.Name = "Realizacja";
            this.Realizacja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Realizacja.ValueMember = "IdRealizacji";
            // 
            // realizacjeReklamacjiDataGridViewTextBoxColumn
            // 
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.HeaderText = "RealizacjeReklamacji";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.Name = "realizacjeReklamacjiDataGridViewTextBoxColumn";
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.realizacjeReklamacjiDataGridViewTextBoxColumn.Visible = false;
            // 
            // typDataGridViewCheckBoxColumn
            // 
            this.typDataGridViewCheckBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewCheckBoxColumn.HeaderText = "Typ";
            this.typDataGridViewCheckBoxColumn.Name = "typDataGridViewCheckBoxColumn";
            this.typDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idTypuDataGridViewTextBoxColumn
            // 
            this.idTypuDataGridViewTextBoxColumn.DataPropertyName = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.HeaderText = "IdTypu";
            this.idTypuDataGridViewTextBoxColumn.Name = "idTypuDataGridViewTextBoxColumn";
            this.idTypuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTypuDataGridViewTextBoxColumn.Visible = false;
            // 
            // idReklamacjiDataGridViewTextBoxColumn
            // 
            this.idReklamacjiDataGridViewTextBoxColumn.DataPropertyName = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.HeaderText = "IdReklamacji";
            this.idReklamacjiDataGridViewTextBoxColumn.Name = "idReklamacjiDataGridViewTextBoxColumn";
            this.idReklamacjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReklamacjiDataGridViewTextBoxColumn.Visible = false;
            // 
            // OferentReklamacjeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.OferentReklamacjeDataGridView);
            this.Name = "OferentReklamacjeControl";
            this.Size = new System.Drawing.Size(1145, 398);
            ((System.ComponentModel.ISupportInitialize)(this.OferentReklamacjeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizacjeReklamacjiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OferentReklamacjeDataGridView;
        private System.Windows.Forms.BindingSource reklamacjaBindingSource;
        private System.Windows.Forms.BindingSource dostawaBindingSource;
        private System.Windows.Forms.BindingSource realizacjeReklamacjiBindingSource;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdDostawy;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Realizacja;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizacjeReklamacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReklamacjiDataGridViewTextBoxColumn;

    }
}
