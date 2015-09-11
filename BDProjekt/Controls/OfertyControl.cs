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
                ContextInformation.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = ContextInformation.Instance._context.Egzemplarzs.Local.ToBindingList();
                ContextInformation.Instance._context.Oferents.Load();
                oferentBindingSource.DataSource = ContextInformation.Instance._context.Oferents.Local.ToBindingList();
                ContextInformation.Instance._context.OfertaOferentas.Load();
                ofertaOferentaBindingSource.DataSource = ContextInformation.Instance._context.OfertaOferentas.Local.ToBindingList();
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
                ContextInformation.Instance._context.SaveChanges();
            }
        }
    }
}
