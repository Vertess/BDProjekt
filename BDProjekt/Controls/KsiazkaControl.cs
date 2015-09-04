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
	public partial class KsiazkaControl : UserControl
	{
		public KsiazkaControl()
		{
			InitializeComponent();
		}

		private void KsiazkaControl_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				ContextInformation.Instance._context.Gatuneks.Load();
				gatunekBindingSource.DataSource = ContextInformation.Instance._context.Gatuneks.Local.ToBindingList();
				ContextInformation.Instance._context.Ksiazkas.Load();
				ksiazkaBindingSource.DataSource = ContextInformation.Instance._context.Ksiazkas.Local.ToBindingList();
			}
		}
		private void zatwierdzButton_Click(object sender, System.EventArgs e)
		{
			if (!DesignMode)
			{
				ksiazkaBindingSource.ResetBindings(false);
				ContextInformation.Instance._context.SaveChanges();
			}
		}

        private void searchButton_Click(object sender, EventArgs e)
        {
           ksiazkaBindingSource.DataSource = ContextInformation.Instance._context.Ksiazkas.Local.ToBindingList().Where(n => n.Tytul.Contains(this.searchTextBox.Text) || n.Opis.Contains(this.searchTextBox.Text));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ksiazkaBindingSource.DataSource = ContextInformation.Instance._context.Ksiazkas.Local.ToBindingList();
        }
	}
}
