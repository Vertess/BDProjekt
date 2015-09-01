using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BDProjekt
{
    public partial class Form1 : Form
    {
        public static KsiegarniaEntities _context = new KsiegarniaEntities();

        public Form1()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            autorzy1.autorBindingSource.ResetBindings(false);
            gatunekControl1.gatunekBindingSource.ResetBindings(false);

            _context.SaveChanges();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _context.Autors.Load();
            _context.Gatuneks.Load();
            autorzy1.autorBindingSource.DataSource = _context.Autors.Local.ToBindingList();
            gatunekControl1.gatunekBindingSource.DataSource = _context.Gatuneks.Local.ToBindingList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autorzy1.autorBindingSource.DataSource = _context.Autors.Local.ToBindingList().Where(n => n.Imie.Contains(this.textBox1.Text));
        }
    }
}
