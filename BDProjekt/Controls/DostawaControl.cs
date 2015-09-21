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
    public partial class DostawaControl : UserControl
    {
        public DostawaControl()
        {
            InitializeComponent();
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Dostawa ds = new Dostawa();
                Oferent of = new Oferent();
                Pracownik pr = new Pracownik();
                ds = (Dostawa)dostawaBindingSource.Current;
                of = (Oferent)oferentBindingSource.Current;
                pr = (Pracownik)pracownikBindingSource.Current;
                ds.Oferent_IdOferenta = of.IdOferenta;
                ds.Pracownik_IdPracownika = pr.IdPracownika;
                dostawaBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void DostawaControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Dostawas.Load();
                dostawaBindingSource.DataSource = Funkcje.Instance._context.Dostawas.Local.ToBindingList();
                Funkcje.Instance._context.Oferents.Load();
                oferentBindingSource.DataSource = Funkcje.Instance._context.Oferents.Local.ToBindingList();
                Funkcje.Instance._context.Pracowniks.Load();
                pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            try
                {

                    zatwierdzButton_Click(sender, e);
                    Funkcje.Instance._context.ElementyDostawies.Load();
                    elementyDostawyBindingSource.DataSource = Funkcje.Instance._context.ElementyDostawies.Local.ToBindingList().Where(n => (n.IdDostawy == (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDostawyDataGridViewTextBoxColumn"].Value))));

                    Funkcje.Instance._context.OfertaOferentas.Load();
                    MessageBox.Show("" + (dataGridView1.Rows[e.RowIndex].Cells["Oferent_IdOferenta"].Value));
                    ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList().Where(n => (n.Oferent_IdOferenta == (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Oferent_IdOferenta"].Value))));
                }
                catch (Exception)
                {
                    return;
                }
            DajNazwy();
        }


        private void DajNazwy()
        {


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["egzemplarzColumn"].Value != null)
                {
                    row.Cells["tytolColumn"].Value = ((Ksiazka)((((Egzemplarz)row.Cells["egzemplarzColumn"].Value).Ksiazka))).Tytul;
                    row.Cells["wydawnictwoColumn"].Value = ((Wydawnictwo)(((Egzemplarz)row.Cells["egzemplarzColumn"].Value).Wydawnictwo)).NazwaWydawnictwa;
                }
            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells["egzemplarzColumn1"].Value != null)
                {
                    row.Cells["tytolColumn2"].Value = ((Ksiazka)((((Egzemplarz)row.Cells["egzemplarzColumn1"].Value).Ksiazka))).Tytul;
                    row.Cells["wydawnictwoColumn2"].Value = ((Wydawnictwo)(((Egzemplarz)row.Cells["egzemplarzColumn1"].Value).Wydawnictwo)).NazwaWydawnictwa;
                }
            }

           

        }


    }
}

