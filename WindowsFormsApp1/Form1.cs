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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void btn_OYNA_Click(object sender, EventArgs e)
        {






            int satirSayisi = Convert.ToInt32(numericudSatir.Text);
            int sutunSayisi = Convert.ToInt32(numericudSutun.Text);
            int altinYuzdesi = Convert.ToInt32(numericudAltinYuzde.Text);
            int gizliAltinYuzdesi = Convert.ToInt32(numericudGizliAltinYuzde.Text);
            int hamleSayisi = Convert.ToInt32(nud_AdimSayilari.Text);


            int baslangicAltinSayi = Convert.ToInt32(nud_AltinSayilari.Text);
            int a_Hamle_Maliyet = Convert.ToInt32(nud_A_HamleMaliyet.Text);
            int a_HedefBelirleme_Maliyet = Convert.ToInt32(nud_A_HedefBelirlemeMaliyet.Text);
            int b_Hamle_Maliyet = Convert.ToInt32(nud_B_HamleMaliyet.Text);
            int b_HedefBelirleme_Maliyet = Convert.ToInt32(nud_B_HedefBelirlemeMaliyet.Text);
            int c_Hamle_Maliyet = Convert.ToInt32(nud_C_HamleMaliyet.Text);
            int c_HedefBelirleme_Maliyet = Convert.ToInt32(nud_C_HedefBelirlemeMaliyet.Text);
            int d_Hamle_Maliyet = Convert.ToInt32(nud_D_HamleMaliyet.Text);
            int d_HedefBelirleme_Maliyet = Convert.ToInt32(nud_D_HedefBelirlemeMaliyet.Text);



            Oyun oyun = new Oyun(satirSayisi, sutunSayisi, altinYuzdesi, gizliAltinYuzdesi, baslangicAltinSayi, hamleSayisi,  a_Hamle_Maliyet, a_HedefBelirleme_Maliyet, b_Hamle_Maliyet, b_HedefBelirleme_Maliyet, c_Hamle_Maliyet, c_HedefBelirleme_Maliyet, d_Hamle_Maliyet, d_HedefBelirleme_Maliyet);
            oyun.Show();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
