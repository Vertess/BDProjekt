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
                Funkcje.Instance._context.OfertaOferentas.Load();
                ofertaOferentaBindingSource.DataSource = Funkcje.Instance._context.OfertaOferentas.Local.ToBindingList();
            }

        }
    }
}
