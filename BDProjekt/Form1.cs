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
        public Form1()
        {
            InitializeComponent();

        }
		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (TabPage item in Glowna_tabControl.TabPages)
			{
				Funckje.Instance.pages.Add(item);
			}
			//Funckje.Instance.Login(Glowna_tabControl, Funckje.Instance.Logowanie);
			this.logowanieComboBox.DataSource = Enum.GetValues(typeof(Uzytkownicy));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Funckje.Instance.Login(Glowna_tabControl, (Uzytkownicy)this.logowanieComboBox.SelectedItem, this.loginTextBox.Text, this.hasloTextBox.Text);
		}
    }
}
