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
    public partial class KlientZamowControl : UserControl
    {
        public KlientZamowControl()
        {
            InitializeComponent();
        }

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
    }
}
