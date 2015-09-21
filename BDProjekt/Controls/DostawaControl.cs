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

        private int iddostawy;

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


              /*  elementyDostawyBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();*/

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



                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 10.5F, GraphicsUnit.Pixel);
                }
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
                }
                foreach (DataGridViewColumn c in dataGridView3.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
                }


            }
        }

        private void zaladujElementyDostawy()
        {
            Funkcje.Instance._context.ElementyDostawies.Load();
            elementyDostawyBindingSource.DataSource = Funkcje.Instance._context.ElementyDostawies.Local.ToBindingList().Where(n => (n.IdDostawy == iddostawy));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            try
                {
                    iddostawy = (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDostawyDataGridViewTextBoxColumn"].Value));
                    zatwierdzButton_Click(sender, e);
                    zaladujElementyDostawy();
                    Funkcje.Instance._context.OfertaOferentas.Load();
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
                    row.Cells["tytulColumn"].Value = ((Ksiazka)((((Egzemplarz)row.Cells["egzemplarzColumn"].Value).Ksiazka))).Tytul;
                    row.Cells["wydawnictwoColumn"].Value = ((Wydawnictwo)(((Egzemplarz)row.Cells["egzemplarzColumn"].Value).Wydawnictwo)).NazwaWydawnictwa;
                    row.Cells["okladkaColumn"].Value = ((Egzemplarz)(row.Cells["egzemplarzColumn"].Value)).TypOkladki;
                }
            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells["egzemplarzColumn1"].Value != null)
                {
                    row.Cells["tytulColumn2"].Value = ((Ksiazka)((((Egzemplarz)row.Cells["egzemplarzColumn1"].Value).Ksiazka))).Tytul;
                    row.Cells["wydawnictwoColumn2"].Value = ((Wydawnictwo)(((Egzemplarz)row.Cells["egzemplarzColumn1"].Value).Wydawnictwo)).NazwaWydawnictwa;
                    row.Cells["okladkaColumn2"].Value = ((Egzemplarz)(row.Cells["egzemplarzColumn1"].Value)).TypOkladki;
                }
            }

           

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
                try
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn"].Value) == Convert.ToInt32(row.Cells["idEgzemplarzaDataGridViewTextBoxColumn"].Value))
                            return;

                    }

                    using (var db = new KsiegarniaEntities())
                    {
                        var oferta = new ElementyDostawy
                        {
                            IdDostawy = iddostawy,
                            IdEgzemplarza = (int)dataGridView3.Rows[e.RowIndex].Cells["egzemplarzIdEgzemplarzaDataGridViewTextBoxColumn"].Value,
                            Ilosc = 0
                        };

                        db.ElementyDostawies.Add(oferta);
                        db.SaveChanges();
                        zaladujElementyDostawy();
                        DajNazwy();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    return;
                }
            DajNazwy();
        }



    }
}

