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
    public partial class AdminPracownikControl : UserControl
    {
        public AdminPracownikControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                pracownikBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void AdminPracownikControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Pracowniks.Load();
                pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
            }
        }

        private void czyscNazwiskoButton_Click(object sender, EventArgs e)
        {
            searchNazwiskoTextBox.Text = string.Empty;
            searchTextBox.Text = string.Empty;
            searchLoginTextBox.Text = string.Empty;
            pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
        }

        private void szukajButton_Click(object sender, EventArgs e)
        {
            pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList()
.Where(n => n.Nazwisko.Contains(this.searchNazwiskoTextBox.Text) && n.Imie.Contains(this.searchTextBox.Text)
&& n.Login.Contains(this.searchLoginTextBox.Text)

);
            if (searchNazwiskoTextBox.Text.Length == 0 && searchTextBox.Text.Length == 0 && searchLoginTextBox.Text.Length == 0)
            {
                pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
            }
        }
    }
}
