namespace KitapOtomasyonu
{
    partial class form_KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_KitapEkle));
            this.lbl_kitapadi = new System.Windows.Forms.Label();
            this.lbl_kitapturu = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.lbl_yayinevi = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.txtB_kitapadi = new System.Windows.Forms.TextBox();
            this.txtB_yazar = new System.Windows.Forms.TextBox();
            this.txtB_Yayinevi = new System.Windows.Forms.TextBox();
            this.txtB_fiyat = new System.Windows.Forms.TextBox();
            this.rtxtB_aciklama = new System.Windows.Forms.RichTextBox();
            this.cmbB_kitapturu = new System.Windows.Forms.ComboBox();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.lbl_yayinyili = new System.Windows.Forms.Label();
            this.txtB_yayinyili = new System.Windows.Forms.TextBox();
            this.lblB_ornekfiyat = new System.Windows.Forms.Label();
            this.lblB_ornekyayinyili = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.txtB_adet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_kitapadi
            // 
            this.lbl_kitapadi.AutoSize = true;
            this.lbl_kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kitapadi.Location = new System.Drawing.Point(62, 49);
            this.lbl_kitapadi.Name = "lbl_kitapadi";
            this.lbl_kitapadi.Size = new System.Drawing.Size(89, 17);
            this.lbl_kitapadi.TabIndex = 0;
            this.lbl_kitapadi.Text = "*Kitap Adı :";
            this.lbl_kitapadi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kitapturu
            // 
            this.lbl_kitapturu.AutoSize = true;
            this.lbl_kitapturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kitapturu.Location = new System.Drawing.Point(57, 84);
            this.lbl_kitapturu.Name = "lbl_kitapturu";
            this.lbl_kitapturu.Size = new System.Drawing.Size(94, 17);
            this.lbl_kitapturu.TabIndex = 0;
            this.lbl_kitapturu.Text = "Kitap Türü :";
            this.lbl_kitapturu.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yazar.Location = new System.Drawing.Point(91, 116);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(60, 17);
            this.lbl_yazar.TabIndex = 0;
            this.lbl_yazar.Text = "Yazar :";
            this.lbl_yazar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_yayinevi
            // 
            this.lbl_yayinevi.AutoSize = true;
            this.lbl_yayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yayinevi.Location = new System.Drawing.Point(72, 148);
            this.lbl_yayinevi.Name = "lbl_yayinevi";
            this.lbl_yayinevi.Size = new System.Drawing.Size(79, 17);
            this.lbl_yayinevi.TabIndex = 0;
            this.lbl_yayinevi.Text = "Yayınevi :";
            this.lbl_yayinevi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fiyat.Location = new System.Drawing.Point(98, 182);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(53, 17);
            this.lbl_fiyat.TabIndex = 0;
            this.lbl_fiyat.Text = "Fiyat :";
            this.lbl_fiyat.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aciklama.Location = new System.Drawing.Point(69, 258);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(82, 17);
            this.lbl_aciklama.TabIndex = 0;
            this.lbl_aciklama.Text = "Açıklama :";
            this.lbl_aciklama.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.Location = new System.Drawing.Point(115, 9);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(131, 20);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Yeni Kitap Ekle";
            this.lbl_baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtB_kitapadi
            // 
            this.txtB_kitapadi.Location = new System.Drawing.Point(165, 47);
            this.txtB_kitapadi.Name = "txtB_kitapadi";
            this.txtB_kitapadi.Size = new System.Drawing.Size(119, 21);
            this.txtB_kitapadi.TabIndex = 1;
            this.txtB_kitapadi.TextChanged += new System.EventHandler(this.txtB_kitapadi_TextChanged);
            // 
            // txtB_yazar
            // 
            this.txtB_yazar.Location = new System.Drawing.Point(165, 114);
            this.txtB_yazar.Name = "txtB_yazar";
            this.txtB_yazar.Size = new System.Drawing.Size(119, 21);
            this.txtB_yazar.TabIndex = 1;
            // 
            // txtB_Yayinevi
            // 
            this.txtB_Yayinevi.Location = new System.Drawing.Point(165, 146);
            this.txtB_Yayinevi.Name = "txtB_Yayinevi";
            this.txtB_Yayinevi.Size = new System.Drawing.Size(119, 21);
            this.txtB_Yayinevi.TabIndex = 1;
            // 
            // txtB_fiyat
            // 
            this.txtB_fiyat.Location = new System.Drawing.Point(165, 180);
            this.txtB_fiyat.Name = "txtB_fiyat";
            this.txtB_fiyat.Size = new System.Drawing.Size(119, 21);
            this.txtB_fiyat.TabIndex = 1;
            // 
            // rtxtB_aciklama
            // 
            this.rtxtB_aciklama.Location = new System.Drawing.Point(165, 256);
            this.rtxtB_aciklama.Name = "rtxtB_aciklama";
            this.rtxtB_aciklama.Size = new System.Drawing.Size(187, 91);
            this.rtxtB_aciklama.TabIndex = 2;
            this.rtxtB_aciklama.Text = "";
            this.rtxtB_aciklama.TextChanged += new System.EventHandler(this.rtxtB_aciklama_TextChanged);
            // 
            // cmbB_kitapturu
            // 
            this.cmbB_kitapturu.FormattingEnabled = true;
            this.cmbB_kitapturu.Location = new System.Drawing.Point(165, 82);
            this.cmbB_kitapturu.Name = "cmbB_kitapturu";
            this.cmbB_kitapturu.Size = new System.Drawing.Size(137, 23);
            this.cmbB_kitapturu.TabIndex = 3;
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_kitapekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitapekle.Location = new System.Drawing.Point(44, 407);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(127, 55);
            this.btn_kitapekle.TabIndex = 5;
            this.btn_kitapekle.Text = "KİTAP EKLE";
            this.btn_kitapekle.UseVisualStyleBackColor = false;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.Location = new System.Drawing.Point(199, 407);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(120, 55);
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // lbl_yayinyili
            // 
            this.lbl_yayinyili.AutoSize = true;
            this.lbl_yayinyili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yayinyili.Location = new System.Drawing.Point(70, 218);
            this.lbl_yayinyili.Name = "lbl_yayinyili";
            this.lbl_yayinyili.Size = new System.Drawing.Size(81, 16);
            this.lbl_yayinyili.TabIndex = 6;
            this.lbl_yayinyili.Text = "Yayın Yılı :";
            // 
            // txtB_yayinyili
            // 
            this.txtB_yayinyili.Location = new System.Drawing.Point(165, 215);
            this.txtB_yayinyili.Name = "txtB_yayinyili";
            this.txtB_yayinyili.Size = new System.Drawing.Size(119, 21);
            this.txtB_yayinyili.TabIndex = 7;
            // 
            // lblB_ornekfiyat
            // 
            this.lblB_ornekfiyat.AutoSize = true;
            this.lblB_ornekfiyat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblB_ornekfiyat.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_ornekfiyat.Location = new System.Drawing.Point(286, 184);
            this.lblB_ornekfiyat.Name = "lblB_ornekfiyat";
            this.lblB_ornekfiyat.Size = new System.Drawing.Size(66, 16);
            this.lblB_ornekfiyat.TabIndex = 8;
            this.lblB_ornekfiyat.Text = "(ÖR : 49.99)";
            // 
            // lblB_ornekyayinyili
            // 
            this.lblB_ornekyayinyili.AutoSize = true;
            this.lblB_ornekyayinyili.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblB_ornekyayinyili.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblB_ornekyayinyili.Location = new System.Drawing.Point(286, 219);
            this.lblB_ornekyayinyili.Name = "lblB_ornekyayinyili";
            this.lblB_ornekyayinyili.Size = new System.Drawing.Size(61, 16);
            this.lblB_ornekyayinyili.TabIndex = 9;
            this.lblB_ornekyayinyili.Text = "(ÖR : 1987)";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adet.Location = new System.Drawing.Point(100, 370);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(51, 18);
            this.lbl_adet.TabIndex = 10;
            this.lbl_adet.Text = "Adet :";
            // 
            // txtB_adet
            // 
            this.txtB_adet.Location = new System.Drawing.Point(165, 367);
            this.txtB_adet.Name = "txtB_adet";
            this.txtB_adet.Size = new System.Drawing.Size(119, 21);
            this.txtB_adet.TabIndex = 11;
            // 
            // form_KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(407, 474);
            this.Controls.Add(this.txtB_adet);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.lblB_ornekyayinyili);
            this.Controls.Add(this.lblB_ornekfiyat);
            this.Controls.Add(this.txtB_yayinyili);
            this.Controls.Add(this.lbl_yayinyili);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kitapekle);
            this.Controls.Add(this.cmbB_kitapturu);
            this.Controls.Add(this.rtxtB_aciklama);
            this.Controls.Add(this.txtB_fiyat);
            this.Controls.Add(this.txtB_Yayinevi);
            this.Controls.Add(this.txtB_yazar);
            this.Controls.Add(this.txtB_kitapadi);
            this.Controls.Add(this.lbl_aciklama);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_yayinevi);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_kitapturu);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.lbl_kitapadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kitapadi;
        private System.Windows.Forms.Label lbl_kitapturu;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Label lbl_yayinevi;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.TextBox txtB_kitapadi;
        private System.Windows.Forms.TextBox txtB_yazar;
        private System.Windows.Forms.TextBox txtB_Yayinevi;
        private System.Windows.Forms.TextBox txtB_fiyat;
        private System.Windows.Forms.RichTextBox rtxtB_aciklama;
        private System.Windows.Forms.ComboBox cmbB_kitapturu;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label lbl_yayinyili;
        private System.Windows.Forms.TextBox txtB_yayinyili;
        private System.Windows.Forms.Label lblB_ornekfiyat;
        private System.Windows.Forms.Label lblB_ornekyayinyili;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.TextBox txtB_adet;
    }
}