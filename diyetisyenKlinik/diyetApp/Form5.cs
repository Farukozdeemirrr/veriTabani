using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        MySqlConnection connection;
        string connectionString = "Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;";

        private void geri_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                
                connection.Open();
                MessageBox.Show("Veritabanına başarıyla bağlandı!");
                
                listeAra("SELECT * FROM diyetprogramlari");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
            }
        }

        public DataTable listeAra(string sql)
        {
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            return dt;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("your_connection_string_here"))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Randevular (MusteriID, RandevuTarihi, Aciklama, Durum) VALUES (@MusteriID, @RandevuTarihi, @Aciklama, @Durum)", connection);

                    cmd.Parameters.AddWithValue("@MusteriID", 1); 
                    cmd.Parameters.AddWithValue("@RandevuTarihi", DateTime.Now); 
                    cmd.Parameters.AddWithValue("@Aciklama", "Yeni randevu açıklaması");
                    cmd.Parameters.AddWithValue("@Durum", "Beklemede"); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla eklendi.");

                    listeAra("SELECT * FROM Randevular");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }


        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("your_connection_string_here"))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Randevular WHERE RandevuID = @RandevuID", connection);

                    cmd.Parameters.AddWithValue("@RandevuID", 1);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla silindi.");

                    listeAra("SELECT * FROM Randevular");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("your_connection_string_here"))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Randevular SET MusteriID = @MusteriID, RandevuTarihi = @RandevuTarihi, Aciklama = @Aciklama, Durum = @Durum WHERE RandevuID = @RandevuID", connection);

                    cmd.Parameters.AddWithValue("@MusteriID", 2);
                    cmd.Parameters.AddWithValue("@RandevuTarihi", DateTime.Now); 
                    cmd.Parameters.AddWithValue("@Aciklama", "Güncellenmiş randevu açıklaması"); 
                    cmd.Parameters.AddWithValue("@Durum", "Onaylandı");
                    cmd.Parameters.AddWithValue("@RandevuID", 1); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla güncellendi.");

                    listeAra("SELECT * FROM Randevular");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }
    }
}
