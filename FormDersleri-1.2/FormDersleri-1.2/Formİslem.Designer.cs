
namespace FormDersleri_1._2
{
    partial class Formİslem
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
            this.gbox_islem = new System.Windows.Forms.GroupBox();
            this.lbl_sayı1 = new System.Windows.Forms.Label();
            this.lbl_sayı2 = new System.Windows.Forms.Label();
            this.txt_sayı1 = new System.Windows.Forms.TextBox();
            this.txt_sayı2 = new System.Windows.Forms.TextBox();
            this.lbl_sonuç = new System.Windows.Forms.Label();
            this.txt_sonuç = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_islem
            // 
            this.gbox_islem.BackColor = System.Drawing.Color.Ivory;
            this.gbox_islem.Controls.Add(this.btn_hesapla);
            this.gbox_islem.Controls.Add(this.txt_sonuç);
            this.gbox_islem.Controls.Add(this.lbl_sonuç);
            this.gbox_islem.Controls.Add(this.txt_sayı2);
            this.gbox_islem.Controls.Add(this.txt_sayı1);
            this.gbox_islem.Controls.Add(this.lbl_sayı2);
            this.gbox_islem.Controls.Add(this.lbl_sayı1);
            this.gbox_islem.Location = new System.Drawing.Point(224, 33);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(354, 367);
            this.gbox_islem.TabIndex = 0;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İşlem Kaydı";
            // 
            // lbl_sayı1
            // 
            this.lbl_sayı1.AutoSize = true;
            this.lbl_sayı1.Location = new System.Drawing.Point(31, 42);
            this.lbl_sayı1.Name = "lbl_sayı1";
            this.lbl_sayı1.Size = new System.Drawing.Size(37, 15);
            this.lbl_sayı1.TabIndex = 0;
            this.lbl_sayı1.Text = "Sayı 1";
            // 
            // lbl_sayı2
            // 
            this.lbl_sayı2.AutoSize = true;
            this.lbl_sayı2.Location = new System.Drawing.Point(31, 124);
            this.lbl_sayı2.Name = "lbl_sayı2";
            this.lbl_sayı2.Size = new System.Drawing.Size(37, 15);
            this.lbl_sayı2.TabIndex = 1;
            this.lbl_sayı2.Text = "Sayı 2";
            // 
            // txt_sayı1
            // 
            this.txt_sayı1.Location = new System.Drawing.Point(137, 42);
            this.txt_sayı1.Name = "txt_sayı1";
            this.txt_sayı1.Size = new System.Drawing.Size(100, 23);
            this.txt_sayı1.TabIndex = 2;
            // 
            // txt_sayı2
            // 
            this.txt_sayı2.Location = new System.Drawing.Point(137, 115);
            this.txt_sayı2.Name = "txt_sayı2";
            this.txt_sayı2.Size = new System.Drawing.Size(100, 23);
            this.txt_sayı2.TabIndex = 3;
            // 
            // lbl_sonuç
            // 
            this.lbl_sonuç.AutoSize = true;
            this.lbl_sonuç.Location = new System.Drawing.Point(31, 202);
            this.lbl_sonuç.Name = "lbl_sonuç";
            this.lbl_sonuç.Size = new System.Drawing.Size(40, 15);
            this.lbl_sonuç.TabIndex = 4;
            this.lbl_sonuç.Text = "Sonuç";
            // 
            // txt_sonuç
            // 
            this.txt_sonuç.Location = new System.Drawing.Point(137, 202);
            this.txt_sonuç.Name = "txt_sonuç";
            this.txt_sonuç.Size = new System.Drawing.Size(100, 23);
            this.txt_sonuç.TabIndex = 5;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(137, 293);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // Formİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_islem);
            this.Name = "Formİslem";
            this.Text = "Formİslem";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_islem;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_sonuç;
        private System.Windows.Forms.Label lbl_sonuç;
        private System.Windows.Forms.TextBox txt_sayı2;
        private System.Windows.Forms.TextBox txt_sayı1;
        private System.Windows.Forms.Label lbl_sayı2;
        private System.Windows.Forms.Label lbl_sayı1;
    }
}