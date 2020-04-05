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
    public partial class frm_emanet : Form
    {

        private int Ealinan_KitapID;

        public int KitapID_Get()
        {
            return Ealinan_KitapID;
        }
        public void KitapID_Set(int s)
        {
            Ealinan_KitapID = s;
        }
        

        public frm_emanet(string ids)
        {
            InitializeComponent();

            int EverilenKitap_id = Convert.ToInt32(ids);

            KitapID_Set(EverilenKitap_id);
        }

        string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        private void frm_emanet_Load(object sender, EventArgs e)
        {

        }

        private void lbl_teslimTarihi_Click(object sender, EventArgs e)
        {

        }

        private void btn_emanetekle_Click(object sender, EventArgs e)
        {

            //long deneme = dateTimePicker1.Value.Ticks;
            //MessageBox.Show($"{deneme}")
            //DateTime dtime = new DateTime(deneme);
            //MessageBox.Show(dtime.ToString());

            using (var baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                Int64 rowID = -1;
                using (SQLiteCommand komut = new SQLiteCommand($"INSERT INTO Kullanicilar(Ad,Soyad,Telephone,Adres) VALUES('{txtB_isim.Text}','{txtB_soyisim.Text}','{txtB_telefon.Text}','{rtxtB_adres.Text}')", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        komut.ExecuteNonQuery();
                        
                        komut.CommandText = "select last_insert_rowid()";

                        rowID = (Int64)komut.ExecuteScalar();

                        MessageBox.Show($"{(int)rowID}");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(rowID == -1)
                {
                    MessageBox.Show("Bir Hata Oluştu...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
                else
                {

                using (var komut = new SQLiteCommand($"INSERT INTO Emanet(E_alinmaTarihi,E_teslimTarihi,Kullanici,Kitap) VALUES('{DateTime.Now.ToString()}','{dateTimePicker1.Value.ToString()}','{rowID}','{KitapID_Get()}')", baglan))
                {
                    try
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Oluşturuldu...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    //transaction.Commit();

                }
            }
        
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
