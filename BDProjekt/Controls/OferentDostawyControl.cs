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
                Funkcje.Instance._context.Dostawas.Load();
                dostawaBindingSource.DataSource = Funkcje.Instance._context.Dostawas.Local.ToBindingList();
            }
        }

        private void zatwierdzButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                try
                {
                    
                    Funkcje.Instance._context.ElementyDostawies.Load();
                    elementyDostawyBindingSource.DataSource = Funkcje.Instance._context.ElementyDostawies.Local.ToBindingList().Where(n => (n.IdDostawy ==(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDostawyDataGridViewTextBoxColumn"].Value))));                   
                }
                catch (Exception)
                {
                    return;
                }
        }
    }
}
