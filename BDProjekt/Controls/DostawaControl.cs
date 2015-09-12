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
    }
}

