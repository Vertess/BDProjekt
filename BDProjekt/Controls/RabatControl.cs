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

        private void RabatControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Rabats.Load();
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
            }
        }

        private void resetWysokoscRabatuButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            searchWysokoscRabatuTextBox.Text = string.Empty;

				rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
			int tmpWysokoscRabatu = 0;
			Int32.TryParse(searchWysokoscRabatuTextBox.Text, out tmpWysokoscRabatu);
            rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList()
    .Where(n => n.OpisRabatu.Contains(this.searchTextBox.Text) && n.WysokoscRabatu.Equals(tmpWysokoscRabatu));
            if (searchTextBox.Text.Length == 0 && searchWysokoscRabatuTextBox.Text.Length == 0)
            {
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
            }
        }
    }
}
