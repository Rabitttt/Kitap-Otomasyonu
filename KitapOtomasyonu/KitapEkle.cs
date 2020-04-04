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

    

    public partial class form_KitapEkle : Form
    {

        string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public form_KitapEkle()
        {
            InitializeComponent();

            txtB_adet.Text = "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            double fiyat = 0;
            if (string.IsNullOrEmpty(txtB_kitapadi.Text))
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Bıraklılamaz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string eklenme_tarihi = DateTime.Now.ToString();

                try
                {
                    int yayin_tarihi = Convert.ToInt32(txtB_yayinyili.Text);
                    fiyat = Convert.ToDouble(txtB_fiyat.Text);

                    using (var baglan = new SQLiteConnection(sqlitedb_connstr))
                    {
                        using (var komut = new SQLiteCommand($"INSERT INTO Kitaplar(Ad,Tur,Eklenme_Tarihi,Yayinevi,Aciklama,Fiyat,yayin_yili) VALUES('{txtB_kitapadi.Text}','{cmbB_kitapturu.Text}','{eklenme_tarihi}','{txtB_Yayinevi.Text}','{rtxtB_aciklama.Text}','{Convert.ToDouble(txtB_fiyat.Text)}','{Convert.ToInt32(txtB_yayinyili.Text)}')", baglan))
                        {

                            try
                            {
                                komut.Connection.Open();
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Kitap Başarıyla Eklendi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(hata.Message);

                            }
                        }

                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Lutfen Tarih ve Fiyat Alanını 'Sayı' ile Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtB_kitapadi_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void rtxtB_aciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
