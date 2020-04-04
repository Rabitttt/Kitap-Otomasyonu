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
            this.Albl_adet = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_kalanZaman = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_alinmaTarihi = new System.Windows.Forms.Label();
            this.lbl_teslimTarihi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Albl_adres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Albl_soyisim = new System.Windows.Forms.Label();
            this.Albl_isim = new System.Windows.Forms.Label();
            this.Albl_telefon = new System.Windows.Forms.Label();
            this.Albl_aciklama = new System.Windows.Forms.Label();
            this.Albl_eklenmeTarihi = new System.Windows.Forms.Label();
            this.Albl_yayin_yili = new System.Windows.Forms.Label();
            this.Albl_fiyat = new System.Windows.Forms.Label();
            this.Albl_yayinevi = new System.Windows.Forms.Label();
            this.Albl_yazar = new System.Windows.Forms.Label();
            this.Albl_kitapturu = new System.Windows.Forms.Label();
            this.Albl_kitapadi = new System.Windows.Forms.Label();
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
            this.btn_kitapEkle.Location = new System.Drawing.Point(271, 20);
            this.btn_kitapEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(170, 69);
            this.btn_kitapEkle.TabIndex = 3;
            this.btn_kitapEkle.Text = "Yeni Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_liste
            // 
            this.dGV_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_liste.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGV_liste.Location = new System.Drawing.Point(2, 111);
            this.dGV_liste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGV_liste.Name = "dGV_liste";
            this.dGV_liste.RowHeadersWidth = 51;
            this.dGV_liste.RowTemplate.Height = 24;
            this.dGV_liste.Size = new System.Drawing.Size(798, 493);
            this.dGV_liste.TabIndex = 4;
            this.dGV_liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_liste_CellClick);
            this.dGV_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_liste_CellContentClick);
            // 
            // txtB_aranacak
            // 
            this.txtB_aranacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtB_aranacak.Location = new System.Drawing.Point(499, 54);
            this.txtB_aranacak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_aranacak.Name = "txtB_aranacak";
            this.txtB_aranacak.Size = new System.Drawing.Size(128, 20);
            this.txtB_aranacak.TabIndex = 5;
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ara.Location = new System.Drawing.Point(644, 50);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(88, 21);
            this.btn_ara.TabIndex = 6;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbBox_aramaturu
            // 
            this.cmbBox_aramaturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBox_aramaturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_aramaturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_aramaturu.FormattingEnabled = true;
            this.cmbBox_aramaturu.Location = new System.Drawing.Point(499, 25);
            this.cmbBox_aramaturu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBox_aramaturu.Name = "cmbBox_aramaturu";
            this.cmbBox_aramaturu.Size = new System.Drawing.Size(128, 25);
            this.cmbBox_aramaturu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.cmbBox_listelemeturu.Location = new System.Drawing.Point(53, 61);
            this.cmbBox_listelemeturu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBox_listelemeturu.Name = "cmbBox_listelemeturu";
            this.cmbBox_listelemeturu.Size = new System.Drawing.Size(159, 25);
            this.cmbBox_listelemeturu.TabIndex = 9;
            this.cmbBox_listelemeturu.SelectedIndexChanged += new System.EventHandler(this.cmbBox_listelemeturu_SelectedIndexChanged);
            // 
            // lbl_listelemeturu
            // 
            this.lbl_listelemeturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_listelemeturu.AutoSize = true;
            this.lbl_listelemeturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listelemeturu.Location = new System.Drawing.Point(50, 38);
            this.lbl_listelemeturu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.panel1.Controls.Add(this.Albl_adet);
            this.panel1.Controls.Add(this.lbl_adet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Albl_aciklama);
            this.panel1.Controls.Add(this.Albl_eklenmeTarihi);
            this.panel1.Controls.Add(this.Albl_yayin_yili);
            this.panel1.Controls.Add(this.Albl_fiyat);
            this.panel1.Controls.Add(this.Albl_yayinevi);
            this.panel1.Controls.Add(this.Albl_yazar);
            this.panel1.Controls.Add(this.Albl_kitapturu);
            this.panel1.Controls.Add(this.Albl_kitapadi);
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
            this.panel1.Location = new System.Drawing.Point(802, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 602);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Albl_adet
            // 
            this.Albl_adet.AutoSize = true;
            this.Albl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_adet.Location = new System.Drawing.Point(127, 174);
            this.Albl_adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_adet.Name = "Albl_adet";
            this.Albl_adet.Size = new System.Drawing.Size(72, 15);
            this.Albl_adet.TabIndex = 32;
            this.Albl_adet.Text = "Belirtilmedi.";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adet.Location = new System.Drawing.Point(73, 171);
            this.lbl_adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(51, 17);
            this.lbl_adet.TabIndex = 31;
            this.lbl_adet.Text = "Adet :";
            this.lbl_adet.Click += new System.EventHandler(this.Albl_adet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbl_kalanZaman);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbl_alinmaTarihi);
            this.panel2.Controls.Add(this.lbl_teslimTarihi);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.Albl_adres);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Albl_soyisim);
            this.panel2.Controls.Add(this.Albl_isim);
            this.panel2.Controls.Add(this.Albl_telefon);
            this.panel2.Location = new System.Drawing.Point(22, 236);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 182);
            this.panel2.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Belirtilmedi.";
            // 
            // lbl_kalanZaman
            // 
            this.lbl_kalanZaman.AutoSize = true;
            this.lbl_kalanZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kalanZaman.Location = new System.Drawing.Point(8, 157);
            this.lbl_kalanZaman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kalanZaman.Name = "lbl_kalanZaman";
            this.lbl_kalanZaman.Size = new System.Drawing.Size(113, 17);
            this.lbl_kalanZaman.TabIndex = 42;
            this.lbl_kalanZaman.Text = "Kalan Zaman :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(116, 135);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Belirtilmedi.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(116, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "Belirtilmedi.";
            // 
            // lbl_alinmaTarihi
            // 
            this.lbl_alinmaTarihi.AutoSize = true;
            this.lbl_alinmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alinmaTarihi.Location = new System.Drawing.Point(5, 115);
            this.lbl_alinmaTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alinmaTarihi.Name = "lbl_alinmaTarihi";
            this.lbl_alinmaTarihi.Size = new System.Drawing.Size(113, 17);
            this.lbl_alinmaTarihi.TabIndex = 39;
            this.lbl_alinmaTarihi.Text = "Alinma Tarihi :";
            // 
            // lbl_teslimTarihi
            // 
            this.lbl_teslimTarihi.AutoSize = true;
            this.lbl_teslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teslimTarihi.Location = new System.Drawing.Point(6, 135);
            this.lbl_teslimTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_teslimTarihi.Name = "lbl_teslimTarihi";
            this.lbl_teslimTarihi.Size = new System.Drawing.Size(112, 17);
            this.lbl_teslimTarihi.TabIndex = 38;
            this.lbl_teslimTarihi.Text = "Teslim Tarihi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(104, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Belirtilmedi.";
            // 
            // Albl_adres
            // 
            this.Albl_adres.AutoSize = true;
            this.Albl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_adres.Location = new System.Drawing.Point(40, 71);
            this.Albl_adres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_adres.Name = "Albl_adres";
            this.Albl_adres.Size = new System.Drawing.Size(60, 17);
            this.Albl_adres.TabIndex = 36;
            this.Albl_adres.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Belirtilmedi.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Belirtilmedi.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(104, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Belirtilmedi.";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Albl_soyisim
            // 
            this.Albl_soyisim.AutoSize = true;
            this.Albl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_soyisim.Location = new System.Drawing.Point(28, 29);
            this.Albl_soyisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_soyisim.Name = "Albl_soyisim";
            this.Albl_soyisim.Size = new System.Drawing.Size(73, 17);
            this.Albl_soyisim.TabIndex = 31;
            this.Albl_soyisim.Text = "Soyisim :";
            // 
            // Albl_isim
            // 
            this.Albl_isim.AutoSize = true;
            this.Albl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_isim.Location = new System.Drawing.Point(51, 7);
            this.Albl_isim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_isim.Name = "Albl_isim";
            this.Albl_isim.Size = new System.Drawing.Size(46, 17);
            this.Albl_isim.TabIndex = 32;
            this.Albl_isim.Text = "İsim :";
            // 
            // Albl_telefon
            // 
            this.Albl_telefon.AutoSize = true;
            this.Albl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_telefon.Location = new System.Drawing.Point(31, 49);
            this.Albl_telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_telefon.Name = "Albl_telefon";
            this.Albl_telefon.Size = new System.Drawing.Size(73, 17);
            this.Albl_telefon.TabIndex = 30;
            this.Albl_telefon.Text = "Telefon :";
            this.Albl_telefon.Click += new System.EventHandler(this.Albl_telefon_Click);
            // 
            // Albl_aciklama
            // 
            this.Albl_aciklama.AutoSize = true;
            this.Albl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_aciklama.Location = new System.Drawing.Point(127, 198);
            this.Albl_aciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_aciklama.Name = "Albl_aciklama";
            this.Albl_aciklama.Size = new System.Drawing.Size(72, 15);
            this.Albl_aciklama.TabIndex = 29;
            this.Albl_aciklama.Text = "Belirtilmedi.";
            // 
            // Albl_eklenmeTarihi
            // 
            this.Albl_eklenmeTarihi.AutoSize = true;
            this.Albl_eklenmeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_eklenmeTarihi.Location = new System.Drawing.Point(127, 150);
            this.Albl_eklenmeTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_eklenmeTarihi.Name = "Albl_eklenmeTarihi";
            this.Albl_eklenmeTarihi.Size = new System.Drawing.Size(72, 15);
            this.Albl_eklenmeTarihi.TabIndex = 28;
            this.Albl_eklenmeTarihi.Text = "Belirtilmedi.";
            this.Albl_eklenmeTarihi.Click += new System.EventHandler(this.label3_Click);
            // 
            // Albl_yayin_yili
            // 
            this.Albl_yayin_yili.AutoSize = true;
            this.Albl_yayin_yili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_yayin_yili.Location = new System.Drawing.Point(127, 129);
            this.Albl_yayin_yili.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_yayin_yili.Name = "Albl_yayin_yili";
            this.Albl_yayin_yili.Size = new System.Drawing.Size(72, 15);
            this.Albl_yayin_yili.TabIndex = 28;
            this.Albl_yayin_yili.Text = "Belirtilmedi.";
            // 
            // Albl_fiyat
            // 
            this.Albl_fiyat.AutoSize = true;
            this.Albl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_fiyat.Location = new System.Drawing.Point(127, 104);
            this.Albl_fiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_fiyat.Name = "Albl_fiyat";
            this.Albl_fiyat.Size = new System.Drawing.Size(72, 15);
            this.Albl_fiyat.TabIndex = 27;
            this.Albl_fiyat.Text = "Belirtilmedi.";
            // 
            // Albl_yayinevi
            // 
            this.Albl_yayinevi.AutoSize = true;
            this.Albl_yayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_yayinevi.Location = new System.Drawing.Point(127, 82);
            this.Albl_yayinevi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_yayinevi.Name = "Albl_yayinevi";
            this.Albl_yayinevi.Size = new System.Drawing.Size(72, 15);
            this.Albl_yayinevi.TabIndex = 26;
            this.Albl_yayinevi.Text = "Belirtilmedi.";
            // 
            // Albl_yazar
            // 
            this.Albl_yazar.AutoSize = true;
            this.Albl_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_yazar.Location = new System.Drawing.Point(127, 62);
            this.Albl_yazar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_yazar.Name = "Albl_yazar";
            this.Albl_yazar.Size = new System.Drawing.Size(72, 15);
            this.Albl_yazar.TabIndex = 25;
            this.Albl_yazar.Text = "Belirtilmedi.";
            this.Albl_yazar.Click += new System.EventHandler(this.Albl_yazar_Click);
            // 
            // Albl_kitapturu
            // 
            this.Albl_kitapturu.AutoSize = true;
            this.Albl_kitapturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_kitapturu.Location = new System.Drawing.Point(127, 40);
            this.Albl_kitapturu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_kitapturu.Name = "Albl_kitapturu";
            this.Albl_kitapturu.Size = new System.Drawing.Size(72, 15);
            this.Albl_kitapturu.TabIndex = 24;
            this.Albl_kitapturu.Text = "Belirtilmedi.";
            // 
            // Albl_kitapadi
            // 
            this.Albl_kitapadi.AutoSize = true;
            this.Albl_kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albl_kitapadi.Location = new System.Drawing.Point(127, 19);
            this.Albl_kitapadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Albl_kitapadi.Name = "Albl_kitapadi";
            this.Albl_kitapadi.Size = new System.Drawing.Size(72, 15);
            this.Albl_kitapadi.TabIndex = 23;
            this.Albl_kitapadi.Text = "Belirtilmedi.";
            this.Albl_kitapadi.Click += new System.EventHandler(this.Albl_kitapadi_Click);
            // 
            // lbl_eklenmetarihi
            // 
            this.lbl_eklenmetarihi.AutoSize = true;
            this.lbl_eklenmetarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eklenmetarihi.Location = new System.Drawing.Point(8, 150);
            this.lbl_eklenmetarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eklenmetarihi.Name = "lbl_eklenmetarihi";
            this.lbl_eklenmetarihi.Size = new System.Drawing.Size(126, 17);
            this.lbl_eklenmetarihi.TabIndex = 22;
            this.lbl_eklenmetarihi.Text = "Eklenme Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Yayın Yılı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Yayınevi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yazar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kitap Türü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Kitap Adı :";
            // 
            // btn_emanet
            // 
            this.btn_emanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emanet.Location = new System.Drawing.Point(22, 448);
            this.btn_emanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(229, 39);
            this.btn_emanet.TabIndex = 2;
            this.btn_emanet.Text = "Emanet Ver";
            this.btn_emanet.UseVisualStyleBackColor = true;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(140, 492);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(110, 45);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(22, 492);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(114, 45);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(788, 104);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV_liste);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label Albl_kitapadi;
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
        private System.Windows.Forms.Label Albl_aciklama;
        private System.Windows.Forms.Label Albl_yayin_yili;
        private System.Windows.Forms.Label Albl_fiyat;
        private System.Windows.Forms.Label Albl_yayinevi;
        private System.Windows.Forms.Label Albl_yazar;
        private System.Windows.Forms.Label Albl_kitapturu;
        private System.Windows.Forms.Label Albl_eklenmeTarihi;
        private System.Windows.Forms.Label lbl_eklenmetarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Albl_adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Albl_soyisim;
        private System.Windows.Forms.Label Albl_isim;
        private System.Windows.Forms.Label Albl_telefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_kalanZaman;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_alinmaTarihi;
        private System.Windows.Forms.Label lbl_teslimTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Albl_adet;
        private System.Windows.Forms.Label lbl_adet;
    }
}

