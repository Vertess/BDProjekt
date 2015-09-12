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

        private void searchButton_Click(object sender, EventArgs e)
        {

            autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList()
				.Where(n => n.Imie.Contains(this.searchTextBox.Text) || n.Nazwisko.Contains(this.searchTextBox.Text));

        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
			autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList()
	.Where(n => n.Imie.Contains(this.searchTextBox.Text) || n.Nazwisko.Contains(this.searchTextBox.Text));
			if (searchTextBox.Text.Length == 0)
			{
				autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
			}
        }

		private void resetButton_Click(object sender, EventArgs e)
		{
			//autorBindingSource.DataSource = Funckje.Instance._context.Autors.Local.ToBindingList();
			searchTextBox.Text = string.Empty;
		}
    }
}
