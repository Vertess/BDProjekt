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
		private void zatwierdzButton_Click(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				Ksiazka ks = new Ksiazka();
				Gatunek gt = new Gatunek();
				gt = (Gatunek)gatunekBindingSource.Current;
				ks = (Ksiazka)ksiazkaBindingSource.Current;
				ks.Gatunek_IdGatunku = gt.IdGatunku;
				ksiazkaBindingSource.ResetBindings(false);
				ContextInformation.Instance._context.SaveChanges();
			}

		}
	}
}
