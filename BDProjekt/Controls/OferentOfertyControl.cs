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




        private void OferentOfertyControl_Load(object sender, EventArgs e)
        {
            
            using (var db = new KsiegarniaEntities())
            {
                try
                {
                    var oferty = from b in db.OfertaOferentas
                                  select b;

                }
                catch (Exception)
                {
                    return ;
                }
            }

            if (!DesignMode)
            {
                Funkcje.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
                dataGridView1.Columns["NazwaWydawnictwa"].ValueType = typeof(string);
                dataGridView1.Columns["TytolKsiazki"].ValueType = typeof(string);

                Funkcje.Instance._context.OfertaOferentas.Load();
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList();
                dataGridView2.Columns["Ksiazka2"].ValueType = typeof(string);
                dataGridView2.Columns["Wydawnictwo2"].ValueType = typeof(string);
                dataGridView2.Columns["TypOkladki"].ValueType = typeof(bool);


                    return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ksiazka"].Value != null)
                {
                    row.Cells["TytolKsiazki"].Value = ((Ksiazka)row.Cells["Ksiazka"].Value).Tytul;
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
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                try
                {
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
                    }
                }
                catch (Exception ex)
                {
                    textBox1.Text = ex.ToString();
                    return ;
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            OferentOfertyControl_Load(sender, e);
        }

 

    }
}
