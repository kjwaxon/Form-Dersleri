
namespace FormDersleri_1._2
{
    partial class FormHesapMakinesi
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gbox_islemkaydi = new System.Windows.Forms.GroupBox();
            this.rbtn_bolme = new System.Windows.Forms.RadioButton();
            this.rbtn_carpma = new System.Windows.Forms.RadioButton();
            this.rbtn_cıkarma = new System.Windows.Forms.RadioButton();
            this.rbtn_toplama = new System.Windows.Forms.RadioButton();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.gbox_islemkaydi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(19, 51);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(37, 15);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Sayı 1";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(19, 97);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(37, 15);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Sayı 2";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(114, 43);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 23);
            this.txt_n1.TabIndex = 2;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(114, 89);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 23);
            this.txt_n2.TabIndex = 3;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(19, 140);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(40, 15);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "Sonuç";
            // 
            // gbox_islemkaydi
            // 
            this.gbox_islemkaydi.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbox_islemkaydi.Controls.Add(this.rbtn_bolme);
            this.gbox_islemkaydi.Controls.Add(this.rbtn_carpma);
            this.gbox_islemkaydi.Controls.Add(this.rbtn_cıkarma);
            this.gbox_islemkaydi.Controls.Add(this.rbtn_toplama);
            this.gbox_islemkaydi.Controls.Add(this.btn_hesap);
            this.gbox_islemkaydi.Controls.Add(this.lbl_n1);
            this.gbox_islemkaydi.Controls.Add(this.lbl_n2);
            this.gbox_islemkaydi.Controls.Add(this.txt_n2);
            this.gbox_islemkaydi.Controls.Add(this.lbl_result);
            this.gbox_islemkaydi.Controls.Add(this.txt_n1);
            this.gbox_islemkaydi.Location = new System.Drawing.Point(1, 2);
            this.gbox_islemkaydi.Name = "gbox_islemkaydi";
            this.gbox_islemkaydi.Size = new System.Drawing.Size(368, 293);
            this.gbox_islemkaydi.TabIndex = 5;
            this.gbox_islemkaydi.TabStop = false;
            this.gbox_islemkaydi.Text = "İşlem Kaydı";
            this.gbox_islemkaydi.Enter += new System.EventHandler(this.gbox_islemkaydi_Enter);
            // 
            // rbtn_bolme
            // 
            this.rbtn_bolme.AutoSize = true;
            this.rbtn_bolme.Location = new System.Drawing.Point(234, 176);
            this.rbtn_bolme.Name = "rbtn_bolme";
            this.rbtn_bolme.Size = new System.Drawing.Size(59, 19);
            this.rbtn_bolme.TabIndex = 10;
            this.rbtn_bolme.TabStop = true;
            this.rbtn_bolme.Text = "Bölme";
            this.rbtn_bolme.UseVisualStyleBackColor = true;
            // 
            // rbtn_carpma
            // 
            this.rbtn_carpma.AutoSize = true;
            this.rbtn_carpma.Location = new System.Drawing.Point(234, 132);
            this.rbtn_carpma.Name = "rbtn_carpma";
            this.rbtn_carpma.Size = new System.Drawing.Size(67, 19);
            this.rbtn_carpma.TabIndex = 9;
            this.rbtn_carpma.TabStop = true;
            this.rbtn_carpma.Text = "Çarpma";
            this.rbtn_carpma.UseVisualStyleBackColor = true;
            // 
            // rbtn_cıkarma
            // 
            this.rbtn_cıkarma.AutoSize = true;
            this.rbtn_cıkarma.Location = new System.Drawing.Point(234, 89);
            this.rbtn_cıkarma.Name = "rbtn_cıkarma";
            this.rbtn_cıkarma.Size = new System.Drawing.Size(69, 19);
            this.rbtn_cıkarma.TabIndex = 8;
            this.rbtn_cıkarma.TabStop = true;
            this.rbtn_cıkarma.Text = "Çıkarma";
            this.rbtn_cıkarma.UseVisualStyleBackColor = true;
            // 
            // rbtn_toplama
            // 
            this.rbtn_toplama.AutoSize = true;
            this.rbtn_toplama.Location = new System.Drawing.Point(234, 43);
            this.rbtn_toplama.Name = "rbtn_toplama";
            this.rbtn_toplama.Size = new System.Drawing.Size(70, 19);
            this.rbtn_toplama.TabIndex = 7;
            this.rbtn_toplama.TabStop = true;
            this.rbtn_toplama.Text = "Toplama";
            this.rbtn_toplama.UseVisualStyleBackColor = true;
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(123, 195);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(75, 23);
            this.btn_hesap.TabIndex = 6;
            this.btn_hesap.Text = "Hesapla";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // FormHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 275);
            this.Controls.Add(this.gbox_islemkaydi);
            this.Name = "FormHesapMakinesi";
            this.Text = "FormHesapMakinesi";
            this.gbox_islemkaydi.ResumeLayout(false);
            this.gbox_islemkaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox gbox_islemkaydi;
        private System.Windows.Forms.RadioButton rbtn_bolme;
        private System.Windows.Forms.RadioButton rbtn_carpma;
        private System.Windows.Forms.RadioButton rbtn_cıkarma;
        private System.Windows.Forms.RadioButton rbtn_toplama;
        private System.Windows.Forms.Button btn_hesap;
    }
}