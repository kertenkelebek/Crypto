namespace proje
{
    partial class girisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanicilabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.kullanicitext = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanicilabel
            // 
            this.kullanicilabel.AutoSize = true;
            this.kullanicilabel.Location = new System.Drawing.Point(30, 44);
            this.kullanicilabel.Name = "kullanicilabel";
            this.kullanicilabel.Size = new System.Drawing.Size(69, 13);
            this.kullanicilabel.TabIndex = 0;
            this.kullanicilabel.Text = "Kullanıcı adı :";
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Location = new System.Drawing.Point(30, 79);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(37, 13);
            this.sifrelabel.TabIndex = 1;
            this.sifrelabel.Text = "Şifre  :";
            // 
            // kullanicitext
            // 
            this.kullanicitext.Location = new System.Drawing.Point(141, 44);
            this.kullanicitext.Name = "kullanicitext";
            this.kullanicitext.Size = new System.Drawing.Size(156, 20);
            this.kullanicitext.TabIndex = 2;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(141, 76);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(156, 20);
            this.sifreText.TabIndex = 3;
            this.sifreText.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kullanicitext);
            this.groupBox1.Controls.Add(this.sifreText);
            this.groupBox1.Controls.Add(this.kullanicilabel);
            this.groupBox1.Controls.Add(this.sifrelabel);
            this.groupBox1.Location = new System.Drawing.Point(31, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili Girişi";
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 279);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "girisForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label kullanicilabel;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.TextBox kullanicitext;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

