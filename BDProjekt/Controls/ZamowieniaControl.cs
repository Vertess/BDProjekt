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
    public partial class ZamowieniaControl : UserControl
    {
        public ZamowieniaControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
			if (!DesignMode)
			{
				Zamowieny za = new Zamowieny();
				Klient kl = new Klient();
				Pracownik pr = new Pracownik();
				RodzajWysylki ro = new RodzajWysylki();
				Rabat ra = new Rabat();
				RealizacjaZamowienia re = new RealizacjaZamowienia();

				za = (Zamowieny)zamowienyBindingSource.Current;
				kl = (Klient)klientBindingSource.Current;
				pr = (Pracownik)pracownikBindingSource.Current;
				ro = (RodzajWysylki)rodzajWysylkiBindingSource.Current;
				ra = (Rabat)rabatBindingSource.Current;
				re = (RealizacjaZamowienia)realizacjaZamowieniaBindingSource.Current;
				za.Klient_IdKlienta = kl.IdKlienta;
				za.Pracownik_IdPracownika = pr.IdPracownika;
				za.RodzajuWysylki_IdRodzajWysylki = ro.IdRodzajWysylki;
				za.Rabat_IdRabatu = ra.IdRabatu;
				za.RealizacjaZamowienia_IdRealizacji = re.IdRealizacji;
				zamowienyBindingSource.ResetBindings(false);
				Funkcje.Instance._context.SaveChanges();
			}
        }

		private void ZamowieniaControl_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				Funkcje.Instance._context.Zamowienies.Load();
				zamowienyBindingSource.DataSource = Funkcje.Instance._context.Zamowienies.Local.ToBindingList();
				Funkcje.Instance._context.Klients.Load();
				klientBindingSource.DataSource = Funkcje.Instance._context.Klients.Local.ToBindingList();
				
				Funkcje.Instance._context.Pracowniks.Load();
				pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
				
				Funkcje.Instance._context.RodzajWysylkis.Load();
				rodzajWysylkiBindingSource.DataSource = Funkcje.Instance._context.RodzajWysylkis.Local.ToBindingList();
				
				Funkcje.Instance._context.Rabats.Load();
				rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
				
				Funkcje.Instance._context.RealizacjaZamowienias.Load();
				realizacjaZamowieniaBindingSource.DataSource = Funkcje.Instance._context.RealizacjaZamowienias.Local.ToBindingList();

				klientDataGridViewTextBoxColumn.ValueType = typeof(Klient);
				pracownikDataGridViewTextBoxColumn.ValueType = typeof(Pracownik);
				rodzajWysylkiDataGridViewTextBoxColumn.ValueType = typeof(RodzajWysylki);
				rabatDataGridViewTextBoxColumn.ValueType = typeof(Rabat);
				realizacjaZamowieniaDataGridViewTextBoxColumn.ValueType = typeof(RealizacjaZamowienia);
				this.dataGridView1.Columns["pracownikDataGridViewTextBoxColumn"].ReadOnly = false;
				this.dataGridView1.Columns["rabatDataGridViewTextBoxColumn"].ReadOnly = false;
				this.dataGridView1.Columns["realizacjaZamowieniaDataGridViewTextBoxColumn"].ReadOnly = false;
			}
		}

		private void elementyButton_Click(object sender, EventArgs e)
		{
			Zamowieny za = new Zamowieny();
			za = (Zamowieny)zamowienyBindingSource.Current;
			Form form = new Form();
			using(var dlg = new ElementyZamowieniaControl())
			{
				form.Controls.Add(dlg);
				dlg.elementyZamowieniaBindingSource.DataSource = Funkcje.Instance._context.ElementyZamowienias.Local.ToBindingList().Where(el => el.IdZamowienia == za.IdZamowienia);
				form.ShowDialog();
			}

		}
    }
}
