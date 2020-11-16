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

        public AOyuncusu()
        {
            hamleMaliyet = 5;
            hedefBelirlemeMaliyet = 10;
        }

        public void enYakinAltin(TableLayoutPanel tableLayoutPanel1, List<Altin> altinliste)
        {


            Control aControl = tableLayoutPanel1.Controls.Find("aOyuncusu", true).FirstOrDefault();

            PictureBox aPCBox = aControl as PictureBox;

            int aOyuncusuX = tableLayoutPanel1.GetRow(aControl);
            int aOyuncusuY = tableLayoutPanel1.GetColumn(aControl);


            var enYakinAltin = altinliste.OrderBy(x => Math.Abs(x.altinKonumSatir - aOyuncusuX) + Math.Abs(+x.altinKonumSutun - aOyuncusuY)).FirstOrDefault();




            Control c1 = tableLayoutPanel1.GetControlFromPosition(enYakinAltin.altinKonumSutun, enYakinAltin.altinKonumSatir);
            PictureBox pc = c1 as PictureBox;
            int altinX = tableLayoutPanel1.GetRow(c1);
            int altinY = tableLayoutPanel1.GetColumn(c1);






            if (tableLayoutPanel1.GetRow(aControl) != altinX || tableLayoutPanel1.GetColumn(aControl) != altinY)
            {
                int i = 1;


                while (tableLayoutPanel1.GetRow(aControl) != altinX && i <= 3)
                {
                    if (tableLayoutPanel1.GetRow(aControl) <= altinX)
                    {
                        if (aOyuncusuX + i == altinX && aOyuncusuY == altinY)
                        {
                            tableLayoutPanel1.Controls.Remove(pc);
                            altinliste.Remove(enYakinAltin);
                        }
                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX + i);
                    }

                    else
                    {
                        if (aOyuncusuX - i == altinX && aOyuncusuY == altinY)
                        {
                            tableLayoutPanel1.Controls.Remove(pc);
                            altinliste.Remove(enYakinAltin);
                        }

                        tableLayoutPanel1.SetRow(aControl, aOyuncusuX - i);
                    }





                    i++;

                }

                if (tableLayoutPanel1.GetRow(aControl) == altinX && i <= 3)
                {
                    int aY = 1;

                    while (tableLayoutPanel1.GetColumn(aControl) != altinY && i <= 3)
                    {


                        if (aOyuncusuY <= altinY)
                        {

                            if (aOyuncusuY + aY == altinY)
                            {
                                tableLayoutPanel1.Controls.Remove(pc);
                                altinliste.Remove(enYakinAltin);
                            }
                            tableLayoutPanel1.SetColumn(aControl, aOyuncusuY + aY);
                        }

                        else
                        {

                            if (aOyuncusuY - aY == altinY)
                            {
                                tableLayoutPanel1.Controls.Remove(pc);
                                altinliste.Remove(enYakinAltin);
                            }
                            tableLayoutPanel1.SetColumn(aControl, aOyuncusuY - aY);
                        }

                        i++;
                        aY++;

                    }


                }




            }
            else
            {
                tableLayoutPanel1.Controls.Remove(pc);
                altinliste.Remove(enYakinAltin);
            }




        }


    }
}
