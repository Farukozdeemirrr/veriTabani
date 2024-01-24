namespace diyetApp
{
    partial class Form4
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
            this.geri = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.karbonhidrat = new System.Windows.Forms.TextBox();
            this.besinAdi = new System.Windows.Forms.TextBox();
            this.kaloriMiktari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.protein = new System.Windows.Forms.TextBox();
            this.yag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(613, 412);
            this.geri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(116, 46);
            this.geri.TabIndex = 46;
            this.geri.Text = "geri dön";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(613, 362);
            this.güncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(116, 46);
            this.güncelle.TabIndex = 43;
            this.güncelle.Text = "güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(613, 305);
            this.sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(116, 45);
            this.sil.TabIndex = 42;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(613, 254);
            this.ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(116, 46);
            this.ekle.TabIndex = 41;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click_1);
            // 
            // karbonhidrat
            // 
            this.karbonhidrat.Location = new System.Drawing.Point(142, 320);
            this.karbonhidrat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.karbonhidrat.Name = "karbonhidrat";
            this.karbonhidrat.Size = new System.Drawing.Size(362, 20);
            this.karbonhidrat.TabIndex = 40;
            // 
            // besinAdi
            // 
            this.besinAdi.Location = new System.Drawing.Point(142, 275);
            this.besinAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.besinAdi.Name = "besinAdi";
            this.besinAdi.Size = new System.Drawing.Size(362, 20);
            this.besinAdi.TabIndex = 39;
            // 
            // kaloriMiktari
            // 
            this.kaloriMiktari.Location = new System.Drawing.Point(142, 297);
            this.kaloriMiktari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kaloriMiktari.Name = "kaloriMiktari";
            this.kaloriMiktari.Size = new System.Drawing.Size(362, 20);
            this.kaloriMiktari.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 236);
            this.dataGridView1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "KARBONHİDRAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "KALORİ MİKTARI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "BESİN ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "PROTEİN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "YAĞ";
            // 
            // protein
            // 
            this.protein.Location = new System.Drawing.Point(142, 340);
            this.protein.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.protein.Name = "protein";
            this.protein.Size = new System.Drawing.Size(362, 20);
            this.protein.TabIndex = 52;
            // 
            // yag
            // 
            this.yag.Location = new System.Drawing.Point(142, 367);
            this.yag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yag.Name = "yag";
            this.yag.Size = new System.Drawing.Size(362, 20);
            this.yag.TabIndex = 53;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.yag);
            this.Controls.Add(this.protein);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox karbonhidrat;
        private System.Windows.Forms.TextBox besinAdi;
        private System.Windows.Forms.TextBox kaloriMiktari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox protein;
        private System.Windows.Forms.TextBox yag;
    }
}