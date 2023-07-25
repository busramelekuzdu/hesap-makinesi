namespace hesap_makinesi1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rakam1 = new System.Windows.Forms.Button();
            this.rakam6 = new System.Windows.Forms.Button();
            this.rakam5 = new System.Windows.Forms.Button();
            this.rakam9 = new System.Windows.Forms.Button();
            this.rakam8 = new System.Windows.Forms.Button();
            this.eşittir = new System.Windows.Forms.Button();
            this.rakam0 = new System.Windows.Forms.Button();
            this.bölme = new System.Windows.Forms.Button();
            this.çarpma = new System.Windows.Forms.Button();
            this.çıkartma = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.rakam7 = new System.Windows.Forms.Button();
            this.rakam4 = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.rakam3 = new System.Windows.Forms.Button();
            this.rakam2 = new System.Windows.Forms.Button();
            this.kareHesapla = new System.Windows.Forms.Button();
            this.usHesaplama = new System.Windows.Forms.Button();
            this.kok = new System.Windows.Forms.Button();
            this.gecmis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1
            // 
            this.rakam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1.Location = new System.Drawing.Point(12, 91);
            this.rakam1.Name = "rakam1";
            this.rakam1.Size = new System.Drawing.Size(75, 75);
            this.rakam1.TabIndex = 1;
            this.rakam1.Text = "1";
            this.rakam1.UseVisualStyleBackColor = true;
            this.rakam1.Click += new System.EventHandler(this.rakam1_Click);
            // 
            // rakam6
            // 
            this.rakam6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6.Location = new System.Drawing.Point(174, 172);
            this.rakam6.Name = "rakam6";
            this.rakam6.Size = new System.Drawing.Size(75, 75);
            this.rakam6.TabIndex = 2;
            this.rakam6.Text = "6";
            this.rakam6.UseVisualStyleBackColor = true;
            this.rakam6.Click += new System.EventHandler(this.rakam6_Click);
            // 
            // rakam5
            // 
            this.rakam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5.Location = new System.Drawing.Point(93, 172);
            this.rakam5.Name = "rakam5";
            this.rakam5.Size = new System.Drawing.Size(75, 75);
            this.rakam5.TabIndex = 3;
            this.rakam5.Text = "5";
            this.rakam5.UseVisualStyleBackColor = true;
            this.rakam5.Click += new System.EventHandler(this.rakam5_Click);
            // 
            // rakam9
            // 
            this.rakam9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9.Location = new System.Drawing.Point(174, 253);
            this.rakam9.Name = "rakam9";
            this.rakam9.Size = new System.Drawing.Size(75, 75);
            this.rakam9.TabIndex = 4;
            this.rakam9.Text = "9";
            this.rakam9.UseVisualStyleBackColor = true;
            this.rakam9.Click += new System.EventHandler(this.rakam9_Click);
            // 
            // rakam8
            // 
            this.rakam8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8.Location = new System.Drawing.Point(93, 253);
            this.rakam8.Name = "rakam8";
            this.rakam8.Size = new System.Drawing.Size(75, 75);
            this.rakam8.TabIndex = 5;
            this.rakam8.Text = "8";
            this.rakam8.UseVisualStyleBackColor = true;
            this.rakam8.Click += new System.EventHandler(this.rakam8_Click);
            // 
            // eşittir
            // 
            this.eşittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eşittir.Location = new System.Drawing.Point(174, 334);
            this.eşittir.Name = "eşittir";
            this.eşittir.Size = new System.Drawing.Size(75, 75);
            this.eşittir.TabIndex = 6;
            this.eşittir.Text = "=";
            this.eşittir.UseVisualStyleBackColor = true;
            this.eşittir.Click += new System.EventHandler(this.eşittir_Click);
            // 
            // rakam0
            // 
            this.rakam0.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0.Location = new System.Drawing.Point(93, 334);
            this.rakam0.Name = "rakam0";
            this.rakam0.Size = new System.Drawing.Size(75, 75);
            this.rakam0.TabIndex = 7;
            this.rakam0.Text = "0";
            this.rakam0.UseVisualStyleBackColor = true;
            this.rakam0.Click += new System.EventHandler(this.rakam0_Click);
            // 
            // bölme
            // 
            this.bölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölme.Location = new System.Drawing.Point(251, 334);
            this.bölme.Name = "bölme";
            this.bölme.Size = new System.Drawing.Size(75, 75);
            this.bölme.TabIndex = 8;
            this.bölme.Text = "/";
            this.bölme.UseVisualStyleBackColor = true;
            this.bölme.Click += new System.EventHandler(this.bölme_Click);
            // 
            // çarpma
            // 
            this.çarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çarpma.Location = new System.Drawing.Point(251, 253);
            this.çarpma.Name = "çarpma";
            this.çarpma.Size = new System.Drawing.Size(75, 75);
            this.çarpma.TabIndex = 9;
            this.çarpma.Text = "x";
            this.çarpma.UseVisualStyleBackColor = true;
            this.çarpma.Click += new System.EventHandler(this.çarpma_Click);
            // 
            // çıkartma
            // 
            this.çıkartma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkartma.Location = new System.Drawing.Point(251, 172);
            this.çıkartma.Name = "çıkartma";
            this.çıkartma.Size = new System.Drawing.Size(75, 75);
            this.çıkartma.TabIndex = 10;
            this.çıkartma.Text = "-";
            this.çıkartma.UseVisualStyleBackColor = true;
            this.çıkartma.Click += new System.EventHandler(this.çıkartma_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C.Location = new System.Drawing.Point(12, 334);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 75);
            this.C.TabIndex = 11;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // rakam7
            // 
            this.rakam7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7.Location = new System.Drawing.Point(12, 253);
            this.rakam7.Name = "rakam7";
            this.rakam7.Size = new System.Drawing.Size(75, 75);
            this.rakam7.TabIndex = 12;
            this.rakam7.Text = "7";
            this.rakam7.UseVisualStyleBackColor = true;
            this.rakam7.Click += new System.EventHandler(this.rakam7_Click);
            // 
            // rakam4
            // 
            this.rakam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4.Location = new System.Drawing.Point(12, 172);
            this.rakam4.Name = "rakam4";
            this.rakam4.Size = new System.Drawing.Size(75, 75);
            this.rakam4.TabIndex = 13;
            this.rakam4.Text = "4";
            this.rakam4.UseVisualStyleBackColor = true;
            this.rakam4.Click += new System.EventHandler(this.rakam4_Click);
            // 
            // toplama
            // 
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(251, 91);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(75, 75);
            this.toplama.TabIndex = 14;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // rakam3
            // 
            this.rakam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3.Location = new System.Drawing.Point(174, 91);
            this.rakam3.Name = "rakam3";
            this.rakam3.Size = new System.Drawing.Size(75, 75);
            this.rakam3.TabIndex = 15;
            this.rakam3.Text = "3";
            this.rakam3.UseVisualStyleBackColor = true;
            this.rakam3.Click += new System.EventHandler(this.rakam3_Click);
            // 
            // rakam2
            // 
            this.rakam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2.Location = new System.Drawing.Point(93, 91);
            this.rakam2.Name = "rakam2";
            this.rakam2.Size = new System.Drawing.Size(75, 75);
            this.rakam2.TabIndex = 16;
            this.rakam2.Text = "2";
            this.rakam2.UseVisualStyleBackColor = true;
            this.rakam2.Click += new System.EventHandler(this.rakam2_Click);
            // 
            // kareHesapla
            // 
            this.kareHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kareHesapla.Location = new System.Drawing.Point(12, 415);
            this.kareHesapla.Name = "kareHesapla";
            this.kareHesapla.Size = new System.Drawing.Size(75, 75);
            this.kareHesapla.TabIndex = 17;
            this.kareHesapla.Text = "n2";
            this.kareHesapla.UseVisualStyleBackColor = true;
            this.kareHesapla.Click += new System.EventHandler(this.kareHesapla_Click);
            // 
            // usHesaplama
            // 
            this.usHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usHesaplama.Location = new System.Drawing.Point(93, 415);
            this.usHesaplama.Name = "usHesaplama";
            this.usHesaplama.Size = new System.Drawing.Size(75, 75);
            this.usHesaplama.TabIndex = 18;
            this.usHesaplama.Text = "üs";
            this.usHesaplama.UseVisualStyleBackColor = true;
            this.usHesaplama.Click += new System.EventHandler(this.usHesaplama_Click);
            // 
            // kok
            // 
            this.kok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kok.Location = new System.Drawing.Point(174, 415);
            this.kok.Name = "kok";
            this.kok.Size = new System.Drawing.Size(75, 75);
            this.kok.TabIndex = 19;
            this.kok.Text = "kök";
            this.kok.UseVisualStyleBackColor = true;
            this.kok.Click += new System.EventHandler(this.kok_Click);
            // 
            // gecmis
            // 
            this.gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gecmis.Location = new System.Drawing.Point(251, 415);
            this.gecmis.Name = "gecmis";
            this.gecmis.Size = new System.Drawing.Size(75, 75);
            this.gecmis.TabIndex = 20;
            this.gecmis.Text = "G";
            this.gecmis.UseVisualStyleBackColor = true;
            this.gecmis.Click += new System.EventHandler(this.gecmis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 495);
            this.Controls.Add(this.gecmis);
            this.Controls.Add(this.kok);
            this.Controls.Add(this.usHesaplama);
            this.Controls.Add(this.kareHesapla);
            this.Controls.Add(this.rakam2);
            this.Controls.Add(this.rakam3);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.rakam4);
            this.Controls.Add(this.rakam7);
            this.Controls.Add(this.C);
            this.Controls.Add(this.çıkartma);
            this.Controls.Add(this.çarpma);
            this.Controls.Add(this.bölme);
            this.Controls.Add(this.rakam0);
            this.Controls.Add(this.eşittir);
            this.Controls.Add(this.rakam8);
            this.Controls.Add(this.rakam9);
            this.Controls.Add(this.rakam5);
            this.Controls.Add(this.rakam6);
            this.Controls.Add(this.rakam1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rakam1;
        private System.Windows.Forms.Button rakam6;
        private System.Windows.Forms.Button rakam5;
        private System.Windows.Forms.Button rakam9;
        private System.Windows.Forms.Button rakam8;
        private System.Windows.Forms.Button eşittir;
        private System.Windows.Forms.Button rakam0;
        private System.Windows.Forms.Button bölme;
        private System.Windows.Forms.Button çarpma;
        private System.Windows.Forms.Button çıkartma;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button rakam7;
        private System.Windows.Forms.Button rakam4;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button rakam3;
        private System.Windows.Forms.Button rakam2;
        private System.Windows.Forms.Button kareHesapla;
        private System.Windows.Forms.Button usHesaplama;
        private System.Windows.Forms.Button kok;
        private System.Windows.Forms.Button gecmis;
    }
}

