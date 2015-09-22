﻿using System;
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
    public partial class KlientZamowienieControl : UserControl
    {
        public KlientZamowienieControl()
        {
            InitializeComponent();
        }

        private void KlientZamowienieControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.RodzajWysylkis.Load();
                rodzajWysylkiBindingSource.DataSource = Funkcje.Instance._context.RodzajWysylkis.Local.ToBindingList();
                Funkcje.Instance._context.Pracowniks.Load();
                pracownikBindingSource.DataSource = Funkcje.Instance._context.Pracowniks.Local.ToBindingList();
                Funkcje.Instance._context.RealizacjaZamowienias.Load();
                realizacjaZamowieniaBindingSource.DataSource = Funkcje.Instance._context.RealizacjaZamowienias.Local.ToBindingList();
                Funkcje.Instance._context.Rabats.Load();
                rabatBindingSource.DataSource = Funkcje.Instance._context.Rabats.Local.ToBindingList();
                Funkcje.Instance._context.Zamowienies.Load();
                zamowienyBindingSource.DataSource = Funkcje.Instance._context.Zamowienies.Local.ToBindingList().Where(n => n.Klient_IdKlienta == Funkcje.Instance.klient.IdKlienta);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                try
                {
                    dataGridView1.Rows[e.RowIndex].Cells["realizacjaZamowieniaIdRealizacjiDataGridViewTextBoxColumn"].Value = Funkcje.Instance._context.RealizacjaZamowienias.ToList()[1].IdRealizacji;
                    foreach (ElementyZamowienia item in Funkcje.Instance._context.ElementyZamowienias)
                    {
                        if (item.IdZamowienia == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idZamowieniaDataGridViewTextBoxColumn"].Value))
                        {


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
    }
}
