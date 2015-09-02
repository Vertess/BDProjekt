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

namespace BDProjekt
{

    public partial class Autorzy : UserControl
    {

        public Autorzy()
        {
            InitializeComponent();
        }

        private void Autorzy_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ContextInformation.Instance._context.Autors.Load();
                ContextInformation.Instance._context.Gatuneks.Load();
                autorBindingSource.DataSource = ContextInformation.Instance._context.Autors.Local.ToBindingList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                autorBindingSource.ResetBindings(false);
                ContextInformation.Instance._context.SaveChanges();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            autorBindingSource.DataSource = ContextInformation.Instance._context.Autors.Local.ToBindingList().Where(n => n.Imie.Contains(this.searchTextBox.Text));

        }
    }
}
