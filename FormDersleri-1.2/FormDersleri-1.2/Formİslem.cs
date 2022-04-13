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
    public partial class Formİslem : Form
    {
        public Formİslem()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txt_sayı1.Text);
            int sayı2 = Convert.ToInt32(txt_sayı2.Text);

            txt_sonuç.Text = (sayı1 * sayı2).ToString();


        }
    }
}
