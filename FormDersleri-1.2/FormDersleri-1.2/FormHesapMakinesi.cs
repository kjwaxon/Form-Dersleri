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
    public partial class FormHesapMakinesi : Form
    {
        public FormHesapMakinesi()
        {
            InitializeComponent();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            int n1, n2, sonuc = 0;
            n1 = Convert.ToInt32(txt_n1.Text);
            n2 = Convert.ToInt32(txt_n2.Text);

            if (rbtn_toplama.Checked)

                sonuc = n1 + n2;

            else if (rbtn_cıkarma.Checked)

                sonuc = n1 - n2;

            else if (rbtn_carpma.Checked)

                sonuc = n1 * n2;

            else if (rbtn_bolme.Checked)

                sonuc = n1 / n2;

            else

                MessageBox.Show("Lütfen Seçim Yapınız");

            lbl_result.Text = " Sonuç " + sonuc;
        }

        private void gbox_islemkaydi_Enter(object sender, EventArgs e)
        {

        }
    }
}
