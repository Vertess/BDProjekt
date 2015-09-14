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
    public partial class EgzemplarzControl : UserControl
    {
        public EgzemplarzControl()
        {
            InitializeComponent();
        }

        private void EgzemplarzControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Wydawnictwoes.Load();
                wydawnictwoBindingSource.DataSource = Funkcje.Instance._context.Wydawnictwoes.Local.ToBindingList();
                Funkcje.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
                Funkcje.Instance._context.Ksiazkas.Load();
                ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList();
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Ksiazka ks = new Ksiazka();
                Egzemplarz eg = new Egzemplarz();
                Wydawnictwo wd = new Wydawnictwo();
                ks = (Ksiazka)ksiazkaBindingSource.Current;
                eg = (Egzemplarz)egzemplarzBindingSource.Current;
                wd = (Wydawnictwo)wydawnictwoBindingSource.Current;
                eg.Wydawnictwo_IdWydawnictwa = wd.IdWydawnictwa;
                eg.Ksiazka_IdKsiazki = ks.IdKsiazki;
                egzemplarzBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void searchCenaTextBox_TextChanged(object sender, EventArgs e)
        {
            egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList()
    .Where(n => n.Cena.Equals(Convert.ToInt32(this.searchCenaTextBox.Text)));
            if (searchCenaTextBox.Text.Length == 0)
            {
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
            }
        }

        private void searchIloscTextBox_TextChanged(object sender, EventArgs e)
        {
            egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList()
    .Where(n => n.Iloscc.Equals(Convert.ToInt32(this.searchIloscTextBox.Text)));
            if (searchIloscTextBox.Text.Length == 0)
            {
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
            }
        }

        private void searchTypTextBox_TextChanged(object sender, EventArgs e)
        {
            /*egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList()
    .Where(n => n.TypOkladki.Contains(this.searchTypTextBox.Text));
            if (searchTypTextBox.Text.Length == 0)
            {
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
            }*/
        }

        private void resetTypButton_Click(object sender, EventArgs e)
        {
            searchCenaTextBox.Text = string.Empty;
            searchTypTextBox.Text = string.Empty;
            searchIloscTextBox.Text = string.Empty;
        }

    }
}
