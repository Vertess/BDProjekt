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
    public partial class KlientZamowControl : UserControl
    {
        public KlientZamowControl()
        {
            InitializeComponent();
        }

        private int nrZamowienia;

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                using (var db = new KsiegarniaEntities())
                {
                    var zamow = new Zamowieny
                    {
                        KosztZamowienia = 0,
                        Klient_IdKlienta = Funkcje.Instance.klient.IdKlienta,
                        Pracownik_IdPracownika = Funkcje.Instance._context.Pracowniks.FirstOrDefault().IdPracownika,
                        Rabat_IdRabatu = Funkcje.Instance._context.Rabats.FirstOrDefault().IdRabatu,
                        RealizacjaZamowienia_IdRealizacji = Funkcje.Instance._context.RealizacjaZamowienias.FirstOrDefault().IdRealizacji,
                        RodzajuWysylki_IdRodzajWysylki = Funkcje.Instance._context.RodzajWysylkis.FirstOrDefault().IdRodzajWysylki
                    };

                    db.Zamowienies.Add(zamow);
                    db.SaveChanges();
                    KlientZamowControl_Load(sender, e);
                    return;
                }
            }
        }

        private void KlientZamowControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Zamowienies.Load();
                zamowienyBindingSource.DataSource = Funkcje.Instance._context.Zamowienies.Local.ToBindingList().Where(n => n.Klient_IdKlienta == Funkcje.Instance.klient.IdKlienta && n.RealizacjaZamowienia.Equals(Funkcje.Instance._context.RealizacjaZamowienias.FirstOrDefault()));
            }
        }
        private void zaladujElementyZamowienia()
        {

            Funkcje.Instance._context.ElementyZamowienias.Load();
            elementyZamowieniaBindingSource.DataSource = Funkcje.Instance._context.ElementyZamowienias.Local.ToBindingList().Where(n => n.IdZamowienia==nrZamowienia);
            dajNazwy();

        }

        private void dajNazwy()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["egzemplarzDataGridViewTextBoxColumn"].Value != null)
                    {
                        row.Cells["tytulColumn"].Value = ((Ksiazka)((((Egzemplarz)row.Cells["egzemplarzDataGridViewTextBoxColumn"].Value).Ksiazka))).Tytul;
                        row.Cells["wydawnictwoColumn"].Value = ((Wydawnictwo)(((Egzemplarz)row.Cells["egzemplarzDataGridViewTextBoxColumn"].Value).Wydawnictwo)).NazwaWydawnictwa;
                        row.Cells["okladkaColumn"].Value = ((Egzemplarz)(row.Cells["egzemplarzDataGridViewTextBoxColumn"].Value)).TypOkladki;
                    }
                }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells["ksiazkaDataGridViewTextBoxColumn"].Value != null && row.Cells["wydawnictwoDataGridViewTextBoxColumn"].Value != null)
                    {
                        row.Cells["tytulColumn2"].Value = ((Ksiazka)(row.Cells["ksiazkaDataGridViewTextBoxColumn"].Value)).Tytul;
                        row.Cells["wydawnictwoColumn2"].Value = ((Wydawnictwo)row.Cells["wydawnictwoDataGridViewTextBoxColumn"].Value).NazwaWydawnictwa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return;
            }
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                try
                {

                    nrZamowienia = (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idZamowieniaDataGridViewTextBoxColumn"].Value));
                    zaladujElementyZamowienia();
                    Funkcje.Instance._context.Egzemplarzs.Load();
                    egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
                    dajNazwy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    return;
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                try
                {
                    if (!DesignMode)
                    {
                        using (var db = new KsiegarniaEntities())
                        {
                            var element = new ElementyZamowienia
                            {
                                IdEgzemplarza = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["idEgzemplarzaDataGridViewTextBoxColumn1"].Value),
                                IdZamowienia = nrZamowienia,
                                Ilosc = 1
                      
                            };

                            db.ElementyZamowienias.Add(element);
                            db.SaveChanges();
                            zaladujElementyZamowienia();
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    return;
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
