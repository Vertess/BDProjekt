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
    public partial class RabatControl : UserControl
    {
        public RabatControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                rabatBindingSource.ResetBindings(false);
                ContextInformation.Instance._context.SaveChanges();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = ContextInformation.Instance._context.Rabats.Local.ToBindingList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            rabatBindingSource.DataSource = ContextInformation.Instance._context.Rabats.Local.ToBindingList().Where(n => n.OpisRabatu.Contains(this.searchTextBox.Text));
        }

        private void RabatControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ContextInformation.Instance._context.Rabats.Load();
                rabatBindingSource.DataSource = ContextInformation.Instance._context.Rabats.Local.ToBindingList();
            }
        }
    }
}
