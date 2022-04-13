
namespace FormDersleri_1._2
{
    partial class FormAvg
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
            this.lbl_s1 = new System.Windows.Forms.Label();
            this.lbl_s2 = new System.Windows.Forms.Label();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_islem
            // 
            this.gbox_islem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_islem.Controls.Add(this.btn_hesap);
            this.gbox_islem.Controls.Add(this.lbl_ort);
            this.gbox_islem.Controls.Add(this.txt_s1);
            this.gbox_islem.Controls.Add(this.txt_s2);
            this.gbox_islem.Controls.Add(this.lbl_s2);
            this.gbox_islem.Controls.Add(this.lbl_s1);
            this.gbox_islem.Location = new System.Drawing.Point(0, 1);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(341, 287);
            this.gbox_islem.TabIndex = 0;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İşlem Kaydı";
            // 
            // lbl_s1
            // 
            this.lbl_s1.AutoSize = true;
            this.lbl_s1.Location = new System.Drawing.Point(65, 43);
            this.lbl_s1.Name = "lbl_s1";
            this.lbl_s1.Size = new System.Drawing.Size(44, 15);
            this.lbl_s1.TabIndex = 0;
            this.lbl_s1.Text = "1.Sınav";
            // 
            // lbl_s2
            // 
            this.lbl_s2.AutoSize = true;
            this.lbl_s2.Location = new System.Drawing.Point(65, 103);
            this.lbl_s2.Name = "lbl_s2";
            this.lbl_s2.Size = new System.Drawing.Size(44, 15);
            this.lbl_s2.TabIndex = 1;
            this.lbl_s2.Text = "2.Sınav";
            // 
            // txt_s2
            // 
            this.txt_s2.Location = new System.Drawing.Point(176, 95);
            this.txt_s2.Name = "txt_s2";
            this.txt_s2.Size = new System.Drawing.Size(100, 23);
            this.txt_s2.TabIndex = 2;
            // 
            // txt_s1
            // 
            this.txt_s1.Location = new System.Drawing.Point(176, 35);
            this.txt_s1.Name = "txt_s1";
            this.txt_s1.Size = new System.Drawing.Size(100, 23);
            this.txt_s1.TabIndex = 3;
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(65, 183);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(56, 15);
            this.lbl_ort.TabIndex = 4;
            this.lbl_ort.Text = "Ortalama";
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(187, 145);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(75, 23);
            this.btn_hesap.TabIndex = 5;
            this.btn_hesap.Text = "Hesapla";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // FormAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 282);
            this.Controls.Add(this.gbox_islem);
            this.Name = "FormAvg";
            this.Text = "FormAvg";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_islem;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.Label lbl_s2;
        private System.Windows.Forms.Label lbl_s1;
    }
}