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
    public partial class AutorDoKsiazkiControl : UserControl
    {
        public AutorDoKsiazkiControl()
        {
            InitializeComponent();
        }

        int idKsiazki;


        private void AutorDoKsiazkiControl_Load(object sender, EventArgs e)
        {

            if (!DesignMode)
            {
                Funkcje.Instance._context.Ksiazkas.Load();
                ksiazkaBindingSource.DataSource = Funkcje.Instance._context.Ksiazkas.Local.ToBindingList();

                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
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
        private void zaladujAutorow()
        {

            Funkcje.Instance._context.AutorzyKsiazkis.Load();
            autorzyKsiazkiBindingSource.DataSource = Funkcje.Instance._context.AutorzyKsiazkis.Local.ToBindingList().Where(n => (n.IdKsiazka_IdKsiazki == idKsiazki));
            DajNazwy();
        }


        private void DajNazwy()
        {

            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["autorDataGridViewTextBoxColumn"].Value != null)
                    {
                        row.Cells["imieColumn"].Value = ((Autor)(row.Cells["autorDataGridViewTextBoxColumn"].Value)).Imie;
                        row.Cells["NazwiskoColumn"].Value = ((Autor)(row.Cells["autorDataGridViewTextBoxColumn"].Value)).Nazwisko;
                        row.Cells["DataUrodzeniaColumn"].Value = ((Autor)(row.Cells["autorDataGridViewTextBoxColumn"].Value)).DataUrodzenia.Date;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                try
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["idAutoraDataGridViewTextBoxColumn"].Value) == Convert.ToInt32(row.Cells["autorIdAutoraDataGridViewTextBoxColumn"].Value))
                            return;

                    }

                    using (var db = new KsiegarniaEntities())
                    {
                        var autorKsiazki = new AutorzyKsiazki
                        {
                            Autor_IdAutora = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["idAutoraDataGridViewTextBoxColumn"].Value),
                            IdKsiazka_IdKsiazki = idKsiazki
                        };

                        db.AutorzyKsiazkis.Add(autorKsiazki);
                        db.SaveChanges();
                        zaladujAutorow();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                try
                {
                    idKsiazki = (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idKsiazkiDataGridViewTextBoxColumn"].Value));
                    zaladujAutorow();
                    Funkcje.Instance._context.Autors.Load();
                    autorBindingSource.DataSource = Funkcje.Instance._context.Autors.Local.ToBindingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    return;
                }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            autorzyKsiazkiBindingSource.ResetBindings(false);
            Funkcje.Instance._context.SaveChanges();
        }


    }
}
