using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri_1._2
{
    public partial class FormAvg : Form
    {
        public FormAvg()
        {
            InitializeComponent();
        }

        public double ortalamahesapla(double s1,double s2)
        {

            double sonuc = (s1 + s2) / 2 ;
            return sonuc;

        
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_s1.Text);
            double n2 = Convert.ToDouble(txt_s2.Text);

            double ortalama = ortalamahesapla(n1, n2);
            lbl_ort.Text = "Ortalama :" + ortalama.ToString();
        }
    }
}
