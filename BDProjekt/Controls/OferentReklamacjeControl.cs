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
    public partial class OferentReklamacjeControl : UserControl
    {
        public OferentReklamacjeControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OferentReklamacjeControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
            }
        }
    }
}
