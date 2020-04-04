namespace KitapOtomasyonu
{
    partial class frm_emanet
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
            this.btn_emanetekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_teslimTarihi = new System.Windows.Forms.Label();
            this.txtB_isim = new System.Windows.Forms.TextBox();
            this.txtB_soyisim = new System.Windows.Forms.TextBox();
            this.txtB_telefon = new System.Windows.Forms.TextBox();
            this.rtxtB_adres = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_emanetekle
            // 
            this.btn_emanetekle.Location = new System.Drawing.Point(25, 341);
            this.btn_emanetekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_emanetekle.Name = "btn_emanetekle";
            this.btn_emanetekle.Size = new System.Drawing.Size(119, 49);
            this.btn_emanetekle.TabIndex = 0;
            this.btn_emanetekle.Text = "EKLE";
            this.btn_emanetekle.UseVisualStyleBackColor = true;
            this.btn_emanetekle.Click += new System.EventHandler(this.btn_emanetekle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(200, 341);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(116, 48);
            this.btn_iptal.TabIndex = 0;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isim.Location = new System.Drawing.Point(62, 35);
            this.lbl_isim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(46, 17);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İsim :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyisim.Location = new System.Drawing.Point(39, 63);
            this.lbl_soyisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(73, 17);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyisim :";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefon.Location = new System.Drawing.Point(42, 93);
            this.lbl_telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(73, 17);
            this.lbl_telefon.TabIndex = 1;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adres.Location = new System.Drawing.Point(52, 116);
            this.lbl_adres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(60, 17);
            this.lbl_adres.TabIndex = 1;
            this.lbl_adres.Text = "Adres :";
            // 
            // lbl_teslimTarihi
            // 
            this.lbl_teslimTarihi.AutoSize = true;
            this.lbl_teslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teslimTarihi.Location = new System.Drawing.Point(9, 250);
            this.lbl_teslimTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_teslimTarihi.Name = "lbl_teslimTarihi";
            this.lbl_teslimTarihi.Size = new System.Drawing.Size(112, 17);
            this.lbl_teslimTarihi.TabIndex = 1;
            this.lbl_teslimTarihi.Text = "Teslim Tarihi :";
            this.lbl_teslimTarihi.Click += new System.EventHandler(this.lbl_teslimTarihi_Click);
            // 
            // txtB_isim
            // 
            this.txtB_isim.Location = new System.Drawing.Point(120, 35);
            this.txtB_isim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_isim.Name = "txtB_isim";
            this.txtB_isim.Size = new System.Drawing.Size(120, 20);
            this.txtB_isim.TabIndex = 2;
            // 
            // txtB_soyisim
            // 
            this.txtB_soyisim.Location = new System.Drawing.Point(120, 63);
            this.txtB_soyisim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_soyisim.Name = "txtB_soyisim";
            this.txtB_soyisim.Size = new System.Drawing.Size(120, 20);
            this.txtB_soyisim.TabIndex = 2;
            // 
            // txtB_telefon
            // 
            this.txtB_telefon.Location = new System.Drawing.Point(120, 93);
            this.txtB_telefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_telefon.Name = "txtB_telefon";
            this.txtB_telefon.Size = new System.Drawing.Size(120, 20);
            this.txtB_telefon.TabIndex = 2;
            // 
            // rtxtB_adres
            // 
            this.rtxtB_adres.Location = new System.Drawing.Point(120, 116);
            this.rtxtB_adres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtB_adres.Name = "rtxtB_adres";
            this.rtxtB_adres.Size = new System.Drawing.Size(198, 107);
            this.rtxtB_adres.TabIndex = 3;
            this.rtxtB_adres.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 250);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frm_emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rtxtB_adres);
            this.Controls.Add(this.txtB_telefon);
            this.Controls.Add(this.txtB_soyisim);
            this.Controls.Add(this.txtB_isim);
            this.Controls.Add(this.lbl_teslimTarihi);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_emanetekle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_emanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Oluştur";
            this.Load += new System.EventHandler(this.frm_emanet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emanetekle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_teslimTarihi;
        private System.Windows.Forms.TextBox txtB_isim;
        private System.Windows.Forms.TextBox txtB_soyisim;
        private System.Windows.Forms.TextBox txtB_telefon;
        private System.Windows.Forms.RichTextBox rtxtB_adres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}