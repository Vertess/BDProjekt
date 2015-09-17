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
    public partial class AdminOferentControl : UserControl
    {
        public AdminOferentControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                oferentBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void AdminOferentControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Oferents.Load();
                oferentBindingSource.DataSource = Funkcje.Instance._context.Oferents.Local.ToBindingList();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            oferentBindingSource.DataSource = Funkcje.Instance._context.Oferents.Local.ToBindingList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           oferentBindingSource.DataSource = Funkcje.Instance._context.Oferents.Local.ToBindingList().Where(n => n.NazwaFirmy.Contains(this.searchTextBox.Text));
        }
    }
}
