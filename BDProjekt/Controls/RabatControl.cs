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
    public partial class RabatControl : UserControl
    {
        public RabatControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                rabatBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList().Where(n => n.OpisRabatu.Contains(this.searchTextBox.Text));
        }

        private void RabatControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Rabats.Load();
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
            }
        }

        private void searchWysokoscRabatuButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList().Where(n => n.OpisRabatu.Contains(this.searchTextBox.Text));
        }

        private void resetWysokoscRabatuButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList()
    .Where(n => n.OpisRabatu.Contains(this.searchTextBox.Text));
            if (searchTextBox.Text.Length == 0)
            {
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
            }
        }

        private void searchWysokoscRabatuTextBox_TextChanged(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList()
    .Where(n => n.WysokoscRabatu.Equals(Convert.ToInt32(this.searchWysokoscRabatuTextBox.Text)));
            if (searchWysokoscRabatuTextBox.Text.Length == 0)
            {
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
            }
        }
    }
}
