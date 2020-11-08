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
            

            if(!string.IsNullOrEmpty(txt_satirSayisi.Text) && !string.IsNullOrEmpty(txt_sutunSayisi.Text))
            {
                int satirSayisi = Convert.ToInt32(txt_satirSayisi.Text);
                int sutunSayisi = Convert.ToInt32(txt_sutunSayisi.Text);
                Oyun oyun = new Oyun(satirSayisi, sutunSayisi);
                oyun.Visible = true;
            }
            else
            {
                Oyun oyun1 = new Oyun();
                oyun1.Visible = true;
            }

           
            
        }
    }
}
