using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BDProjekt
{
	public partial class Form1 : Form
	{
		private bool loginOption = false;
		public Form1()
		{
			InitializeComponent();

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (TabPage item in Glowna_tabControl.TabPages)
			{
				Funkcje.Instance.pages.Add(item);
			}
            Funkcje.Instance.Login(Glowna_tabControl, Funkcje.Instance.Logowanie, this.button1);
			this.logowanieComboBox.DataSource = Enum.GetValues(typeof(Uzytkownicy));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.loginOption)
			{
                Funkcje.Instance.Login(Glowna_tabControl, (Uzytkownicy)this.logowanieComboBox.SelectedItem, this.button1 ,this.loginOption, this.loginTextBox.Text, this.hasloTextBox.Text);
			}
			else
			{
                Funkcje.Instance.Login(Glowna_tabControl, Funkcje.Instance.Logowanie, this.button1);
			}

			this.loginOption = !loginOption;
		}

		private void pracownikOfertyPrzegladaj_Button_Click(object sender, EventArgs e)
		{

		}

		private void pracownikOfetyUsun_Button_Click(object sender, EventArgs e)
		{

		}

		private void pracownikOfertyZnajdzTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void pracownikOfertyZnajdz_Button_Click(object sender, EventArgs e)
		{

		}

		private void pracownikOfertyListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void pracownikOfertyAkceptuj_Button_Click(object sender, EventArgs e)
		{

		}


	}
}
