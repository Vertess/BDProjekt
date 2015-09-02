using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProjekt
{
    public partial class GatunekControl : UserControl
    {
        public GatunekControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            gatunekControl1.gatunekBindingSource.ResetBindings(false);
            ContextInformation.Instance._context.SaveChanges();
        }

        private void GatunekControl_Load(object sender, EventArgs e)
        {
            ContextInformation.Instance._context.Gatuneks.Load();
            gatunekBindingSource.DataSource = ContextInformation.Instance._context.Gatuneks.Local.ToBindingList();
        }
    }
}
