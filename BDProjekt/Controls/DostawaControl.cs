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
            if (!DesignMode)
            {
                ContextInformation.Instance._context.Dostawas.Load();
                dostawaBindingSource.DataSource = ContextInformation.Instance._context.Dostawas.Local.ToBindingList();
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                dostawaBindingSource.ResetBindings(false);
                ContextInformation.Instance._context.SaveChanges();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
