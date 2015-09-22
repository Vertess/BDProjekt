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
			autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
		}

		private void szukajButton_Click(object sender, EventArgs e)
		{
            if (dataUrodzeniaCheckBox.Checked)
            {
                autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList()
        .Where(n => n.Nazwisko.Contains(this.searchNazwiskoTextBox.Text) && n.Imie.Contains(this.searchTextBox.Text) && (n.DataUrodzenia >= dateTimePicker1.Value) && (n.DataUrodzenia <= dateTimePicker2.Value));

             
            
            }
            else
            {
                autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList()
        .Where(n => n.Nazwisko.Contains(this.searchNazwiskoTextBox.Text) && n.Imie.Contains(this.searchTextBox.Text));
                if (searchNazwiskoTextBox.Text.Length == 0 && searchTextBox.Text.Length == 0)
                {
                    autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
                }
            }


		}

        private void nazwiskoLabel_Click(object sender, EventArgs e)
        {

        }

        private void imieLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchNazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
