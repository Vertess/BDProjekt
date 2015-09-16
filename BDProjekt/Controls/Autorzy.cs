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

    public partial class Autorzy : UserControl
    {

        public Autorzy()
        {
            InitializeComponent();
        }

        private void Autorzy_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Autors.Load();
                autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                autorBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void czyscNazwiskoButton_Click(object sender, EventArgs e)
        {
            searchNazwiskoTextBox.Text = string.Empty;
            searchTextBox.Text = string.Empty; 
        }

        private void szukajButton_Click(object sender, EventArgs e)
        {
            autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList()
    .Where(n => n.Nazwisko.Contains(this.searchNazwiskoTextBox.Text) && n.Imie.Contains(this.searchTextBox.Text));
            if (searchNazwiskoTextBox.Text.Length == 0 && searchTextBox.Text.Length == 0)
            {
                autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
            }
        }
    }
}
