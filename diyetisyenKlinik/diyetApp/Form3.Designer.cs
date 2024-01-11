namespace diyetApp
{
    partial class Form3
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
            this.diyet = new System.Windows.Forms.Button();
            this.randevu = new System.Windows.Forms.Button();
            this.hasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diyet
            // 
            this.diyet.Location = new System.Drawing.Point(188, 310);
            this.diyet.Name = "diyet";
            this.diyet.Size = new System.Drawing.Size(392, 128);
            this.diyet.TabIndex = 14;
            this.diyet.Text = "DİYET";
            this.diyet.UseVisualStyleBackColor = true;
            this.diyet.Click += new System.EventHandler(this.diyet_Click);
            // 
            // randevu
            // 
            this.randevu.Location = new System.Drawing.Point(188, 165);
            this.randevu.Name = "randevu";
            this.randevu.Size = new System.Drawing.Size(392, 127);
            this.randevu.TabIndex = 13;
            this.randevu.Text = "RANDEVU";
            this.randevu.UseVisualStyleBackColor = true;
            this.randevu.Click += new System.EventHandler(this.randevu_Click);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(188, 30);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(392, 129);
            this.hasta.TabIndex = 12;
            this.hasta.Text = "HASTA";
            this.hasta.UseVisualStyleBackColor = true;
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diyet);
            this.Controls.Add(this.randevu);
            this.Controls.Add(this.hasta);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button diyet;
        private System.Windows.Forms.Button randevu;
        private System.Windows.Forms.Button hasta;
    }
}