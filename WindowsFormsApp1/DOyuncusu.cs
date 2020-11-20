using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DOyuncusu : IOyuncu
    {
        public int hamleMaliyet { get; set; }
        public int hedefBelirlemeMaliyet { get; set; }

        public int harcananAltin { get; set; }

        public Altin hedefAltin { get; set; }

        public DOyuncusu()
        {

        }
        public DOyuncusu(int HamleMaliyet, int HedefMaliyat)
        {
            hamleMaliyet = HamleMaliyet;
            hedefBelirlemeMaliyet = HedefMaliyat;
            hedefAltin = new Altin();
            hedefAltin.hedefAltinVarMi = false;
        }

        public void enKarliAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste, List<Altin> gizlialtinliste, int dPuan, int adimSayisi, AOyuncusu aOyuncusu, BOyuncusu bOyuncusu, COyuncusu cOyuncusu)
        {


            Control dControl = tableLayoutPanel1.Controls.Find("dOyuncusu", true).FirstOrDefault();
            PictureBox dPCBox = dControl as PictureBox;
            

            int dOyuncusuX = tableLayoutPanel1.GetRow(dControl);
            int dOyuncusuY = tableLayoutPanel1.GetColumn(dControl);

            
            var enYakinAltin = altinliste.OrderByDescending(x => x.altinMiktar - (Math.Abs(x.altinKonumSatir - dOyuncusuX) + Math.Abs(+x.altinKonumSutun - dOyuncusuY)) * hamleMaliyet - hedefBelirlemeMaliyet).FirstOrDefault();


            Control c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
            PictureBox pc = c1 as PictureBox;

            hedefAltin.altinKonumSatir = tableLayoutPanel1.GetRow(c1);
            hedefAltin.altinKonumSutun = tableLayoutPanel1.GetColumn(c1);


            #region Önceden Sezme için a,b ve c oyuncularıyla kontrol gerçekleştirme

            Control aControl = tableLayoutPanel1.Controls.Find("aOyuncusu", true).FirstOrDefault();
            Control bControl = tableLayoutPanel1.Controls.Find("bOyuncusu", true).FirstOrDefault();
            Control cControl = tableLayoutPanel1.Controls.Find("cOyuncusu", true).FirstOrDefault();

            int ayakinlik = Math.Abs(tableLayoutPanel1.GetRow(aControl) - hedefAltin.altinKonumSatir) + Math.Abs(tableLayoutPanel1.GetColumn(aControl) - hedefAltin.altinKonumSutun);
            int byakinlik = Math.Abs(tableLayoutPanel1.GetRow(bControl) - hedefAltin.altinKonumSatir) + Math.Abs(tableLayoutPanel1.GetColumn(bControl) - hedefAltin.altinKonumSutun);
            int cyakinlik = Math.Abs(tableLayoutPanel1.GetRow(cControl) - hedefAltin.altinKonumSatir) + Math.Abs(tableLayoutPanel1.GetColumn(cControl) - hedefAltin.altinKonumSutun);
            int dyakinlik = Math.Abs(tableLayoutPanel1.GetRow(dControl) - hedefAltin.altinKonumSatir) + Math.Abs(tableLayoutPanel1.GetColumn(dControl) - hedefAltin.altinKonumSutun);

            bool aHedefAltinaMiGidiyor = aOyuncusu.hedefAltin.altinKonumSatir == hedefAltin.altinKonumSatir && aOyuncusu.hedefAltin.altinKonumSutun == hedefAltin.altinKonumSutun ? true : false;
            bool bHedefAltinaMiGidiyor = bOyuncusu.hedefAltin.altinKonumSatir == hedefAltin.altinKonumSatir && bOyuncusu.hedefAltin.altinKonumSutun == hedefAltin.altinKonumSutun ? true : false;
            bool cHedefAltinaMiGidiyor = cOyuncusu.hedefAltin.altinKonumSatir == hedefAltin.altinKonumSatir && cOyuncusu.hedefAltin.altinKonumSutun == hedefAltin.altinKonumSutun ? true : false;
            

            if ((aHedefAltinaMiGidiyor.Equals(true) && ayakinlik<dyakinlik) || (bHedefAltinaMiGidiyor.Equals(true) && byakinlik < dyakinlik) || (cHedefAltinaMiGidiyor.Equals(true) && cyakinlik < dyakinlik))
            {
                enYakinAltin = altinliste.OrderByDescending(x => x.altinMiktar - (Math.Abs(x.altinKonumSatir - dOyuncusuX) + Math.Abs(+x.altinKonumSutun - dOyuncusuY)) * hamleMaliyet - hedefBelirlemeMaliyet).ElementAt(1);


                c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
                pc = c1 as PictureBox;

                hedefAltin.altinKonumSatir = tableLayoutPanel1.GetRow(c1);
                hedefAltin.altinKonumSutun = tableLayoutPanel1.GetColumn(c1);
            }
                

            #endregion


            //oyuncu hedef belirlediğinde altın kaybeder
            if (hedefAltin.hedefAltinVarMi == false)
                dPuan = dPuan - hedefBelirlemeMaliyet;
            hedefAltin.hedefAltinVarMi = true;






            int i = 1;
            int dX = 1; //b oyuncusunun x yönündeki (row) hareketi
            int dY = 1;  //b oyuncusunun y yönündeki (column) hareketi


            while (tableLayoutPanel1.GetRow(dControl) != hedefAltin.altinKonumSatir && i <= adimSayisi && dPuan > 0)
            {
                if (tableLayoutPanel1.GetRow(dControl) <= hedefAltin.altinKonumSatir)
                {
                    if (dOyuncusuX + dX == hedefAltin.altinKonumSatir && dOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        dPuan = dPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (dOyuncusuX + dX == item.altinKonumSatir && dOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    dPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetRow(dControl, dOyuncusuX + dX);

                }

                else
                {
                    if (dOyuncusuX - dX == hedefAltin.altinKonumSatir && dOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        dPuan = dPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (dOyuncusuX - dX == item.altinKonumSatir && dOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    dPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetRow(dControl, dOyuncusuX - dX);

                }
                dX++;
                i++;
            }

            while (tableLayoutPanel1.GetRow(dControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(dControl) != hedefAltin.altinKonumSutun && i <= adimSayisi && dPuan > 0)
            {


                if (dOyuncusuY <= hedefAltin.altinKonumSutun)
                {

                    if (dOyuncusuY + dY == hedefAltin.altinKonumSutun)
                    {
                        dPuan = dPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (dOyuncusuX == item.altinKonumSatir && dOyuncusuY + dY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }


                    }
                    dPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetColumn(dControl, dOyuncusuY + dY);

                }

                else
                {

                    if (dOyuncusuY - dY == hedefAltin.altinKonumSutun)
                    {
                        dPuan = dPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (dOyuncusuX == item.altinKonumSatir && dOyuncusuY - dY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    dPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetColumn(dControl, dOyuncusuY - dY);

                }
                i++;
                dY++;
            }
            if (tableLayoutPanel1.GetRow(dControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(dControl) == hedefAltin.altinKonumSutun && dPuan > 0)
            {
                altinliste.Remove(enYakinAltin);
            }

            harcananAltin = dPuan;
        }


    }
}

