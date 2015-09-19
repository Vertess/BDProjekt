using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProjekt.Controls
{
    public partial class OferentDostawyControl : UserControl
    {
        public OferentDostawyControl()
        {
            InitializeComponent();
        }

        private void OferentDostawyControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
           //     Funkcje.Instance._context.Dostawas.Load();
             //   dostawaBindingSource.DataSource = Funkcje.Instance._context.Dostawas.Local.ToBindingList();
            }
        }
    }
}
