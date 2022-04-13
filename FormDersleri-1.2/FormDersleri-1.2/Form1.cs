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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text;
            lbl_aktar.Items.Add(ad);
        }

    }
}
