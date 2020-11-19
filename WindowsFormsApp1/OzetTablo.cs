using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OzetTablo : Form
    {
        public OzetTablo()
        {
            InitializeComponent();
        }

        public OzetTablo(DataGridView dwgtable)
        {
            dgw_ozetTablo.DataSource = dwgtable;
            InitializeComponent();

        }

        private void OzetTablo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
