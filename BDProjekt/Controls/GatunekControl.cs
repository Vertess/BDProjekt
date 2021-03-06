﻿using System;
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
    public partial class GatunekControl : UserControl
    {
        public GatunekControl()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
              this.gatunekBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }

        }

        private void GatunekControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
               Funkcje.Instance._context.Gatuneks.Load();
               gatunekBindingSource.DataSource = Funkcje.Instance._context.Gatuneks.Local.ToBindingList();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                gatunekBindingSource.ResetBindings(false);
                Funkcje.Instance._context.SaveChanges();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            gatunekBindingSource.DataSource = Funkcje.Instance._context.Gatuneks.Local.ToBindingList().Where(n => n.NazwaGatunku.Contains(this.searchTextBox.Text));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
			gatunekBindingSource.DataSource = Funkcje.Instance._context.Gatuneks.Local.ToBindingList();

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
