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

        private void DostawaControl_Load(object sender, EventArgs e)
        {
            ContextInformation.Instance._context.Dostawas.Load();
            dostawaBindingSource.DataSource = ContextInformation.Instance._context.Dostawas.Local.ToBindingList();
            ContextInformation.Instance._context.Oferents.Load();
            oferentBindingSource.DataSource = ContextInformation.Instance._context.Oferents.Local.ToBindingList();
            ContextInformation.Instance._context.Pracowniks.Load();
            pracownikBindingSource.DataSource = ContextInformation.Instance._context.Pracowniks.Local.ToBindingList();
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
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
            ContextInformation.Instance._context.SaveChanges();
        }
    }
}
