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
    public partial class EgzemplarzControl : UserControl
    {
        public EgzemplarzControl()
        {
            InitializeComponent();
        }

        private void EgzemplarzControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ContextInformation.Instance._context.Wydawnictwoes.Load();
                wydawnictwoBindingSource.DataSource = ContextInformation.Instance._context.Wydawnictwoes.Local.ToBindingList();
                ContextInformation.Instance._context.Egzemplarzs.Load();
                egzemplarzBindingSource.DataSource = ContextInformation.Instance._context.Egzemplarzs.Local.ToBindingList();
                ContextInformation.Instance._context.Ksiazkas.Load();
                ksiazkaBindingSource.DataSource = ContextInformation.Instance._context.Ksiazkas.Local.ToBindingList();
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Ksiazka ks = new Ksiazka();
                Egzemplarz eg = new Egzemplarz();
                Wydawnictwo wd = new Wydawnictwo();
                ks = (Ksiazka)ksiazkaBindingSource.Current;
                eg = (Egzemplarz)egzemplarzBindingSource.Current;
                wd = (Wydawnictwo)wydawnictwoBindingSource.Current;
                eg.Wydawnictwo_IdWydawnictwa = wd.IdWydawnictwa;
                eg.Ksiazka_IdKsiazki = ks.IdKsiazki;
                egzemplarzBindingSource.ResetBindings(false);
                ContextInformation.Instance._context.SaveChanges();
            }
        }

    }
}
