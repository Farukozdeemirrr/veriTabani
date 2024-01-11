namespace diyetApp
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.TextBox();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.bitis = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.baslangic = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "PROGRAM AÇIKLAMASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "BİTİŞ TARİHİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(94, 18);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(886, 22);
            this.ara.TabIndex = 31;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(796, 483);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(154, 56);
            this.güncelle.TabIndex = 30;
            this.güncelle.Text = "güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(796, 422);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(154, 55);
            this.sil.TabIndex = 29;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(796, 359);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(154, 57);
            this.ekle.TabIndex = 28;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(190, 445);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(482, 22);
            this.aciklama.TabIndex = 25;
            // 
            // bitis
            // 
            this.bitis.Location = new System.Drawing.Point(190, 417);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(482, 22);
            this.bitis.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 290);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "KİŞİ ARA";
            // 
            // baslangic
            // 
            this.baslangic.Location = new System.Drawing.Point(190, 389);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(482, 22);
            this.baslangic.TabIndex = 24;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(796, 545);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(154, 57);
            this.geri.TabIndex = 36;
            this.geri.Text = "geri dön";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 608);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.TextBox bitis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baslangic;
        private System.Windows.Forms.Button geri;
    }
}