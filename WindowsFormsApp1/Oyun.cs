using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Oyun : Form
    {
        int satirSayisi, sutunSayisi;
        int altinYuzdesi;
        int gizliAltinYuzdesi;
        int AltinSayisi;
        int adimSayisi;

        AOyuncusu playerA;
        BOyuncusu playerB;
        COyuncusu playerC;
        DOyuncusu playerD;
        int AltinSayisiA, AltinSayisiB, AltinSayisiC, AltinSayisiD;
        int AHamleMaliyet, BHamleMaliyet, CHamleMaliyet, DHamleMaliyet;
        int AHedefBelirlemeMaliyet, BHedefBelirlemeMaliyet, CHedefBelirlemeMaliyet, DHedefBelirlemeMaliyet;


        bool oyunBitti;

        List<Altin> altinListe;
        List<Altin> gizliAltin;





        public Oyun()
        {
            InitializeComponent();

        }



        public Oyun(int satir, int sutun, int altinYuzde, int gizliAltinYuzde, int baslangicAltinSayi, int adimSayi, int AhamleMaliyet, int AhedefBelirlemeMaliyet, int BhamleMaliyet, int BhedefBelirlemeMaliyet, int ChamleMaliyet, int ChedefBelirlemeMaliyet, int DhamleMaliyet, int DhedefBelirlemeMaliyet)
        {
            satirSayisi = satir;
            sutunSayisi = sutun;
            altinYuzdesi = altinYuzde;
            gizliAltinYuzdesi = gizliAltinYuzde;
            AltinSayisi = baslangicAltinSayi;
            adimSayisi = adimSayi;


            AHamleMaliyet = AhamleMaliyet;
            AHedefBelirlemeMaliyet = AhedefBelirlemeMaliyet;
            BHamleMaliyet = BhamleMaliyet;
            BHedefBelirlemeMaliyet = BhedefBelirlemeMaliyet;
            CHamleMaliyet = ChamleMaliyet;
            CHedefBelirlemeMaliyet = ChedefBelirlemeMaliyet;
            DHamleMaliyet = DhamleMaliyet;
            DHedefBelirlemeMaliyet = DhedefBelirlemeMaliyet;

            InitializeComponent();
            tahtaBoyutDegistirme(tableLayoutPanel1, satirSayisi, sutunSayisi);
            oyuncularKonumDegistir(satirSayisi - 1, sutunSayisi - 1);

            oyunBitti = false;


        }



        private void Oyun_Load(object sender, EventArgs e)
        {




            AltinSayisiA = AltinSayisi;
            AltinSayisiB = AltinSayisi;
            AltinSayisiC = AltinSayisi;
            AltinSayisiD = AltinSayisi;


            txt_aPuani.Text = AltinSayisiA.ToString();
            txt_bPuani.Text = AltinSayisiB.ToString();
            txt_cPuani.Text = AltinSayisiC.ToString();
            txt_dPuani.Text = AltinSayisiD.ToString();



            Altin altin = new Altin();
            altinListe = altin.altinYerleri(satirSayisi, sutunSayisi, altinYuzdesi, tableLayoutPanel1);
            gizliAltin = altin.gizliAltin(gizliAltinYuzdesi, tableLayoutPanel1);

            playerA = new AOyuncusu(AHamleMaliyet, AHedefBelirlemeMaliyet);
            playerB = new BOyuncusu(BHamleMaliyet, BHedefBelirlemeMaliyet);
            playerC = new COyuncusu(CHamleMaliyet, CHedefBelirlemeMaliyet);
            playerD = new DOyuncusu(DHamleMaliyet, DHedefBelirlemeMaliyet);


        }



        //dinamik olarak değiştirilebilen tahtada oyuncuların default olan konumlarını değerlere göre değiştirir.
        private void oyuncularKonumDegistir(int satirsayi, int sutunsayi)
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
        private void tahtaBoyutDegistirme(TableLayoutPanel TLP, int rows, int cols)
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



        private void btn_A_Oyna_Click(object sender, EventArgs e)
        {


            if (altinListe.Any() && (AltinSayisiA > AHamleMaliyet || AltinSayisiB > BHamleMaliyet || AltinSayisiC > CHamleMaliyet || AltinSayisiD > DHamleMaliyet))
            {
                if (AltinSayisiA > 0)
                {
                    playerA.enYakinAltin(tableLayoutPanel1, altinListe, gizliAltin, AltinSayisiA, adimSayisi);
                    AltinSayisiA = playerA.kasadakiAltinMiktari;
                    txt_aPuani.Text = AltinSayisiA.ToString();

                }
                else
                {
                    MessageBox.Show("A OYUNCUSU ELENDI", "ALTIN YETERSIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("OYUN BITTI", "OYUN BITTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitti = true;
                oyunbitti();
                adimlariDosyayaYaz();


            }
        }

        private void btn_B_Oyna_Click(object sender, EventArgs e)
        {
            if (altinListe.Any() && (AltinSayisiA > AHamleMaliyet || AltinSayisiB > BHamleMaliyet || AltinSayisiC > CHamleMaliyet || AltinSayisiD > DHamleMaliyet))
            {
                if (AltinSayisiB > 0)
                {
                    playerB.enKarliAltin(tableLayoutPanel1, altinListe, gizliAltin, AltinSayisiB, adimSayisi);
                    AltinSayisiB = playerB.kasadakiAltinMiktari;
                    txt_bPuani.Text = AltinSayisiB.ToString();
                }
                else
                {
                    MessageBox.Show("B OYUNCUSU ELENDI", "ALTIN YETERSIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("OYUN BITTI", "OYUN BITTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitti = true;
                oyunbitti();
                adimlariDosyayaYaz();
            }

        }

        private void btn_C_Oyna_Click(object sender, EventArgs e)
        {
            if (altinListe.Any() && (AltinSayisiA > AHamleMaliyet || AltinSayisiB > BHamleMaliyet || AltinSayisiC > CHamleMaliyet || AltinSayisiD > DHamleMaliyet))
            {
                if (AltinSayisiC > 0)
                {
                    playerC.enKarliAltin(tableLayoutPanel1, altinListe, gizliAltin, AltinSayisiC, adimSayisi);
                    AltinSayisiC = playerC.kasadakiAltinMiktari;
                    txt_cPuani.Text = AltinSayisiC.ToString();
                }
                else
                {
                    MessageBox.Show("C OYUNCUSU ELENDI", "ALTIN YETERSIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("OYUN BITTI", "OYUN BITTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitti = true;
                oyunbitti();
                adimlariDosyayaYaz();

            }

        }

        private void btn_D_Oyna_Click(object sender, EventArgs e)
        {
            if (altinListe.Any() && (AltinSayisiA > AHamleMaliyet || AltinSayisiB > BHamleMaliyet || AltinSayisiC > CHamleMaliyet || AltinSayisiD > DHamleMaliyet))
            {
                if (AltinSayisiD > 0)
                {
                    playerD.enKarliAltin(tableLayoutPanel1, altinListe, gizliAltin, AltinSayisiD, adimSayisi, playerA, playerB, playerC);
                    AltinSayisiD = playerD.kasadakiAltinMiktari;
                    txt_dPuani.Text = AltinSayisiD.ToString();
                }
                else
                {
                    MessageBox.Show("D OYUNCUSU ELENDI", "ALTIN YETERSIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("OYUN BITTI", "OYUN BITTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitti = true;
                oyunbitti();
                adimlariDosyayaYaz();
            }
        }

        public void oyunbitti()
        {
            if (oyunBitti.Equals(true))
            {
                string ozetA = "A oyuncusunun Toplam Adımı:" + playerA.toplamAdim + " Harcadığı Altın Miktarı:" + playerA.harcananAltinMiktari + " Kasadaki Altın Miktarı:" + playerA.kasadakiAltinMiktari + " Topladığı Altın Sayısı:" + playerA.toplananAltin;
                string ozetB = "B oyuncusunun Toplam Adımı:" + playerB.toplamAdim + " Harcadığı Altın Miktarı:" + playerB.harcananAltinMiktari + " Kasadaki Altın Miktarı:" + playerB.kasadakiAltinMiktari + " Topladığı Altın Sayısı:" + playerB.toplananAltin;
                string ozetC = "C oyuncusunun Toplam Adımı:" + playerC.toplamAdim + " Harcadığı Altın Miktarı:" + playerC.harcananAltinMiktari + " Kasadaki Altın Miktarı:" + playerC.kasadakiAltinMiktari + " Topladığı Altın Sayısı:" + playerC.toplananAltin;
                string ozetD = "D oyuncusunun Toplam Adımı:" + playerD.toplamAdim + " Harcadığı Altın Miktarı:" + playerD.harcananAltinMiktari + " Kasadaki Altın Miktarı:" + playerD.kasadakiAltinMiktari + " Topladığı Altın Sayısı:" + playerD.toplananAltin;

                MessageBox.Show(ozetA+Environment.NewLine+ozetB+Environment.NewLine+ozetC+Environment.NewLine+ozetD,"OYUN ÖZETİ",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
        }

        public void adimlariDosyayaYaz()
        {
            File.WriteAllLines("A_Adimlar.txt", playerA.adimlar);
            File.WriteAllLines("B_Adimlar.txt", playerB.adimlar);
            File.WriteAllLines("C_Adimlar.txt", playerC.adimlar);
            File.WriteAllLines("D_Adimlar.txt", playerD.adimlar);

        }

    }



}
