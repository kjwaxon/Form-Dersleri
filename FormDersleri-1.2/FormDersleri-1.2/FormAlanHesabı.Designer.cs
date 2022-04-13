
namespace FormDersleri_1._2
{
    partial class FormAlanHesabı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_u = new System.Windows.Forms.Label();
            this.lbl_k = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_u = new System.Windows.Forms.TextBox();
            this.gbox_ik = new System.Windows.Forms.GroupBox();
            this.rbtn_cevre = new System.Windows.Forms.RadioButton();
            this.rbtn_alan = new System.Windows.Forms.RadioButton();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.gbox_ik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_u
            // 
            this.lbl_u.AutoSize = true;
            this.lbl_u.Location = new System.Drawing.Point(27, 124);
            this.lbl_u.Name = "lbl_u";
            this.lbl_u.Size = new System.Drawing.Size(67, 15);
            this.lbl_u.TabIndex = 0;
            this.lbl_u.Text = "Uzun Kenar";
            // 
            // lbl_k
            // 
            this.lbl_k.AutoSize = true;
            this.lbl_k.Location = new System.Drawing.Point(27, 53);
            this.lbl_k.Name = "lbl_k";
            this.lbl_k.Size = new System.Drawing.Size(61, 15);
            this.lbl_k.TabIndex = 1;
            this.lbl_k.Text = "Kısa Kenar";
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(137, 45);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 23);
            this.txt_k.TabIndex = 2;
            // 
            // txt_u
            // 
            this.txt_u.Location = new System.Drawing.Point(137, 116);
            this.txt_u.Name = "txt_u";
            this.txt_u.Size = new System.Drawing.Size(100, 23);
            this.txt_u.TabIndex = 3;
            // 
            // gbox_ik
            // 
            this.gbox_ik.BackColor = System.Drawing.Color.Honeydew;
            this.gbox_ik.Controls.Add(this.rbtn_cevre);
            this.gbox_ik.Controls.Add(this.rbtn_alan);
            this.gbox_ik.Controls.Add(this.btn_hesapla);
            this.gbox_ik.Controls.Add(this.lbl_sonuc);
            this.gbox_ik.Controls.Add(this.lbl_u);
            this.gbox_ik.Controls.Add(this.txt_k);
            this.gbox_ik.Controls.Add(this.txt_u);
            this.gbox_ik.Controls.Add(this.lbl_k);
            this.gbox_ik.Location = new System.Drawing.Point(171, 52);
            this.gbox_ik.Name = "gbox_ik";
            this.gbox_ik.Size = new System.Drawing.Size(414, 258);
            this.gbox_ik.TabIndex = 4;
            this.gbox_ik.TabStop = false;
            this.gbox_ik.Text = "İşlem Kaydı";
            // 
            // rbtn_cevre
            // 
            this.rbtn_cevre.AutoSize = true;
            this.rbtn_cevre.Location = new System.Drawing.Point(272, 120);
            this.rbtn_cevre.Name = "rbtn_cevre";
            this.rbtn_cevre.Size = new System.Drawing.Size(55, 19);
            this.rbtn_cevre.TabIndex = 7;
            this.rbtn_cevre.TabStop = true;
            this.rbtn_cevre.Text = "Çevre";
            this.rbtn_cevre.UseVisualStyleBackColor = true;
            // 
            // rbtn_alan
            // 
            this.rbtn_alan.AutoSize = true;
            this.rbtn_alan.Location = new System.Drawing.Point(272, 45);
            this.rbtn_alan.Name = "rbtn_alan";
            this.rbtn_alan.Size = new System.Drawing.Size(49, 19);
            this.rbtn_alan.TabIndex = 6;
            this.rbtn_alan.TabStop = true;
            this.rbtn_alan.Text = "Alan";
            this.rbtn_alan.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(137, 169);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(27, 208);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(40, 15);
            this.lbl_sonuc.TabIndex = 4;
            this.lbl_sonuc.Text = "Sonuç";
            // 
            // FormAlanHesabı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_ik);
            this.Name = "FormAlanHesabı";
            this.Text = "FormAlanHesabı";
            this.gbox_ik.ResumeLayout(false);
            this.gbox_ik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_u;
        private System.Windows.Forms.Label lbl_k;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_u;
        private System.Windows.Forms.GroupBox gbox_ik;
        private System.Windows.Forms.RadioButton rbtn_cevre;
        private System.Windows.Forms.RadioButton rbtn_alan;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}