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

        public int harcananAltin { get; set; }

        public Altin hedefAltin { get; set; }

        public AOyuncusu()
        {
            
            hedefAltin = new Altin();
            hedefAltin.hedefAltinVarMi = true;
            
            
            
        }
        public AOyuncusu(int HamleMaliyet, int HedefMaliyat)
        {
            hamleMaliyet = HamleMaliyet;
            hedefBelirlemeMaliyet = HedefMaliyat;
            hedefAltin = new Altin();
            hedefAltin.hedefAltinVarMi = true;
        }

        public void enYakinAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste, int aPuan, int adimSayisi)
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

            if (hedefAltin.hedefAltinVarMi == true)
                aPuan = aPuan - hedefBelirlemeMaliyet;
            hedefAltin.hedefAltinVarMi = false;



            if (tableLayoutPanel1.GetRow(aControl) != hedefAltin.altinKonumSatir || tableLayoutPanel1.GetColumn(aControl) != hedefAltin.altinKonumSutun)
            {
                int i = 1;

                

                while (tableLayoutPanel1.GetRow(aControl) != hedefAltin.altinKonumSatir && i <= adimSayisi)
                {
                    if (tableLayoutPanel1.GetRow(aControl) <= hedefAltin.altinKonumSatir)
                    {
                        if (aOyuncusuX + i == hedefAltin.altinKonumSatir && aOyuncusuY == hedefAltin.altinKonumSutun)
                        {
                            aPuan = aPuan + enYakinAltin.altinMiktar;
                            tableLayoutPanel1.Controls.Remove(pc);
                            altinliste.Remove(enYakinAltin);
                            hedefAltin.hedefAltinVarMi = true;



                        }
                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX + i);
                        
                    }

                    else
                    {
                        if (aOyuncusuX - i == hedefAltin.altinKonumSatir && aOyuncusuY == hedefAltin.altinKonumSutun)
                        {
                            aPuan = aPuan + enYakinAltin.altinMiktar;
                            tableLayoutPanel1.Controls.Remove(pc);
                            altinliste.Remove(enYakinAltin);
                            hedefAltin.hedefAltinVarMi = true;

                        }

                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX - i);
                        
                    }





                    i++;

                }

                if (tableLayoutPanel1.GetRow(aControl) == hedefAltin.altinKonumSatir && i <= adimSayisi)
                {
                    int aY = 1;

                    while (tableLayoutPanel1.GetColumn(aControl) != hedefAltin.altinKonumSutun && i <= adimSayisi)
                    {


                        if (aOyuncusuY <= hedefAltin.altinKonumSutun)
                        {

                            if (aOyuncusuY + aY == hedefAltin.altinKonumSutun)
                            {
                                aPuan = aPuan + enYakinAltin.altinMiktar;
                                tableLayoutPanel1.Controls.Remove(pc);
                                altinliste.Remove(enYakinAltin);
                                hedefAltin.hedefAltinVarMi = true;

                            }
                            tableLayoutPanel1.SetColumn(aControl, aOyuncusuY + aY);
                        }

                        else
                        {

                            if (aOyuncusuY - aY == hedefAltin.altinKonumSutun)
                            {
                                aPuan = aPuan + enYakinAltin.altinMiktar;
                                tableLayoutPanel1.Controls.Remove(pc);
                                altinliste.Remove(enYakinAltin);
                                hedefAltin.hedefAltinVarMi = true;

                            }
                            tableLayoutPanel1.SetColumn(aControl, aOyuncusuY - aY);
                        }

                        i++;
                        aY++;

                    }


                }


                harcananAltin= aPuan - hamleMaliyet * (i-1);




            }
            else
            {
                tableLayoutPanel1.Controls.Remove(pc);
                altinliste.Remove(enYakinAltin);
            }




        }


    }
}
