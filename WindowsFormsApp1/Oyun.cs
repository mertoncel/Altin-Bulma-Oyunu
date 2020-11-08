using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        List<PictureBox> altin = new List<PictureBox>();

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
            
            MovePlayers();

            // hücreye  altın ekleme
            tableLayoutPanel1.Controls.Add(new PictureBox { Name = "pct1", Visible = true, Dock = DockStyle.Fill,  BackColor = System.Drawing.Color.Yellow }, 10, 10);


            


           
        }

        

        //dinamik olarak değiştirilebilen tahtada oyuncuların default olan konumlarını değerlere göre değiştirir.
        private void MovePlayers()
        {
            Control playerbControl = tableLayoutPanel1.GetControlFromPosition(19, 0);
            tableLayoutPanel1.SetColumn(playerbControl, sutunSayisi);
            Control playercControl = tableLayoutPanel1.GetControlFromPosition(0, 19);
            tableLayoutPanel1.SetRow(playercControl, satirSayisi);
            Control playerdControl = tableLayoutPanel1.GetControlFromPosition(19, 19);
            tableLayoutPanel1.SetRow(playerdControl, satirSayisi);
            tableLayoutPanel1.SetColumn(playerdControl, sutunSayisi);



        }



        //tablonun boyutunu değiştirme
        private void InitTableLayoutPanel(TableLayoutPanel TLP, int rows, int cols)
        {
            TLP.RowCount = rows;
            TLP.RowStyles.Clear();
            for (int i = 1; i <= rows; i++)
            {
                TLP.RowStyles.Add(new RowStyle(SizeType.Percent,1));
            }
            TLP.ColumnCount = cols;
            TLP.ColumnStyles.Clear();
            for (int i = 1; i <= cols; i++)
            {
                TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,1));
            }
           
        }
    }
}
