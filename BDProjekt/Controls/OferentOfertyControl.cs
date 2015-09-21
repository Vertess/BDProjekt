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

    public partial class OferentOfertyControl : UserControl
    {
        public OferentOfertyControl()
        {
            InitializeComponent();
        }

        private void DajNazwy()
        {


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ksiazka"].Value != null)
                {
                    row.Cells["TytulKsiazki"].Value = ((Ksiazka)row.Cells["Ksiazka"].Value).Tytul;
                }
                if (row.Cells["Wydawnictwo"].Value != null)
                {
                    row.Cells["NazwaWydawnictwa"].Value = ((Wydawnictwo)row.Cells["Wydawnictwo"].Value).NazwaWydawnictwa;
                }
                row.Cells["Dodaj"].Value = "Dodaj";
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Egzemplarz"].Value != null)
                {
                    row.Cells["Ksiazka2"].Value = ((Ksiazka)((Egzemplarz)row.Cells["Egzemplarz"].Value).Ksiazka).Tytul;
                    row.Cells["Wydawnictwo2"].Value = ((Wydawnictwo)((Egzemplarz)row.Cells["Egzemplarz"].Value).Wydawnictwo).NazwaWydawnictwa;
                    row.Cells["TypOkladki"].Value = ((Egzemplarz)row.Cells["Egzemplarz"].Value).TypOkladki;
                }
                row.Cells["Usun"].Value = "Usun";
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {

                try
                {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (((Egzemplarz)row.Cells["Egzemplarz"].Value).IdEgzemplarza == (int)dataGridView1.Rows[e.RowIndex].Cells["IdEgzemplarza"].Value)
                        return;
                }
                    using (var db = new KsiegarniaEntities())
                    {
                        Egzemplarz egzemplarz = ((Egzemplarz)egzemplarzBindingSource[0]);
                         var oferta = new OfertaOferenta
                        {
                            CenaHurtowa = 11 , 
                            Egzemplarz_IdEgzemplarza =(int)dataGridView1.Rows[e.RowIndex].Cells["IdEgzemplarza"].Value,
                            Oferent_IdOferenta = db.Oferents.First().IdOferenta
                        };

                        db.OfertaOferentas.Add(oferta);
                        db.SaveChanges();
                        reload(sender, e);
                        return;
                    }
                }
                catch (Exception)
                {
                    return ;
                }
            }

        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
                try
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[e.RowIndex]);
                    reload(sender, e);
                }
                catch (Exception)
                {
                    return;
                }
        }

        private void reload(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList().Where(n => (((Ksiazka)n.Ksiazka).Tytul.Contains(this.textBox2.Text)));

                Funkcje.Instance._context.OfertaOferentas.Load();
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList();
                DajNazwy();

                return;
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
            ofertaOferentaBindingSource.ResetBindings(false);
            Funkcje.Instance._context.SaveChanges();
            reload(sender, e);

                return;
            }
        }

        private void OferentOfertyControl_Load(object sender, EventArgs e)
        {

            dataGridView2.Columns["Ksiazka2"].ValueType = typeof(string);
            dataGridView2.Columns["Wydawnictwo2"].ValueType = typeof(string);
            dataGridView2.Columns["TypOkladki"].ValueType = typeof(bool);
            dataGridView1.Columns["NazwaWydawnictwa"].ValueType = typeof(string);
            dataGridView1.Columns["TytulKsiazki"].ValueType = typeof(string);
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 10.5F, GraphicsUnit.Pixel);
            }
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 10.5F, GraphicsUnit.Pixel);
            }
        }


    }
}
