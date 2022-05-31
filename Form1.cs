using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dulceria
{
    public partial class Form1 : Form
    {
        Form FProAlta = new FrmProductoA();
        Form FProvAlta = new FormProvAlta();
        public Form1()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProAlta.ShowDialog();
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FProvAlta.ShowDialog();
        }
    }
}
