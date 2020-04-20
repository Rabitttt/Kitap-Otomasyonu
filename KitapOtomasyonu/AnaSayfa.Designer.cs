namespace KitapOtomasyonu
{
    partial class AnaSayfa
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
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.dGV_liste = new System.Windows.Forms.DataGridView();
            this.txtB_aranacak = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.cmbBox_aramaturu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_listelemeturu = new System.Windows.Forms.ComboBox();
            this.lbl_listelemeturu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_kitapTuru = new System.Windows.Forms.ComboBox();
            this.rtxtB_aciklama = new System.Windows.Forms.RichTextBox();
            this.txtB_adet = new System.Windows.Forms.TextBox();
            this.txtB_eklenmeTarihi = new System.Windows.Forms.TextBox();
            this.txtB_yayinYili = new System.Windows.Forms.TextBox();
            this.txtB_fiyat = new System.Windows.Forms.TextBox();
            this.txtB_yayinevi = new System.Windows.Forms.TextBox();
            this.txtB_yazar = new System.Windows.Forms.TextBox();
            this.txtB_kitapAdi = new System.Windows.Forms.TextBox();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtB_adres = new System.Windows.Forms.RichTextBox();
            this.txtB_kalanZaman = new System.Windows.Forms.TextBox();
            this.txtB_teslimTarihi = new System.Windows.Forms.TextBox();
            this.txtB_alinmaTarihi = new System.Windows.Forms.TextBox();
            this.txtB_telefon = new System.Windows.Forms.TextBox();
            this.txtB_soyisim = new System.Windows.Forms.TextBox();
            this.txtB_isim = new System.Windows.Forms.TextBox();
            this.lbl_kalanZaman = new System.Windows.Forms.Label();
            this.lbl_alinmaTarihi = new System.Windows.Forms.Label();
            this.lbl_teslimTarihi = new System.Windows.Forms.Label();
            this.Albl_adres = new System.Windows.Forms.Label();
            this.Albl_soyisim = new System.Windows.Forms.Label();
            this.Albl_isim = new System.Windows.Forms.Label();
            this.Albl_telefon = new System.Windows.Forms.Label();
            this.lbl_eklenmetarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitapEkle.Location = new System.Drawing.Point(529, 25);
            this.btn_kitapEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(227, 85);
            this.btn_kitapEkle.TabIndex = 3;
            this.btn_kitapEkle.Text = "Yeni Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_liste
            // 
            this.dGV_liste.AllowUserToAddRows = false;
            this.dGV_liste.AllowUserToDeleteRows = false;
            this.dGV_liste.AllowUserToOrderColumns = true;
            this.dGV_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_liste.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGV_liste.Location = new System.Drawing.Point(3, 137);
            this.dGV_liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_liste.Name = "dGV_liste";
            this.dGV_liste.ReadOnly = true;
            this.dGV_liste.RowHeadersWidth = 51;
            this.dGV_liste.RowTemplate.Height = 24;
            this.dGV_liste.Size = new System.Drawing.Size(1400, 689);
            this.dGV_liste.TabIndex = 4;
            this.dGV_liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_liste_CellClick);
            this.dGV_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_liste_CellContentClick);
            // 
            // txtB_aranacak
            // 
            this.txtB_aranacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtB_aranacak.Location = new System.Drawing.Point(833, 66);
            this.txtB_aranacak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB_aranacak.Name = "txtB_aranacak";
            this.txtB_aranacak.Size = new System.Drawing.Size(169, 22);
            this.txtB_aranacak.TabIndex = 5;
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ara.Location = new System.Drawing.Point(1027, 62);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(117, 26);
            this.btn_ara.TabIndex = 6;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // cmbBox_aramaturu
            // 
            this.cmbBox_aramaturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBox_aramaturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_aramaturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_aramaturu.FormattingEnabled = true;
            this.cmbBox_aramaturu.Location = new System.Drawing.Point(833, 31);
            this.cmbBox_aramaturu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_aramaturu.Name = "cmbBox_aramaturu";
            this.cmbBox_aramaturu.Size = new System.Drawing.Size(169, 25);
            this.cmbBox_aramaturu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1025, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arama Türü :";
            // 
            // cmbBox_listelemeturu
            // 
            this.cmbBox_listelemeturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBox_listelemeturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_listelemeturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_listelemeturu.FormattingEnabled = true;
            this.cmbBox_listelemeturu.Location = new System.Drawing.Point(239, 75);
            this.cmbBox_listelemeturu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_listelemeturu.Name = "cmbBox_listelemeturu";
            this.cmbBox_listelemeturu.Size = new System.Drawing.Size(211, 25);
            this.cmbBox_listelemeturu.TabIndex = 9;
            this.cmbBox_listelemeturu.SelectedIndexChanged += new System.EventHandler(this.cmbBox_listelemeturu_SelectedIndexChanged);
            // 
            // lbl_listelemeturu
            // 
            this.lbl_listelemeturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_listelemeturu.AutoSize = true;
            this.lbl_listelemeturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listelemeturu.Location = new System.Drawing.Point(235, 47);
            this.lbl_listelemeturu.Name = "lbl_listelemeturu";
            this.lbl_listelemeturu.Size = new System.Drawing.Size(183, 17);
            this.lbl_listelemeturu.TabIndex = 10;
            this.lbl_listelemeturu.Text = "Listeleme Türü Seçiniz :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cmb_kitapTuru);
            this.panel1.Controls.Add(this.rtxtB_aciklama);
            this.panel1.Controls.Add(this.txtB_adet);
            this.panel1.Controls.Add(this.txtB_eklenmeTarihi);
            this.panel1.Controls.Add(this.txtB_yayinYili);
            this.panel1.Controls.Add(this.txtB_fiyat);
            this.panel1.Controls.Add(this.txtB_yayinevi);
            this.panel1.Controls.Add(this.txtB_yazar);
            this.panel1.Controls.Add(this.txtB_kitapAdi);
            this.panel1.Controls.Add(this.lbl_adet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_eklenmetarihi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_emanet);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.btn_guncelle);
            this.panel1.Location = new System.Drawing.Point(1405, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 823);
            this.panel1.TabIndex = 2;
            // 
            // cmb_kitapTuru
            // 
            this.cmb_kitapTuru.FormattingEnabled = true;
            this.cmb_kitapTuru.Location = new System.Drawing.Point(187, 48);
            this.cmb_kitapTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kitapTuru.Name = "cmb_kitapTuru";
            this.cmb_kitapTuru.Size = new System.Drawing.Size(160, 24);
            this.cmb_kitapTuru.TabIndex = 34;
            // 
            // rtxtB_aciklama
            // 
            this.rtxtB_aciklama.Location = new System.Drawing.Point(187, 242);
            this.rtxtB_aciklama.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtB_aciklama.Name = "rtxtB_aciklama";
            this.rtxtB_aciklama.Size = new System.Drawing.Size(169, 64);
            this.rtxtB_aciklama.TabIndex = 33;
            this.rtxtB_aciklama.Text = "";
            // 
            // txtB_adet
            // 
            this.txtB_adet.Location = new System.Drawing.Point(187, 207);
            this.txtB_adet.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_adet.Name = "txtB_adet";
            this.txtB_adet.Size = new System.Drawing.Size(132, 22);
            this.txtB_adet.TabIndex = 32;
            // 
            // txtB_eklenmeTarihi
            // 
            this.txtB_eklenmeTarihi.Location = new System.Drawing.Point(187, 181);
            this.txtB_eklenmeTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_eklenmeTarihi.Name = "txtB_eklenmeTarihi";
            this.txtB_eklenmeTarihi.Size = new System.Drawing.Size(132, 22);
            this.txtB_eklenmeTarihi.TabIndex = 32;
            // 
            // txtB_yayinYili
            // 
            this.txtB_yayinYili.Location = new System.Drawing.Point(187, 154);
            this.txtB_yayinYili.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_yayinYili.Name = "txtB_yayinYili";
            this.txtB_yayinYili.Size = new System.Drawing.Size(132, 22);
            this.txtB_yayinYili.TabIndex = 32;
            // 
            // txtB_fiyat
            // 
            this.txtB_fiyat.Location = new System.Drawing.Point(187, 123);
            this.txtB_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_fiyat.Name = "txtB_fiyat";
            this.txtB_fiyat.Size = new System.Drawing.Size(132, 22);
            this.txtB_fiyat.TabIndex = 32;
            // 
            // txtB_yayinevi
            // 
            this.txtB_yayinevi.Location = new System.Drawing.Point(187, 100);
            this.txtB_yayinevi.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_yayinevi.Name = "txtB_yayinevi";
            this.txtB_yayinevi.Size = new System.Drawing.Size(132, 22);
            this.txtB_yayinevi.TabIndex = 32;
            // 
            // txtB_yazar
            // 
            this.txtB_yazar.Location = new System.Drawing.Point(187, 71);
            this.txtB_yazar.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_yazar.Name = "txtB_yazar";
            this.txtB_yazar.Size = new System.Drawing.Size(132, 22);
            this.txtB_yazar.TabIndex = 32;
            // 
            // txtB_kitapAdi
            // 
            this.txtB_kitapAdi.Location = new System.Drawing.Point(187, 18);
            this.txtB_kitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_kitapAdi.Name = "txtB_kitapAdi";
            this.txtB_kitapAdi.Size = new System.Drawing.Size(132, 22);
            this.txtB_kitapAdi.TabIndex = 32;
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adet.Location = new System.Drawing.Point(97, 210);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(51, 17);
            this.lbl_adet.TabIndex = 31;
            this.lbl_adet.Text = "Adet :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtB_adres);
            this.panel2.Controls.Add(this.txtB_kalanZaman);
            this.panel2.Controls.Add(this.txtB_teslimTarihi);
            this.panel2.Controls.Add(this.txtB_alinmaTarihi);
            this.panel2.Controls.Add(this.txtB_telefon);
            this.panel2.Controls.Add(this.txtB_soyisim);
            this.panel2.Controls.Add(this.txtB_isim);
            this.panel2.Controls.Add(this.lbl_kalanZaman);
            this.panel2.Controls.Add(this.lbl_alinmaTarihi);
            this.panel2.Controls.Add(this.lbl_teslimTarihi);
            this.panel2.Controls.Add(this.Albl_adres);
            this.panel2.Controls.Add(this.Albl_soyisim);
            this.panel2.Controls.Add(this.Albl_isim);
            this.panel2.Controls.Add(this.Albl_telefon);
            this.panel2.Location = new System.Drawing.Point(29, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 224);
            this.panel2.TabIndex = 30;
            // 
            // rtxtB_adres
            // 
            this.rtxtB_adres.Location = new System.Drawing.Point(157, 87);
            this.rtxtB_adres.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtB_adres.Name = "rtxtB_adres";
            this.rtxtB_adres.Size = new System.Drawing.Size(132, 32);
            this.rtxtB_adres.TabIndex = 43;
            this.rtxtB_adres.Text = "";
            // 
            // txtB_kalanZaman
            // 
            this.txtB_kalanZaman.Location = new System.Drawing.Point(157, 193);
            this.txtB_kalanZaman.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_kalanZaman.Name = "txtB_kalanZaman";
            this.txtB_kalanZaman.Size = new System.Drawing.Size(132, 22);
            this.txtB_kalanZaman.TabIndex = 32;
            // 
            // txtB_teslimTarihi
            // 
            this.txtB_teslimTarihi.Location = new System.Drawing.Point(157, 166);
            this.txtB_teslimTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_teslimTarihi.Name = "txtB_teslimTarihi";
            this.txtB_teslimTarihi.Size = new System.Drawing.Size(132, 22);
            this.txtB_teslimTarihi.TabIndex = 32;
            // 
            // txtB_alinmaTarihi
            // 
            this.txtB_alinmaTarihi.Location = new System.Drawing.Point(157, 142);
            this.txtB_alinmaTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_alinmaTarihi.Name = "txtB_alinmaTarihi";
            this.txtB_alinmaTarihi.Size = new System.Drawing.Size(132, 22);
            this.txtB_alinmaTarihi.TabIndex = 32;
            // 
            // txtB_telefon
            // 
            this.txtB_telefon.Location = new System.Drawing.Point(157, 64);
            this.txtB_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_telefon.Name = "txtB_telefon";
            this.txtB_telefon.Size = new System.Drawing.Size(132, 22);
            this.txtB_telefon.TabIndex = 32;
            // 
            // txtB_soyisim
            // 
            this.txtB_soyisim.Location = new System.Drawing.Point(157, 32);
            this.txtB_soyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_soyisim.Name = "txtB_soyisim";
            this.txtB_soyisim.Size = new System.Drawing.Size(132, 22);
            this.txtB_soyisim.TabIndex = 32;
            // 
            // txtB_isim
            // 
            this.txtB_isim.Location = new System.Drawing.Point(157, 5);
            this.txtB_isim.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_isim.Name = "txtB_isim";
            this.txtB_isim.Size = new System.Drawing.Size(132, 22);
            this.txtB_isim.TabIndex = 32;
            // 
            // lbl_kalanZaman
            // 
            this.lbl_kalanZaman.AutoSize = true;
            this.lbl_kalanZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kalanZaman.Location = new System.Drawing.Point(11, 193);
            this.lbl_kalanZaman.Name = "lbl_kalanZaman";
            this.lbl_kalanZaman.Size = new System.Drawing.Size(113, 17);
            this.lbl_kalanZaman.TabIndex = 42;
            this.lbl_kalanZaman.Text = "Kalan Zaman :";
            // 
            // lbl_alinmaTarihi
            // 
            this.lbl_alinmaTarihi.AutoSize = true;
            this.lbl_alinmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alinmaTarihi.Location = new System.Drawing.Point(7, 142);
            this.lbl_alinmaTarihi.Name = "lbl_alinmaTarihi";
            this.lbl_alinmaTarihi.Size = new System.Drawing.Size(113, 17);
            this.lbl_alinmaTarihi.TabIndex = 39;
            this.lbl_alinmaTarihi.Text = "Alinma Tarihi :";
            // 
            // lbl_teslimTarihi
            // 
            this.lbl_teslimTarihi.AutoSize = true;
            this.lbl_teslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teslimTarihi.Location = new System.Drawing.Point(8, 166);
            this.lbl_teslimTarihi.Name = "lbl_teslimTarihi";
            this.lbl_teslimTarihi.Size = new System.Drawing.Size(112, 17);
            this.lbl_teslimTarihi.TabIndex = 38;
            this.lbl_teslimTarihi.Text = "Teslim Tarihi :";
            // 
            // Albl_adres
            // 
            this.Albl_adres.AutoSize = true;
            this.Albl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_adres.Location = new System.Drawing.Point(53, 87);
            this.Albl_adres.Name = "Albl_adres";
            this.Albl_adres.Size = new System.Drawing.Size(60, 17);
            this.Albl_adres.TabIndex = 36;
            this.Albl_adres.Text = "Adres :";
            // 
            // Albl_soyisim
            // 
            this.Albl_soyisim.AutoSize = true;
            this.Albl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_soyisim.Location = new System.Drawing.Point(37, 36);
            this.Albl_soyisim.Name = "Albl_soyisim";
            this.Albl_soyisim.Size = new System.Drawing.Size(73, 17);
            this.Albl_soyisim.TabIndex = 31;
            this.Albl_soyisim.Text = "Soyisim :";
            // 
            // Albl_isim
            // 
            this.Albl_isim.AutoSize = true;
            this.Albl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_isim.Location = new System.Drawing.Point(68, 9);
            this.Albl_isim.Name = "Albl_isim";
            this.Albl_isim.Size = new System.Drawing.Size(46, 17);
            this.Albl_isim.TabIndex = 32;
            this.Albl_isim.Text = "İsim :";
            // 
            // Albl_telefon
            // 
            this.Albl_telefon.AutoSize = true;
            this.Albl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_telefon.Location = new System.Drawing.Point(41, 60);
            this.Albl_telefon.Name = "Albl_telefon";
            this.Albl_telefon.Size = new System.Drawing.Size(73, 17);
            this.Albl_telefon.TabIndex = 30;
            this.Albl_telefon.Text = "Telefon :";
            // 
            // lbl_eklenmetarihi
            // 
            this.lbl_eklenmetarihi.AutoSize = true;
            this.lbl_eklenmetarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eklenmetarihi.Location = new System.Drawing.Point(11, 185);
            this.lbl_eklenmetarihi.Name = "lbl_eklenmetarihi";
            this.lbl_eklenmetarihi.Size = new System.Drawing.Size(126, 17);
            this.lbl_eklenmetarihi.TabIndex = 22;
            this.lbl_eklenmetarihi.Text = "Eklenme Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Yayın Yılı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Yayınevi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yazar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kitap Türü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Kitap Adı :";
            // 
            // btn_emanet
            // 
            this.btn_emanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emanet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_emanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emanet.Location = new System.Drawing.Point(29, 592);
            this.btn_emanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(305, 48);
            this.btn_emanet.TabIndex = 2;
            this.btn_emanet.Text = "Emanet Ver";
            this.btn_emanet.UseVisualStyleBackColor = false;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(187, 646);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(147, 55);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(29, 646);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(152, 55);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_listelemeturu);
            this.groupBox1.Controls.Add(this.btn_kitapEkle);
            this.groupBox1.Controls.Add(this.txtB_aranacak);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.cmbBox_listelemeturu);
            this.groupBox1.Controls.Add(this.cmbBox_aramaturu);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1387, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 830);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV_liste);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palto Kitap Kafe";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.DataGridView dGV_liste;
        private System.Windows.Forms.TextBox txtB_aranacak;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox cmbBox_aramaturu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_listelemeturu;
        private System.Windows.Forms.Label lbl_listelemeturu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_eklenmetarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Albl_adres;
        private System.Windows.Forms.Label Albl_soyisim;
        private System.Windows.Forms.Label Albl_isim;
        private System.Windows.Forms.Label Albl_telefon;
        private System.Windows.Forms.Label lbl_kalanZaman;
        private System.Windows.Forms.Label lbl_alinmaTarihi;
        private System.Windows.Forms.Label lbl_teslimTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.TextBox txtB_adet;
        private System.Windows.Forms.TextBox txtB_eklenmeTarihi;
        private System.Windows.Forms.TextBox txtB_yayinYili;
        private System.Windows.Forms.TextBox txtB_fiyat;
        private System.Windows.Forms.TextBox txtB_yayinevi;
        private System.Windows.Forms.TextBox txtB_yazar;
        private System.Windows.Forms.TextBox txtB_kitapAdi;
        private System.Windows.Forms.TextBox txtB_kalanZaman;
        private System.Windows.Forms.TextBox txtB_teslimTarihi;
        private System.Windows.Forms.TextBox txtB_alinmaTarihi;
        private System.Windows.Forms.TextBox txtB_telefon;
        private System.Windows.Forms.TextBox txtB_soyisim;
        private System.Windows.Forms.TextBox txtB_isim;
        private System.Windows.Forms.ComboBox cmb_kitapTuru;
        private System.Windows.Forms.RichTextBox rtxtB_aciklama;
        private System.Windows.Forms.RichTextBox rtxtB_adres;
    }
}

