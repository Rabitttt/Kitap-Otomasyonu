using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace KitapOtomasyonu
{
    public partial class AnaSayfa : Form
    {


        public AnaSayfa()
        {
            InitializeComponent();
        }

        //private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        //{

        //}

        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}



        readonly string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";


        private void cmbBox_doldur()
        {
            cmbBox_listelemeturu.Items.Add("Kitaplar");
            cmbBox_listelemeturu.Items.Add("Emanetler");
            cmbBox_listelemeturu.Items.Add("Süresi Dolmuş Emananetler");

            cmbBox_listelemeturu.Text = "Kitaplar";
            cmbBox_aramaturu.Text = "Ad";
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            using (var baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(" SELECT * FROM Kitaplar ", sqlitedb_connstr);
                DataSet ds = new DataSet();
                da.Fill(ds, "Kitaplar");
                dGV_liste.DataSource = ds.Tables[0];

            }

            cmbBox_doldur();

            KitaplariListele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_KitapEkle frm_kitapEkle = new form_KitapEkle();
            frm_kitapEkle.ShowDialog();
        }

        private void btn_emanet_Click(object sender, EventArgs e)
        {
            //EverilenKitap_id = dGV_liste.CurrentRow.Cells["id"].Value.ToString();
            if (string.IsNullOrEmpty(dGV_liste.CurrentRow.Cells["id"].Value.ToString()))
            {
                MessageBox.Show("Lutfen Emanet Verilecek Kitabı Seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_emanet emanetEkle = new frm_emanet(dGV_liste.CurrentRow.Cells["id"].Value.ToString());
                emanetEkle.ShowDialog();
            }
        }

        private void dGV_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Albl_kitapadi_Click(object sender, EventArgs e)
        {

        }


        private void KitaplariListele()
        {
            using (SQLiteConnection baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                string SeciliKitapID = dGV_liste.CurrentRow.Cells["id"].Value.ToString();
                using (SQLiteCommand komut = new SQLiteCommand($"SELECT * FROM Kitaplar WHERE Kitaplar.id = {SeciliKitapID}", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        using (SQLiteDataReader dataReader = komut.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                txtB_kitapAdi.Text = dataReader["Ad"].ToString();
                                cmb_kitapTuru.Text = dataReader["Tur"].ToString();
                                txtB_yazar.Text = dataReader["Yazar"].ToString();
                                txtB_yayinevi.Text = dataReader["Yayinevi"].ToString();
                                txtB_fiyat.Text = dataReader["Fiyat"].ToString();
                                txtB_yayinYili.Text = dataReader["yayin_yili"].ToString();
                                txtB_eklenmeTarihi.Text = dataReader["Eklenme_Tarihi"].ToString();
                                txtB_adet.Text = dataReader["Adet"].ToString();
                                rtxtB_aciklama.Text = dataReader["Aciklama"].ToString();

                            }

                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    komut.Connection.Close();
                }

            
            string AktiflikDurumu = null;
                using (SQLiteCommand komut = new SQLiteCommand($"SELECT * FROM Kitaplar INNER JOIN Emanet ON Kitaplar.id = Emanet.Kitap WHERE Kitaplar.id = {dGV_liste.CurrentRow.Cells["id"].Value.ToString()}", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        using (SQLiteDataReader dataReader = komut.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                AktiflikDurumu = dataReader["id"].ToString();
                            }
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    komut.Connection.Close();
                }

            if (string.IsNullOrEmpty(AktiflikDurumu))
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                    string KullaniciID = null;
                    using (SQLiteCommand komut = new SQLiteCommand($"SELECT * FROM Emanet INNER JOIN Kitaplar ON Kitaplar.id = Emanet.Kitap WHERE Kitaplar.id = {dGV_liste.CurrentRow.Cells["id"].Value.ToString()}", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            SQLiteDataReader dataReader = komut.ExecuteReader();
                            if (dataReader.Read())
                            {

                                KullaniciID = dataReader["Kullanici"].ToString();

                                string Ealinma_tarihi = dataReader["E_alinmaTarihi"].ToString();
                                string Eteslim_tarihi = dataReader["E_teslimTarihi"].ToString();



                                txtB_alinmaTarihi.Text = Ealinma_tarihi;
                                txtB_teslimTarihi.Text = Eteslim_tarihi;

                                long alinmaT_ticks = Convert.ToDateTime(Ealinma_tarihi).Ticks;
                                long teslimT_ticks = Convert.ToDateTime(Eteslim_tarihi).Ticks;

                                long kalanZaman_ticks = teslimT_ticks - alinmaT_ticks;

                                if (kalanZaman_ticks < 0)
                                {
                                    txtB_kalanZaman.Text = "Süresi Geçti";
                                    txtB_kalanZaman.ForeColor = Color.Red;
                                }
                                else
                                {
                                    txtB_kalanZaman.ForeColor = Color.Black;
                                    txtB_kalanZaman.Text = (new DateTime(kalanZaman_ticks)).Date.Day.ToString() + " Gün Kaldı";

                                }

                            }
                            dataReader.Close();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message);
                        }
                        komut.Connection.Close();
                    }
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Kullanicilar WHERE Kullanicilar.id = {KullaniciID}",baglan))
                {
                            try
                            {
                                cmd.Connection.Open();
                            SQLiteDataReader dataReader = cmd.ExecuteReader();
                            if(dataReader.Read())
                            {
                                txtB_isim.Text = dataReader["Ad"].ToString();
                                txtB_soyisim.Text = dataReader["Soyad"].ToString();
                                txtB_telefon.Text = dataReader["Telephone"].ToString();
                                rtxtB_adres.Text = dataReader["Adres"].ToString();
                            }

                            }
                            catch (Exception hata)
                            {
                            MessageBox.Show(hata.Message);
                            }
                }
            }

            

            }


        }
        private void EmanetleriListele()
        {

            using (SQLiteConnection baglan = new SQLiteConnection(sqlitedb_connstr))
            {

                using (SQLiteCommand komut = new SQLiteCommand($"SELECT * FROM Emanet INNER JOIN Kullanicilar ON Kullanicilar.id = Emanet.Kullanici WHERE Kullanicilar.id = {dGV_liste.CurrentRow.Cells["Kullanıcı id"].Value.ToString()}", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        SQLiteDataReader dtr = komut.ExecuteReader();
                        if (dtr.Read())
                        {

                            //long deneme = dateTimePicker1.Value.Ticks;
                            //MessageBox.Show($"{deneme}")
                            //DateTime dtime = new DateTime(deneme);
                            //MessageBox.Show(dtime.ToString());

                            txtB_isim.Text = dtr["Ad"].ToString();
                            txtB_soyisim.Text = dtr["Soyad"].ToString();
                            txtB_telefon.Text = dtr["Telephone"].ToString();
                            rtxtB_adres.Text = dtr["Adres"].ToString();
                        }
                        dtr.Close();
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }

                using (SQLiteCommand komut = new SQLiteCommand($"SELECT * FROM Emanet INNER JOIN Kitaplar ON Kitaplar.id = Emanet.Kitap WHERE Kitaplar.id = {dGV_liste.CurrentRow.Cells["Kitap id"].Value.ToString()}", baglan))
                {
                    try
                    {
                        SQLiteDataReader dataReader = komut.ExecuteReader();

                        if (dataReader.Read())
                        {


                            string Ealinma_tarihi = dataReader["E_alinmaTarihi"].ToString();
                            string Eteslim_tarihi = dataReader["E_teslimTarihi"].ToString();



                            txtB_alinmaTarihi.Text = Ealinma_tarihi;
                            txtB_teslimTarihi.Text = Eteslim_tarihi;

                            long alinmaT_ticks = Convert.ToDateTime(Ealinma_tarihi).Ticks;
                            long teslimT_ticks = Convert.ToDateTime(Eteslim_tarihi).Ticks;

                            long kalanZaman_ticks = teslimT_ticks - alinmaT_ticks;

                            if (kalanZaman_ticks < 0)
                            {
                                txtB_kalanZaman.Text = "Süresi Geçti";
                                txtB_kalanZaman.ForeColor = Color.Red;
                            }
                            else
                            {
                                txtB_kalanZaman.ForeColor = Color.Black;
                                txtB_kalanZaman.Text = (new DateTime(kalanZaman_ticks)).Date.Day.ToString() + " Gün Kaldı";

                            }


                            txtB_kitapAdi.Text = dataReader["Ad"].ToString();
                            cmb_kitapTuru.Text = dataReader["Tur"].ToString();
                            txtB_yazar.Text = dataReader["Yazar"].ToString();
                            txtB_yayinevi.Text = dataReader["Yayinevi"].ToString();
                            txtB_fiyat.Text = dataReader["Fiyat"].ToString();
                            txtB_yayinYili.Text = dataReader["yayin_yili"].ToString();
                            txtB_eklenmeTarihi.Text = dataReader["Eklenme_Tarihi"].ToString();
                            txtB_adet.Text = dataReader["Adet"].ToString();
                            rtxtB_aciklama.Text = dataReader["Aciklama"].ToString();

                        }
                        dataReader.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }

        }

        private void dGV_liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbBox_listelemeturu.Text == "Kitaplar")
            {
                KitaplariListele();
            }
            if (cmbBox_listelemeturu.Text == "Emanetler")
            {
                EmanetleriListele();
            }
            if (cmbBox_listelemeturu.Text == "")
            {
                KitaplariListele();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Albl_adet_Click(object sender, EventArgs e)
        {

        }

        private void ButonlarAktif()
        {
            btn_emanet.Enabled = true;
            btn_emanet.BackColor = Color.White;

            btn_guncelle.Enabled = true;
            btn_guncelle.BackColor = Color.White;

            btn_sil.Enabled = true;
            btn_sil.BackColor = Color.White;
        }
        private void ButonlarPasif()
        {
            btn_emanet.Enabled = false;
            btn_emanet.BackColor = Color.Gray;

            btn_guncelle.Enabled = false;
            btn_guncelle.BackColor = Color.Gray;

            btn_sil.Enabled = false;
            btn_sil.BackColor = Color.Gray;
        }

        private void cmbBox_listelemeturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                DataSet ds = new DataSet();

                string[] kitap_ozellikleri = { "Ad", "Tur", "Yazar", "Yayinevi", "Fiyat", "yayin_yili", "Eklenme_Tarihi", "Adet", "Aciklama" };
                string[] emanet_ozellikleri = { "Ad", "E_alinmaTarihi", "E_teslimTarihi", "Kullanici", "Kitap" };

                if (cmbBox_listelemeturu.Text == "Kitaplar")
                {

                    ButonlarAktif();
                    KitaplariListele();

                    cmbBox_aramaturu.Items.Clear();
                    cmbBox_aramaturu.Text = "Ad";
                    foreach (string i in kitap_ozellikleri)
                    {
                        cmbBox_aramaturu.Items.Add(i);
                    }

                    SQLiteDataAdapter da = new SQLiteDataAdapter(" SELECT * FROM Kitaplar ", sqlitedb_connstr);
                    da.Fill(ds, "Kitaplar");
                    dGV_liste.DataSource = ds.Tables[0];

                }
                if (cmbBox_listelemeturu.Text == "Emanetler")
                {

                    ButonlarPasif();

                    cmbBox_aramaturu.Items.Clear();
                    cmbBox_aramaturu.Text = " Ad ";
                    foreach (string i in emanet_ozellikleri)
                    {
                        cmbBox_aramaturu.Items.Add(i);
                    }


                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Emanet.id [id] , Emanet.E_alinmaTarihi , Emanet.E_teslimTarihi , Kitaplar.Ad AS [Kitap Adı],Kullanicilar.Ad AS [Kullanıcı Adı] , Kitaplar.id [Kitap id] ,Kullanicilar.id AS [Kullanıcı id] FROM Emanet INNER JOIN Kullanicilar ON Emanet.Kullanici = Kullanicilar.id INNER JOIN Kitaplar ON Emanet.Kitap = Kitaplar.id", sqlitedb_connstr);
                    da.Fill(ds, "Emanet");
                    dGV_liste.DataSource = ds.Tables[0];

                    EmanetleriListele();

                }

            }



        }

    }
}
