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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (var baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                try
                {
                    baglan.Open();
                    
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
                    
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Albl_yazar_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Albl_telefon_Click(object sender, EventArgs e)
        {

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
            Albl_kitapadi.Text = dGV_liste.CurrentRow.Cells["Ad"].Value.ToString();
            Albl_kitapturu.Text = dGV_liste.CurrentRow.Cells["Tur"].Value.ToString();
            Albl_yazar.Text = dGV_liste.CurrentRow.Cells["Yazar"].Value.ToString();
            Albl_yayinevi.Text = dGV_liste.CurrentRow.Cells["Yayinevi"].Value.ToString();
            Albl_fiyat.Text = dGV_liste.CurrentRow.Cells["Fiyat"].Value.ToString();
            Albl_yayin_yili.Text = dGV_liste.CurrentRow.Cells["yayin_yili"].Value.ToString();
            Albl_eklenmeTarihi.Text = dGV_liste.CurrentRow.Cells["Eklenme_Tarihi"].Value.ToString();
            Albl_adet.Text = dGV_liste.CurrentRow.Cells["Adet"].Value.ToString();
            Albl_aciklama.Text = dGV_liste.CurrentRow.Cells["Aciklama"].Value.ToString();

            //string[] dgvCells = { "Ad", "Tur", "Yazar", "Yayinevi", "Fiyat", "yayin_yili", "Eklenme_Tarihi", "Adet", "Aciklama" };


            //Label[] aciklamalar_lbl = new Label[dgvCells.Length];
            //aciklamalar_lbl[] = {Albl_kitapadi, Albl_kitapturu, Albl_yazar, Albl_yayinevi, Albl_fiyat, Albl_yayin_yili, Albl_eklenmeTarihi, Albl_adet, Albl_aciklama };

            //string gecici;

            //for (int i = 0; i < dgvCells.Length; i++)
            //{
            //    gecici = dgvCells[i];
            //    Aciklamalar[i] = dGV_liste.CurrentRow.Cells[gecici].Value.ToString();
            //}

        }
        private void EmanetleriListele()
        {
            

        }

        private void dGV_liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cmbBox_listelemeturu.Text == "Kitaplar")
            {
                KitaplariListele();
            }
            if (cmbBox_listelemeturu.Text == "Emanetler")
            {
                KitaplariListele();
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

        private void cmbBox_listelemeturu_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                DataSet ds = new DataSet();

                string[] kitap_ozellikleri = { "Ad", "Tur", "Yazar", "Yayinevi", "Fiyat", "yayin_yili", "Eklenme_Tarihi", "Adet", "Aciklama" };
                string[] emanet_ozellikleri = { "Ad", "E_alinmaTarihi", "E_teslimTarihi", "Kullanici", "Kitap" };

                if (cmbBox_listelemeturu.Text == "Kitaplar")
                {
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
                    cmbBox_aramaturu.Items.Clear();
                    cmbBox_aramaturu.Text = "Ad";
                    foreach (string i in emanet_ozellikleri)
                    {
                        cmbBox_aramaturu.Items.Add(i);
                    }

                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * From Emanet", sqlitedb_connstr);
                    da.Fill(ds, "Emanet");
                    dGV_liste.DataSource = ds.Tables[0];

                }

            }


        
        }

    }
}
