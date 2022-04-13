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
    public partial class FormAlanHesabı : Form
    {
        public FormAlanHesabı()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int kk, uk, sonuc = 0;
            kk = Convert.ToInt32(txt_k.Text);
            uk = Convert.ToInt32(txt_u.Text);

            if (rbtn_alan.Checked)

                sonuc = kk * uk;

            else if (rbtn_cevre.Checked)

                sonuc = 2 * (kk + uk);

            else

                MessageBox.Show("Lütfen Seçim Yapınız");

            lbl_sonuc.Text = " Sonuç " + sonuc;
        }
    }
}
