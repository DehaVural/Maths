namespace eqweqeq
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.bttnHesap = new System.Windows.Forms.Button();
            this.bttnKaresi = new System.Windows.Forms.Button();
            this.bttnKok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Değeri :";
            // 
            // txtMetin
            // 
            this.txtMetin.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtMetin.ForeColor = System.Drawing.Color.Red;
            this.txtMetin.Location = new System.Drawing.Point(223, 147);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(100, 20);
            this.txtMetin.TabIndex = 1;
            // 
            // bttnHesap
            // 
            this.bttnHesap.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttnHesap.ForeColor = System.Drawing.Color.Red;
            this.bttnHesap.Location = new System.Drawing.Point(329, 121);
            this.bttnHesap.Name = "bttnHesap";
            this.bttnHesap.Size = new System.Drawing.Size(75, 23);
            this.bttnHesap.TabIndex = 2;
            this.bttnHesap.Text = "Hesapla";
            this.bttnHesap.UseVisualStyleBackColor = false;
            this.bttnHesap.Click += new System.EventHandler(this.bttnHesap_Click);
            // 
            // bttnKaresi
            // 
            this.bttnKaresi.BackColor = System.Drawing.Color.Black;
            this.bttnKaresi.ForeColor = System.Drawing.Color.Red;
            this.bttnKaresi.Location = new System.Drawing.Point(329, 177);
            this.bttnKaresi.Name = "bttnKaresi";
            this.bttnKaresi.Size = new System.Drawing.Size(75, 23);
            this.bttnKaresi.TabIndex = 3;
            this.bttnKaresi.Text = "Karesi";
            this.bttnKaresi.UseVisualStyleBackColor = false;
            this.bttnKaresi.Click += new System.EventHandler(this.bttnKaresi_Click);
            // 
            // bttnKok
            // 
            this.bttnKok.BackColor = System.Drawing.Color.Black;
            this.bttnKok.ForeColor = System.Drawing.Color.Red;
            this.bttnKok.Location = new System.Drawing.Point(329, 148);
            this.bttnKok.Name = "bttnKok";
            this.bttnKok.Size = new System.Drawing.Size(75, 23);
            this.bttnKok.TabIndex = 4;
            this.bttnKok.Text = "Kökünü Bul";
            this.bttnKok.UseVisualStyleBackColor = false;
            this.bttnKok.Click += new System.EventHandler(this.bttnKok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnKok);
            this.Controls.Add(this.bttnKaresi);
            this.Controls.Add(this.bttnHesap);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button bttnHesap;
        private System.Windows.Forms.Button bttnKaresi;
        private System.Windows.Forms.Button bttnKok;
    }
}

