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
    public partial class ReklamacjaControl : UserControl
    {
        public ReklamacjaControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                reklamacjaBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void ReklamacjaControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Reklamacjas.Load();
                reklamacjaBindingSource.DataSource = Funkcje.Instance._context.Reklamacjas.Local.ToBindingList();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            reklamacjaBindingSource.DataSource = Funkcje.Instance._context.Reklamacjas.Local.ToBindingList()
   .Where(n => n.Opis.Contains(this.searchTextBox.Text));
            if (searchTextBox.Text.Length == 0)
            {
                reklamacjaBindingSource.DataSource = Funkcje.Instance._context.Reklamacjas.Local.ToBindingList();
            }
        }
    }
}
