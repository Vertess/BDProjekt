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
    public partial class AdminKlientControl : UserControl
    {
        public AdminKlientControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                klientBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void czyscNazwiskoButton_Click(object sender, EventArgs e)
        {
            searchNazwiskoTextBox.Text = string.Empty;
            searchTextBox.Text = string.Empty;
            searchLoginTextBox.Text = string.Empty;
            searchEmailTextBox.Text = string.Empty;
            klientBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
        }

        private void AdminKlientControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Klients.Load();
                klientBindingSource.DataSource = Funkcje.Instance._context.Klients.Local.ToBindingList();
            }
        }

        private void szukajButton_Click(object sender, EventArgs e)
        {
            klientBindingSource.DataSource = Funkcje.Instance._context.Klients.Local.ToBindingList()
.Where(n => n.Nazwisko.Contains(this.searchNazwiskoTextBox.Text) && n.Imie.Contains(this.searchTextBox.Text)
&& n.Login.Contains(this.searchLoginTextBox.Text) && n.Email.Contains(this.searchEmailTextBox.Text)

);
            if (searchNazwiskoTextBox.Text.Length == 0 && searchTextBox.Text.Length == 0 && searchLoginTextBox.Text.Length == 0 && searchEmailTextBox.Text.Length == 0)
            {
                klientBindingSource.DataSource = Funkcje.Instance._context.Klients.Local.ToBindingList();
            }
        }
    }
}
