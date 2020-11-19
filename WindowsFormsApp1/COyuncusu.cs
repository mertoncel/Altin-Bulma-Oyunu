﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class COyuncusu : IOyuncu
    {
        public int hamleMaliyet { get; set; }
        public int hedefBelirlemeMaliyet { get; set; }

        public int harcananAltin { get; set; }

        public Altin hedefAltin { get; set; }

        public COyuncusu()
        {

        }
        public COyuncusu(int HamleMaliyet, int HedefMaliyat)
        {
            hamleMaliyet = HamleMaliyet;
            hedefBelirlemeMaliyet = HedefMaliyat;
            hedefAltin = new Altin();
            hedefAltin.hedefAltinVarMi = true;
        }

        public void enKarliAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste, List<Altin> gizlialtinliste, int cPuan, int adimSayisi)
        {


            Control cControl = tableLayoutPanel1.Controls.Find("cOyuncusu", true).FirstOrDefault();
            PictureBox cPCBox = cControl as PictureBox;

            int cOyuncusuX = tableLayoutPanel1.GetRow(cControl);
            int cOyuncusuY = tableLayoutPanel1.GetColumn(cControl);

            if(gizlialtinliste.Any())
            {
                var enYakinGizliAltin = gizlialtinliste.OrderBy(x => (Math.Abs(x.altinKonumSatir - cOyuncusuX) + Math.Abs(+x.altinKonumSutun - cOyuncusuY))).FirstOrDefault();
                Control ccitem = tableLayoutPanel1.GetControlFromPosition(enYakinGizliAltin.altinKonumSutun, enYakinGizliAltin.altinKonumSatir);
                PictureBox pccitem = ccitem as PictureBox;
                pccitem.Visible = true;
                altinliste.Add(enYakinGizliAltin);
                gizlialtinliste.Remove(enYakinGizliAltin);
            }
            

            var enYakinAltin = altinliste.OrderByDescending(x => x.altinMiktar - (Math.Abs(x.altinKonumSatir - cOyuncusuX) + Math.Abs(+x.altinKonumSutun - cOyuncusuY)) * hamleMaliyet - hedefBelirlemeMaliyet).FirstOrDefault();


            Control c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
            PictureBox pc = c1 as PictureBox;

            hedefAltin.altinKonumSatir = tableLayoutPanel1.GetRow(c1);
            hedefAltin.altinKonumSutun = tableLayoutPanel1.GetColumn(c1);

            //oyuncu hedef belirlediğinde altın kaybeder
            if (hedefAltin.hedefAltinVarMi == true)
                cPuan = cPuan - hedefBelirlemeMaliyet;
            hedefAltin.hedefAltinVarMi = false;




            int i = 1;
            int cX = 1; //b oyuncusunun x yönündeki (row) hareketi
            int cY = 1;  //b oyuncusunun y yönündeki (column) hareketi


            while (tableLayoutPanel1.GetRow(cControl) != hedefAltin.altinKonumSatir && i <= adimSayisi && cPuan > 0)
            {
                if (tableLayoutPanel1.GetRow(cControl) <= hedefAltin.altinKonumSatir)
                {
                    if (cOyuncusuX + cX == hedefAltin.altinKonumSatir && cOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        cPuan = cPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = true;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (cOyuncusuX + cX == item.altinKonumSatir && cOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    cPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetRow(cControl, cOyuncusuX + cX);

                }

                else
                {
                    if (cOyuncusuX - cX == hedefAltin.altinKonumSatir && cOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        cPuan = cPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = true;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (cOyuncusuX - cX == item.altinKonumSatir && cOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    cPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetRow(cControl, cOyuncusuX - cX);

                }
                cX++;
                i++;
            }

            while (tableLayoutPanel1.GetRow(cControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(cControl) != hedefAltin.altinKonumSutun && i <= adimSayisi && cPuan > 0)
            {


                if (cOyuncusuY <= hedefAltin.altinKonumSutun)
                {

                    if (cOyuncusuY + cY == hedefAltin.altinKonumSutun)
                    {
                        cPuan = cPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = true;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (cOyuncusuX == item.altinKonumSatir && cOyuncusuY + cY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }


                    }
                    cPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetColumn(cControl, cOyuncusuY + cY);

                }

                else
                {

                    if (cOyuncusuY - cY == hedefAltin.altinKonumSutun)
                    {
                        cPuan = cPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = true;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (cOyuncusuX == item.altinKonumSatir && cOyuncusuY - cY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    cPuan -= hamleMaliyet;
                    tableLayoutPanel1.SetColumn(cControl, cOyuncusuY - cY);

                }
                i++;
                cY++;
            }
            if (tableLayoutPanel1.GetRow(cControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(cControl) == hedefAltin.altinKonumSutun && cPuan > 0)
            {
                altinliste.Remove(enYakinAltin);
            }

            harcananAltin = cPuan;
        }


    }
}
