using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AOyuncusu : IOyuncu
    {
        public int hamleMaliyet { get; set; }
        public int hedefBelirlemeMaliyet { get; set; }

        public int kasadakiAltinMiktari { get; set; }
        public int toplamAdim { get; set; }
        public int  harcananAltinMiktari { get; set; }
        public int toplananAltin { get; set; }

        public Altin hedefAltin { get; set; }
        public List<string> adimlar { get; set; }

        public AOyuncusu()
        {
           
        }
        public AOyuncusu(int HamleMaliyet, int HedefMaliyat)
        {
            hamleMaliyet = HamleMaliyet;
            hedefBelirlemeMaliyet = HedefMaliyat;
            toplamAdim = 0;
            harcananAltinMiktari = 0;
            toplananAltin = 0;
            hedefAltin = new Altin();
            hedefAltin.hedefAltinVarMi = false;

            adimlar = new List<string>();
        }

        public void enYakinAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste, List<Altin> gizlialtinliste, int aPuan, int adimSayisi)
        {


            Control aControl = tableLayoutPanel1.Controls.Find("aOyuncusu", true).FirstOrDefault();
            PictureBox aPCBox = aControl as PictureBox;

            int aOyuncusuX = tableLayoutPanel1.GetRow(aControl);
            int aOyuncusuY = tableLayoutPanel1.GetColumn(aControl);

            var enYakinAltin = altinliste.OrderBy(x => Math.Abs(x.altinKonumSatir - aOyuncusuX) + Math.Abs(+x.altinKonumSutun - aOyuncusuY)).FirstOrDefault();

            Control c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
            PictureBox pc = c1 as PictureBox;

            hedefAltin.altinKonumSatir = tableLayoutPanel1.GetRow(c1);
            hedefAltin.altinKonumSutun = tableLayoutPanel1.GetColumn(c1);

            //oyuncu hedef belirlediğinde altın kaybeder
            if (hedefAltin.hedefAltinVarMi)
            {
                aPuan = aPuan - hedefBelirlemeMaliyet;
                hedefAltin.hedefAltinVarMi = true;
                harcananAltinMiktari += hedefBelirlemeMaliyet;
            }
            




            int i = 1;
            int aX = 1; //a oyuncusunun x yönündeki (row) hareketi
            int aY = 1;  //a oyuncusunun y yönündeki (column) hareketi


            while (tableLayoutPanel1.GetRow(aControl) != hedefAltin.altinKonumSatir && i <= adimSayisi && aPuan>0)
            {
                if (tableLayoutPanel1.GetRow(aControl) <= hedefAltin.altinKonumSatir)
                {
                    if (aOyuncusuX + aX == hedefAltin.altinKonumSatir && aOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        aPuan = aPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach(Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (aOyuncusuX + aX == item.altinKonumSatir && aOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }

                    if (aPuan > hamleMaliyet)
                    {
                        aPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX + aX);
                        adimlar.Add((aOyuncusuX + aX) + " " + aOyuncusuY);
                    }

                    
                    
                    
                }

                else
                {
                    if (aOyuncusuX - aX == hedefAltin.altinKonumSatir && aOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        aPuan = aPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (aOyuncusuX - aX == item.altinKonumSatir && aOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }

                    
                    
                    if(aPuan>hamleMaliyet)
                    {
                        aPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX - aX);
                        adimlar.Add((aOyuncusuX - aX )+ " " + aOyuncusuY);
                    }

                    
                    
                }
                toplamAdim++;
                aX++;
                i++;
            }

            while (tableLayoutPanel1.GetRow(aControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(aControl) != hedefAltin.altinKonumSutun && i <= adimSayisi && aPuan > 0)
            {


                if (aOyuncusuY <= hedefAltin.altinKonumSutun)
                {

                    if (aOyuncusuY + aY == hedefAltin.altinKonumSutun)
                    {
                        aPuan = aPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (aOyuncusuX == item.altinKonumSatir && aOyuncusuY +aY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }
                           

                    }

                    if (aPuan > hamleMaliyet)
                    {
                        aPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetColumn(aControl, aOyuncusuY + aY);
                        adimlar.Add(aOyuncusuX+ " " + (aOyuncusuY+aY));
                    }

                    
                    
                }

                else
                {

                    if (aOyuncusuY - aY == hedefAltin.altinKonumSutun)
                    {
                        aPuan = aPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (aOyuncusuX == item.altinKonumSatir && aOyuncusuY - aY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    if (aPuan > hamleMaliyet)
                    {
                        aPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetColumn(aControl, aOyuncusuY - aY);
                        adimlar.Add(aOyuncusuX + " " + (aOyuncusuY - aY));
                    }

                    
                    
                }
                toplamAdim++;
                i++;
                aY++;
            }
            if (tableLayoutPanel1.GetRow(aControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(aControl) == hedefAltin.altinKonumSutun && aPuan > 0)
            {
                altinliste.Remove(enYakinAltin);
            }

            kasadakiAltinMiktari = aPuan;
        }




    }
}
