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
    public partial class Oyun : Form
    {
        int satirSayisi=20;
        int sutunSayisi=20;

        public Oyun()
        {
            InitializeComponent();
        }

        public Oyun(int satir,int sutun)
        {
            satirSayisi = satir;
            sutunSayisi = sutun;

            InitializeComponent();

        }

        private void Oyun_Load(object sender, EventArgs e)
        {

            InitTableLayoutPanel(tableLayoutPanel1, satirSayisi, sutunSayisi);

        }



        //tablonun boyutunu değiştirme
        private void InitTableLayoutPanel(TableLayoutPanel TLP, int rows, int cols)
        {
            TLP.RowCount = rows;
            TLP.RowStyles.Clear();
            for (int i = 1; i <= rows; i++)
            {
                TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            }
            TLP.ColumnCount = cols;
            TLP.ColumnStyles.Clear();
            for (int i = 1; i <= cols; i++)
            {
                TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            }
        }
    }
}
