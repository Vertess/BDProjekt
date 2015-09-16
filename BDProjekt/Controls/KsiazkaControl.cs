using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BDProjekt
{
	public partial class KsiazkaControl : UserControl
	{
		public KsiazkaControl()
		{
			InitializeComponent();
		}
		private void KsiazkaControl_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				Funkcje.Instance._context.Gatuneks.Load();
				gatunekBindingSource.DataSource = Funkcje.Instance._context.Gatuneks.Local.ToBindingList();
				Funkcje.Instance._context.Ksiazkas.Load();
				ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList();
				DataGridViewComboBoxColumn gatunekColumn = dataGridView1.Columns["gatunekComboBoxColumn"] as DataGridViewComboBoxColumn;
				gatunekColumn.ValueType = typeof(Gatunek);
			}
		}
		private void zatwierdzButton_Click(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
                //cvxgfbrt unkhcnb td
				Ksiazka ks = new Ksiazka();
				Gatunek gt = new Gatunek();
				gt = (Gatunek)gatunekBindingSource.Current;
				ks = (Ksiazka)ksiazkaBindingSource.Current;
				ks.Gatunek_IdGatunku = gt.IdGatunku;
				ksiazkaBindingSource.ResetBindings(false);
				Funkcje.Instance._context.SaveChanges();
			}

		}

		void dataGridView1_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
		{
			if (e.Context == DataGridViewDataErrorContexts.Formatting || e.Context == DataGridViewDataErrorContexts.PreferredSize)
			{
				e.ThrowException = false;
			}
		}

        private void searchOpisTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchTytulTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resetTytulButton_Click(object sender, EventArgs e)
        {
            searchTytulTextBox.Text = string.Empty;
            searchOpisTextBox.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList()
    .Where(n => n.Tytul.Contains(this.searchTytulTextBox.Text) && n.Opis.Contains(this.searchOpisTextBox.Text));
            if (searchTytulTextBox.Text.Length == 0 && searchOpisTextBox.Text.Length == 0)
            {
                ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList();
            }
        }
	}
}
