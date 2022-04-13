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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btn_form1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

        }

        private void btn_formalan_Click(object sender, EventArgs e)
        {
            FormAlanHesabı frm2 = new FormAlanHesabı();
            frm2.Show();

        }

        private void btn_formislem_Click(object sender, EventArgs e)
        {
            Formİslem frm3 = new Formİslem();
            frm3.Show();
        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            FormAvg frm4 = new FormAvg();
            frm4.Show();
        }

        private void btn_hesapmakinesi_Click(object sender, EventArgs e)
        {
            FormHesapMakinesi frm5 = new FormHesapMakinesi();
            frm5.Show();
        }
    }
}
