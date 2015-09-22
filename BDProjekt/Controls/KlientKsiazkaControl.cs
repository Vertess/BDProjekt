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

namespace BDProjekt.Controls
{
    public partial class KlientKsiazkaControl : UserControl
    {
        public KlientKsiazkaControl()
        {
            InitializeComponent();
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

        private void resetTytulButton_Click(object sender, EventArgs e)
        {

            searchTytulTextBox.Text = string.Empty;
            searchOpisTextBox.Text = string.Empty;
            ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList();
        }

        private void KlientKsiazkaControl_Load(object sender, EventArgs e)
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
    }
}
