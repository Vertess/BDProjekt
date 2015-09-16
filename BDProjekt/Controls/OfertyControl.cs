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
    public partial class OfertyControl : UserControl
    {
        public OfertyControl()
        {
            InitializeComponent();
        }
        

        private void OfertyControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Funkcje.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = Funkcje.Instance._context.Egzemplarzs.Local.ToBindingList();
                Funkcje.Instance._context.Oferents.Load();
                oferentBindingSource.DataSource = Funkcje.Instance._context.Oferents.Local.ToBindingList();
                Funkcje.Instance._context.OfertaOferentas.Load();
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList();
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Egzemplarz eg = new Egzemplarz();
                Oferent of = new Oferent();
                OfertaOferenta oo = new OfertaOferenta();
                eg = (Egzemplarz)egzemplarzBindingSource.Current;
                of = (Oferent)oferentBindingSource.Current;
                oo = (OfertaOferenta)ofertaOferentaBindingSource.Current;
                oo.Oferent_IdOferenta = of.IdOferenta;
                ofertaOferentaBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void searchCenaHurtowaTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchCenaHurtowaButton_Click(object sender, EventArgs e)
        {
            int tmpCenaH = 0;
            if (Int32.TryParse(searchCenaHurtowaTextBox.Text, out tmpCenaH))
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.
                    ToBindingList().Where(c => c.CenaHurtowa.Equals(tmpCenaH));
            else
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList();
        }

        private void resetCenaHurtowaButton_Click(object sender, EventArgs e)
        {
            searchCenaHurtowaTextBox.Text = string.Empty;
        }
    }
}
