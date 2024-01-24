namespace diyetApp
{
    partial class Form5
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
            this.geri = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.karbonhidrat = new System.Windows.Forms.TextBox();
            this.besinAdi = new System.Windows.Forms.TextBox();
            this.kaloriMiktari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "DURUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "AÇIKLAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "RANDEVU TARİHİ";
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(613, 417);
            this.geri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(116, 46);
            this.geri.TabIndex = 61;
            this.geri.Text = "geri dön";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(613, 366);
            this.güncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(116, 46);
            this.güncelle.TabIndex = 60;
            this.güncelle.Text = "güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(613, 310);
            this.sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(116, 45);
            this.sil.TabIndex = 59;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(613, 258);
            this.ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(116, 46);
            this.ekle.TabIndex = 58;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // karbonhidrat
            // 
            this.karbonhidrat.Location = new System.Drawing.Point(142, 325);
            this.karbonhidrat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.karbonhidrat.Name = "karbonhidrat";
            this.karbonhidrat.Size = new System.Drawing.Size(362, 20);
            this.karbonhidrat.TabIndex = 57;
            // 
            // besinAdi
            // 
            this.besinAdi.Location = new System.Drawing.Point(142, 280);
            this.besinAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.besinAdi.Name = "besinAdi";
            this.besinAdi.Size = new System.Drawing.Size(362, 20);
            this.besinAdi.TabIndex = 56;
            // 
            // kaloriMiktari
            // 
            this.kaloriMiktari.Location = new System.Drawing.Point(142, 302);
            this.kaloriMiktari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kaloriMiktari.Name = "kaloriMiktari";
            this.kaloriMiktari.Size = new System.Drawing.Size(362, 20);
            this.kaloriMiktari.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 236);
            this.dataGridView1.TabIndex = 54;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.karbonhidrat);
            this.Controls.Add(this.besinAdi);
            this.Controls.Add(this.kaloriMiktari);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox karbonhidrat;
        private System.Windows.Forms.TextBox besinAdi;
        private System.Windows.Forms.TextBox kaloriMiktari;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}