using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class BOyuncusu : IOyuncu
    {
        public int hamleMaliyet { get; set; }
        public int hedefBelirlemeMaliyet { get; set; }

        public int kasadakiAltinMiktari { get; set; }

        public int toplamAdim { get; set; }
        public int harcananAltinMiktari { get; set; }
        public int toplananAltin { get; set; }
        public Altin hedefAltin { get; set; }
        public List<string> adimlar { get; set; }

        public BOyuncusu()
        {

        }
        public BOyuncusu(int HamleMaliyet, int HedefMaliyat)
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

        public void enKarliAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste, List<Altin> gizlialtinliste, int bPuan, int adimSayisi)
        {


            Control bControl = tableLayoutPanel1.Controls.Find("bOyuncusu", true).FirstOrDefault();
            PictureBox bPCBox = bControl as PictureBox;

            int bOyuncusuX = tableLayoutPanel1.GetRow(bControl);
            int bOyuncusuY = tableLayoutPanel1.GetColumn(bControl);

            var enYakinAltin = altinliste.OrderByDescending(x => x.altinMiktar - (Math.Abs(x.altinKonumSatir - bOyuncusuX) + Math.Abs(+x.altinKonumSutun - bOyuncusuY)) * hamleMaliyet - hedefBelirlemeMaliyet).FirstOrDefault();
            

            Control c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
            PictureBox pc = c1 as PictureBox;

            hedefAltin.altinKonumSatir = tableLayoutPanel1.GetRow(c1);
            hedefAltin.altinKonumSutun = tableLayoutPanel1.GetColumn(c1);

            //oyuncu hedef belirlediğinde altın kaybeder
            if (hedefAltin.hedefAltinVarMi == false)
            {
                bPuan = bPuan - hedefBelirlemeMaliyet;
                hedefAltin.hedefAltinVarMi = true;
                harcananAltinMiktari += hedefBelirlemeMaliyet;
            }
                




            int i = 1;
            int bX = 1; //b oyuncusunun x yönündeki (row) hareketi
            int bY = 1;  //b oyuncusunun y yönündeki (column) hareketi


            while (tableLayoutPanel1.GetRow(bControl) != hedefAltin.altinKonumSatir && i <= adimSayisi && bPuan > 0)
            {
                if (tableLayoutPanel1.GetRow(bControl) <= hedefAltin.altinKonumSatir)
                {
                    if (bOyuncusuX + bX == hedefAltin.altinKonumSatir && bOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        bPuan = bPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (bOyuncusuX + bX == item.altinKonumSatir && bOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    if(bPuan>hamleMaliyet)
                    {
                        bPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetRow(bControl, bOyuncusuX + bX);
                        adimlar.Add((bOyuncusuX + bX) + " " + bOyuncusuY);

                    }
                    

                }

                else
                {
                    if (bOyuncusuX - bX == hedefAltin.altinKonumSatir && bOyuncusuY == hedefAltin.altinKonumSutun)
                    {
                        bPuan = bPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (bOyuncusuX - bX == item.altinKonumSatir && bOyuncusuY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    if(bPuan>hamleMaliyet)
                    {
                        bPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetRow(bControl, bOyuncusuX - bX);
                        adimlar.Add((bOyuncusuX - bX) + " " + bOyuncusuY);
                    }
                    

                }
                toplamAdim++;
                bX++;
                i++;
            }

            while (tableLayoutPanel1.GetRow(bControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(bControl) != hedefAltin.altinKonumSutun && i <= adimSayisi && bPuan > 0)
            {


                if (bOyuncusuY <= hedefAltin.altinKonumSutun)
                {

                    if (bOyuncusuY + bY == hedefAltin.altinKonumSutun)
                    {
                        bPuan = bPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (bOyuncusuX == item.altinKonumSatir && bOyuncusuY + bY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }


                    }
                    if(bPuan>hamleMaliyet)
                    {
                        bPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetColumn(bControl, bOyuncusuY + bY);
                        adimlar.Add(bOyuncusuX + " " + (bOyuncusuY+bY));
                    }
                    

                }

                else
                {

                    if (bOyuncusuY - bY == hedefAltin.altinKonumSutun)
                    {
                        bPuan = bPuan + enYakinAltin.altinMiktar;
                        tableLayoutPanel1.Controls.Remove(pc);
                        altinliste.Remove(enYakinAltin);
                        hedefAltin.hedefAltinVarMi = false;
                        toplananAltin++;
                    }
                    foreach (Altin item in gizlialtinliste)
                    {
                        Control citem = tableLayoutPanel1.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                        PictureBox pcitem = citem as PictureBox;

                        if (bOyuncusuX == item.altinKonumSatir && bOyuncusuY - bY == item.altinKonumSutun)
                        {
                            pcitem.Visible = true;
                            altinliste.Add(item);
                            gizlialtinliste.Remove(item);
                            break;
                        }

                    }
                    if(bPuan>hamleMaliyet)
                    {
                        bPuan -= hamleMaliyet;
                        harcananAltinMiktari += hamleMaliyet;
                        tableLayoutPanel1.SetColumn(bControl, bOyuncusuY - bY);
                        adimlar.Add(bOyuncusuX + " " + (bOyuncusuY - bY));
                    }
                   

                }
                toplamAdim++;
                i++;
                bY++;
            }
            if (tableLayoutPanel1.GetRow(bControl) == hedefAltin.altinKonumSatir && tableLayoutPanel1.GetColumn(bControl) == hedefAltin.altinKonumSutun && bPuan > 0)
            {
                altinliste.Remove(enYakinAltin);
            }

            kasadakiAltinMiktari = bPuan;
        }


    }
}

