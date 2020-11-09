using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Altin
    {
        public int altinKonumSatir { get; set; }
        public int altinKonumSutun { get; set; }


        List<Tuple<int, int>>  altinKonumList = new List<Tuple<int, int>>();
        Random rnd = new Random();

        public Altin()
        {

        }




        public void tahtaAltinEkle(int tahtaSatir, int tahtaSutun)
        {
            for (int i = 0; i < (tahtaSatir * tahtaSutun) / 5; i++)
            {
                int x = rnd.Next(0, tahtaSatir);
                int y = rnd.Next(0, tahtaSutun);




                if ((x == 0 && y == 0) || (x == tahtaSatir - 1 && y == 0) || (x == 0 && y == tahtaSutun - 1) || (x == tahtaSatir - 1 && y == tahtaSutun - 1))
                {
                    x = rnd.Next(0, tahtaSatir);
                    y = rnd.Next(0, tahtaSutun);

                }
                var tuple = new Tuple<int, int>(x, y);
                altinKonumList.Add(tuple);




            }
        }
    }
}
