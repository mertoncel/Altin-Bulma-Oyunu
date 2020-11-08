using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OYNA_Click(object sender, EventArgs e)
        {

            
            

            if(!string.IsNullOrEmpty(numericudSatir.Text) && !string.IsNullOrEmpty(numericudSutun.Text))
            {

                int satirSayisi = Convert.ToInt32(numericudSatir.Text);
                int sutunSayisi = Convert.ToInt32(numericudSutun.Text);

                Oyun oyun = new Oyun(satirSayisi, sutunSayisi);
                oyun.Visible = true;
                  
            }
            else
            {
                Oyun oyun1 = new Oyun();
                oyun1.Visible = true;
            }

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
