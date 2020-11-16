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
        int satirSayisi = 20;
        int sutunSayisi = 20;
        int altinYuzdesi = 10;
        

        List<Altin> altinListe;


        AOyuncusu playerA;



        public Oyun()
        {
            InitializeComponent();

        }

        public Oyun(int satir, int sutun, int altinYuzde)
        {
            satirSayisi = satir;
            sutunSayisi = sutun;
            altinYuzdesi = altinYuzde;
            InitializeComponent();
            InitTableLayoutPanel(tableLayoutPanel1, satirSayisi, sutunSayisi);
            MovePlayers(satirSayisi - 1, sutunSayisi - 1);


        }

         

        private void Oyun_Load(object sender, EventArgs e)
        {


            Altin altin = new Altin();
            altinListe = altin.altinYerleri(satirSayisi, sutunSayisi, altinYuzdesi, tableLayoutPanel1);
            var gizliAltin = altin.gizliAltin(tableLayoutPanel1);

            playerA = new AOyuncusu();


        }



        //dinamik olarak değiştirilebilen tahtada oyuncuların default olan konumlarını değerlere göre değiştirir.
        private void MovePlayers(int satirsayi, int sutunsayi)
        {
            Control playerbControl = tableLayoutPanel1.Controls.Find("bOyuncusu", true).FirstOrDefault();
            Control playercControl = tableLayoutPanel1.Controls.Find("cOyuncusu", true).FirstOrDefault();
            Control playerdControl = tableLayoutPanel1.Controls.Find("dOyuncusu", true).FirstOrDefault();
            tableLayoutPanel1.SetColumn(playerbControl, sutunsayi);
            tableLayoutPanel1.SetRow(playercControl, satirsayi);
            tableLayoutPanel1.SetRow(playerdControl, satirsayi);
            tableLayoutPanel1.SetColumn(playerdControl, sutunsayi);



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

        private void btn_Oyna_Click(object sender, EventArgs e)
        {
            
            playerA.enYakinAltin(tableLayoutPanel1, altinListe);
        }
    }
}
