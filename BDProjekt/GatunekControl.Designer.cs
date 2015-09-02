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
            this.nazwaGatunkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatunekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaGatunkuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gatunekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(144, 191);
            this.dataGridView1.TabIndex = 0;
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
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(519, 290);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Ok";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // GatunekControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GatunekControl";
            this.Size = new System.Drawing.Size(622, 348);
            this.Load += new System.EventHandler(this.GatunekControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaGatunkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.BindingSource gatunekBindingSource;

    }
}
