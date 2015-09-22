namespace BDProjekt.Controls
{
    partial class KlientZamowControl
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
            this.AddColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.okladkaColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wydawnictwoColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tytulColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydawnictwoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladkaColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.zamowienyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddColumn
            // 
            this.AddColumn.HeaderText = "Add";
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.ReadOnly = true;
            this.AddColumn.Width = 40;
            // 
            // okladkaColumn2
            // 
            this.okladkaColumn2.HeaderText = "Okladka";
            this.okladkaColumn2.Name = "okladkaColumn2";
            this.okladkaColumn2.ReadOnly = true;
            this.okladkaColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.okladkaColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.okladkaColumn2.Width = 30;
            // 
            // wydawnictwoColumn2
            // 
            this.wydawnictwoColumn2.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn2.Name = "wydawnictwoColumn2";
            this.wydawnictwoColumn2.ReadOnly = true;
            this.wydawnictwoColumn2.Width = 75;
            // 
            // tytulColumn2
            // 
            this.tytulColumn2.HeaderText = "Tytul";
            this.tytulColumn2.Name = "tytulColumn2";
            this.tytulColumn2.ReadOnly = true;
            this.tytulColumn2.Width = 75;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulColumn2,
            this.wydawnictwoColumn2,
            this.okladkaColumn2,
            this.AddColumn});
            this.dataGridView3.Location = new System.Drawing.Point(794, 53);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(468, 271);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowieniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowienyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 269);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulColumn,
            this.wydawnictwoColumn,
            this.okladkaColumn});
            this.dataGridView2.Location = new System.Drawing.Point(346, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(433, 271);
            this.dataGridView2.TabIndex = 6;
            // 
            // tytulColumn
            // 
            this.tytulColumn.HeaderText = "Tytul";
            this.tytulColumn.Name = "tytulColumn";
            this.tytulColumn.Width = 75;
            // 
            // wydawnictwoColumn
            // 
            this.wydawnictwoColumn.HeaderText = "Wydawnictwo";
            this.wydawnictwoColumn.Name = "wydawnictwoColumn";
            this.wydawnictwoColumn.Width = 75;
            // 
            // okladkaColumn
            // 
            this.okladkaColumn.HeaderText = "Okladka";
            this.okladkaColumn.Name = "okladkaColumn";
            this.okladkaColumn.Width = 60;
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Location = new System.Drawing.Point(36, 349);
            this.zatwierdzButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(112, 35);
            this.zatwierdzButton.TabIndex = 5;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.zatwierdzButton_Click);
            // 
            // zamowienyBindingSource
            // 
            this.zamowienyBindingSource.DataSource = typeof(BDProjekt.Zamowieny);
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idZamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KlientZamowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.zatwierdzButton);
            this.Name = "KlientZamowControl";
            this.Size = new System.Drawing.Size(1303, 437);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn AddColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okladkaColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulColumn2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn okladkaColumn;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.DataGridViewButtonColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zamowienyBindingSource;
    }
}
