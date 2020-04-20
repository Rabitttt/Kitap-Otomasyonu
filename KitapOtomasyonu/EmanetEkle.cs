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

        readonly string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public frm_emanet(string ids)
        {
            InitializeComponent();

            this.Ealinan_KitapID = Convert.ToInt32(ids);

        }

        public int KitapID_Get()
        {
            return Ealinan_KitapID;
        }
        public void KitapID_Set(int s)
        {
            Ealinan_KitapID = s;
        }


        private void btn_emanetekle_Click(object sender, EventArgs e)
        {

            //long deneme = dateTimePicker1.Value.Ticks;
            //MessageBox.Show($"{deneme}")
            //DateTime dtime = new DateTime(deneme);
            //MessageBox.Show(dtime.ToString());

            using (SQLiteConnection baglan = new SQLiteConnection(sqlitedb_connstr))
            {
                using (SQLiteCommand komut = new SQLiteCommand($"INSERT INTO Kullanicilar(Ad,Soyad,Telephone,Adres) VALUES('{txtB_isim.Text}','{txtB_soyisim.Text}','{txtB_telefon.Text}','{rtxtB_adres.Text}')", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        komut.CommandTimeout = 10;
                        komut.ExecuteNonQuery();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

                int rowID = -1;
                using (SQLiteCommand komut = new SQLiteCommand("SELECT last_insert_rowid()",baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        rowID = Convert.ToInt32(komut.ExecuteScalar());
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            //komut.CommandText = "select last_insert_rowid()";
            //rowID = (Int64)komut.ExecuteScalar();
            //MessageBox.Show(rowID.ToString());

                if (rowID == -1)
                {
                    MessageBox.Show("Bir Hata Oluştu...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var komut = new SQLiteCommand($"INSERT INTO Emanet(E_alinmaTarihi,E_teslimTarihi,Kullanici,Kitap) VALUES('{DateTime.Now.ToString()}','{dateTimePicker1.Value.ToString()}','{rowID}','{KitapID_Get()}')", baglan))
                    {
                        try
                        {
                            komut.Connection.Open();
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Başarıyla Oluşturuldu...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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

        private void frm_emanet_Load(object sender, EventArgs e)
        {

        }
    }
}
