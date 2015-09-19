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
                    reklamacjaBindingSource.DataSource = Funkcje.Instance._context.Reklamacjas.Local.ToBindingList();
                    Funkcje.Instance._context.Dostawas.Load();
                    dostawaBindingSource.DataSource = Funkcje.Instance._context.Dostawas.Local.ToBindingList();
                    Funkcje.Instance._context.RealizacjeReklamacjis.Load();
                    realizacjeReklamacjiBindingSource.DataSource = Funkcje.Instance._context.RealizacjeReklamacjis.Local.ToBindingList();

                    

                    RealizacjeReklamacji ks = new RealizacjeReklamacji();
                    Dostawa gt = new Dostawa();
                    Reklamacja re = new Reklamacja();

                    gt = (Dostawa)dostawaBindingSource.Current;
                    ks = (RealizacjeReklamacji)realizacjeReklamacjiBindingSource.Current;
                    re = (Reklamacja)reklamacjaBindingSource.Current;


                    re.RealizacjeReklamacji_IdRealizacji = ks.IdRealizacji;
                    re.IdTypu = gt.IdDostawy;

                    reklamacjaBindingSource.ResetBindings(false);
                    Funkcje.Instance._context.SaveChanges();

                    foreach (DataGridViewRow row in OferentReklamacjeDataGridView.Rows)
                    {
                        if (row.Cells["idTypuDataGridViewTextBoxColumn"].Value != null)
                        {
                            row.Cells["IdDostawy"].Value = row.Cells["idTypuDataGridViewTextBoxColumn"].Value;
                        }
                        if (row.Cells["realizacjeReklamacjiDataGridViewTextBoxColumn"].Value != null)
                        {
                            row.Cells["Realizacja"].Value = ((RealizacjeReklamacji)row.Cells["realizacjeReklamacjiDataGridViewTextBoxColumn"].Value).IdRealizacji;
                        }
                    }
                }

            }
            catch (Exception)
            {

            }

        }


    }
}
