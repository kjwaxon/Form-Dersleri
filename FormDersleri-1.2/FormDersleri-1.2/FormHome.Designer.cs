
namespace FormDersleri_1._2
{
    partial class FormHome
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
            this.btn_form1 = new System.Windows.Forms.Button();
            this.btn_formalan = new System.Windows.Forms.Button();
            this.btn_formislem = new System.Windows.Forms.Button();
            this.gbox_home = new System.Windows.Forms.GroupBox();
            this.btn_hesapmakinesi = new System.Windows.Forms.Button();
            this.btn_avg = new System.Windows.Forms.Button();
            this.gbox_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_form1
            // 
            this.btn_form1.BackColor = System.Drawing.Color.Red;
            this.btn_form1.Location = new System.Drawing.Point(12, 58);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(118, 90);
            this.btn_form1.TabIndex = 0;
            this.btn_form1.Text = "Form1";
            this.btn_form1.UseVisualStyleBackColor = false;
            this.btn_form1.Click += new System.EventHandler(this.btn_form1_Click);
            // 
            // btn_formalan
            // 
            this.btn_formalan.BackColor = System.Drawing.Color.Violet;
            this.btn_formalan.Location = new System.Drawing.Point(164, 59);
            this.btn_formalan.Name = "btn_formalan";
            this.btn_formalan.Size = new System.Drawing.Size(117, 89);
            this.btn_formalan.TabIndex = 1;
            this.btn_formalan.Text = "FormAlanHesabı";
            this.btn_formalan.UseVisualStyleBackColor = false;
            this.btn_formalan.Click += new System.EventHandler(this.btn_formalan_Click);
            // 
            // btn_formislem
            // 
            this.btn_formislem.BackColor = System.Drawing.Color.Yellow;
            this.btn_formislem.Location = new System.Drawing.Point(307, 59);
            this.btn_formislem.Name = "btn_formislem";
            this.btn_formislem.Size = new System.Drawing.Size(129, 90);
            this.btn_formislem.TabIndex = 2;
            this.btn_formislem.Text = "FormIslem";
            this.btn_formislem.UseVisualStyleBackColor = false;
            this.btn_formislem.Click += new System.EventHandler(this.btn_formislem_Click);
            // 
            // gbox_home
            // 
            this.gbox_home.BackColor = System.Drawing.Color.Cyan;
            this.gbox_home.Controls.Add(this.btn_hesapmakinesi);
            this.gbox_home.Controls.Add(this.btn_avg);
            this.gbox_home.Controls.Add(this.btn_form1);
            this.gbox_home.Controls.Add(this.btn_formislem);
            this.gbox_home.Controls.Add(this.btn_formalan);
            this.gbox_home.Location = new System.Drawing.Point(0, 0);
            this.gbox_home.Name = "gbox_home";
            this.gbox_home.Size = new System.Drawing.Size(458, 348);
            this.gbox_home.TabIndex = 3;
            this.gbox_home.TabStop = false;
            this.gbox_home.Text = "Ana Sayfa";
            // 
            // btn_hesapmakinesi
            // 
            this.btn_hesapmakinesi.BackColor = System.Drawing.Color.Lime;
            this.btn_hesapmakinesi.Location = new System.Drawing.Point(55, 196);
            this.btn_hesapmakinesi.Name = "btn_hesapmakinesi";
            this.btn_hesapmakinesi.Size = new System.Drawing.Size(125, 89);
            this.btn_hesapmakinesi.TabIndex = 4;
            this.btn_hesapmakinesi.Text = "FormHesapMakinesi";
            this.btn_hesapmakinesi.UseVisualStyleBackColor = false;
            this.btn_hesapmakinesi.Click += new System.EventHandler(this.btn_hesapmakinesi_Click);
            // 
            // btn_avg
            // 
            this.btn_avg.BackColor = System.Drawing.Color.Magenta;
            this.btn_avg.Location = new System.Drawing.Point(244, 196);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(129, 89);
            this.btn_avg.TabIndex = 3;
            this.btn_avg.Text = "FormOrtalama";
            this.btn_avg.UseVisualStyleBackColor = false;
            this.btn_avg.Click += new System.EventHandler(this.btn_avg_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 347);
            this.Controls.Add(this.gbox_home);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.gbox_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Button btn_formalan;
        private System.Windows.Forms.Button btn_formislem;
        private System.Windows.Forms.GroupBox gbox_home;
        private System.Windows.Forms.Button btn_avg;
        private System.Windows.Forms.Button btn_hesapmakinesi;
    }
}