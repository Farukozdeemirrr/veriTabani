namespace diyetApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(136, 422);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(482, 22);
            this.soyisim.TabIndex = 2;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(136, 506);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(482, 22);
            this.telefon.TabIndex = 3;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(136, 562);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(482, 22);
            this.adres.TabIndex = 4;
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(136, 394);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(482, 22);
            this.isim.TabIndex = 5;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Location = new System.Drawing.Point(136, 450);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(482, 22);
            this.cinsiyet.TabIndex = 6;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(136, 478);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(482, 22);
            this.tarih.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(136, 534);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(482, 22);
            this.email.TabIndex = 8;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(772, 437);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(186, 35);
            this.ekle.TabIndex = 9;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(772, 484);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(186, 36);
            this.sil.TabIndex = 10;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(772, 534);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(186, 44);
            this.güncelle.TabIndex = 11;
            this.güncelle.Text = "güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(12, 26);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(968, 22);
            this.ara.TabIndex = 12;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "SOYİSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "CİNSİYET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "TELEFON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "EMAİL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "ADRES";
            // 
            // anasayfa
            // 
            this.anasayfa.Location = new System.Drawing.Point(772, 388);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(186, 35);
            this.anasayfa.TabIndex = 20;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(992, 599);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox cinsiyet;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button anasayfa;
    }
}

