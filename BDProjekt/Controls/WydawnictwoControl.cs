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
    public partial class WydawnictwoControl : UserControl
    {
        public WydawnictwoControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                wydawnictwoBindingSource.ResetBindings(false);
                ContextInformation.Instance._context.SaveChanges();
            }
        }

        private void WydawnictwoControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ContextInformation.Instance._context.Wydawnictwoes.Load();
                wydawnictwoBindingSource.DataSource = ContextInformation.Instance._context.Wydawnictwoes.Local.ToBindingList();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            wydawnictwoBindingSource.DataSource = ContextInformation.Instance._context.Wydawnictwoes.Local.ToBindingList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           wydawnictwoBindingSource.DataSource = ContextInformation.Instance._context.Wydawnictwoes.Local.ToBindingList().Where(n => n.NazwaWydawnictwa.Contains(this.searchTextBox.Text));
        }
    }
}
