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
	public partial class ElementyZamowieniaControl : UserControl
	{
		public ElementyZamowieniaControl()
		{
			InitializeComponent();
		}

		private void ElementyZamowieniaControl_Load(object sender, EventArgs e)
		{
			Funkcje.Instance._context.ElementyZamowienias.Load();
		}
	}
}
