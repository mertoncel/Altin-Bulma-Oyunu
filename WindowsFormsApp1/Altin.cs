using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Altin
    {
        public int altinKonumSatir { get; set; }
        public int altinKonumSutun { get; set; }

        public int altinMiktar { get; set; }


        List<Altin> altinListe;
        Random rnd = new Random();

        public Altin()
        {

        }




        //altinların konumunu random olarak atama ve ilgili konumlara altin pictureboxu ekleme
        public List<Altin> altinYerleri(int satirSayisi, int sutunSayisi, TableLayoutPanel tableLayoutPanel1)
        {
            altinListe = new List<Altin>();
            int[] b  = { 5,10,15,20};

            

            for (int i = 0; i < (satirSayisi * sutunSayisi) / 5; i++)
            {
                

                int x = rnd.Next(1, satirSayisi);
                int y = rnd.Next(1, sutunSayisi);
                int altinmktr = Convert.ToInt32(b.OrderBy(t => Guid.NewGuid()).First());

                Altin altin = new Altin();
                

                foreach(Altin item in altinListe)
                {
                    if (x == item.altinKonumSatir && y == item.altinKonumSutun)
                    {
                        x = rnd.Next(0, satirSayisi);
                        y = rnd.Next(0, sutunSayisi);
                        altin.altinMiktar = altinmktr;

                    }
                }

                altin.altinKonumSatir = x;
                altin.altinKonumSutun = y;
                altin.altinMiktar = altinmktr;

                altinListe.Add(altin);


                tableLayoutPanel1.Controls.Add(new PictureBox
                {
                    Name = "pct_" + x +"_"+y,
                    Visible = true,
                    Dock = DockStyle.Fill,
                    BackColor = System.Drawing.Color.Yellow
                }, y, x);


            }



            return altinListe;
        }

        public List<Altin> gizliAltin(TableLayoutPanel tableLayoutPanel)
        {
            
            // altin listesini karıştırıp içinden %10 kadar gizli altin seçme.
            List<Altin> gizliAltin = altinListe.OrderBy(x => Guid.NewGuid()).Take(altinListe.Count / 10).ToList();

            //bonus listeyi düzenlemek için 



            Control c = new Control();

            foreach (Altin item in gizliAltin)
            {
                c = tableLayoutPanel.GetControlFromPosition(item.altinKonumSutun, item.altinKonumSatir);
                PictureBox pc = (PictureBox)c;
                //pc.Visible = false;
                pc.BackColor = Color.Red;

            }
            





            return gizliAltin;

        }


    }
}
