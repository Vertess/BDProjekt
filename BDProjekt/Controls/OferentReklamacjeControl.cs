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
    public partial class OferentReklamacjeControl : UserControl
    {
        public OferentReklamacjeControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DesignMode)
                {
                    Funkcje.Instance._context.Reklamacjas.Load();
                    reklamacjaBindingSource.DataSource = Funkcje.Instance._context.Reklamacjas.Local.ToBindingList().Where(n => Funkcje.Instance.oferent.IdOferenta == (Funkcje.Instance._context.Dostawas.Where(i => n.IdTypu == i.IdDostawy).First().Oferent_IdOferenta)); 

                    Funkcje.Instance._context.Dostawas.Load();
                    dostawaBindingSource.DataSource = Funkcje.Instance._context.Dostawas.Local.ToBindingList();
                    Funkcje.Instance._context.RealizacjeReklamacjis.Load();
                    realizacjeReklamacjiBindingSource.DataSource = Funkcje.Instance._context.RealizacjeReklamacjis.Local.ToBindingList();



                    reklamacjaBindingSource.ResetBindings(false);
                    Funkcje.Instance._context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return;
            }

        }

        


    }
}
