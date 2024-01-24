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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace diyetApp
{
    public partial class Form2 : Form
    {

        MySqlConnection connection;
        string connectionString = "Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;";
        private object programAciklamasi;
        private object bitisTarihi;
        private object diyetProgramiID;
        private object musteriID;
        private object besinID;
        private object baslangicTarihi;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        public void ESG(string sorgu)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(sorgu, connection);
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("İşlem başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            listeAra("SELECT * FROM diyetprogramlari WHERE MusteriID LIKE '%" + ara.Text + "%'");
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            //store prosedür yazdım fakat c#'da nasıl çağırılıyor bilmiyorum.
            string insertQuery = "INSERT INTO diyetprogramlari (BaslangicTarihi, BitisTarihi, ProgramAciklamasi) VALUES ('" + baslangic.Text + "','" + bitis.Text + "','" + aciklama.Text + "')";
            ESG(insertQuery);
            listeAra("SELECT * FROM diyetprogramlari");
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("your_connection_string_here"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM DiyetProgramlari WHERE DiyetProgramiID = @DiyetProgramiID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@DiyetProgramiID", Convert.ToInt32(diyetProgramiID));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Diyet programı başarıyla silindi.");

                        
                    }
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

                    string updateQuery = "UPDATE DiyetProgramlari SET MusteriID = @MusteriID, BesinID = @BesinID, BaslangicTarihi = @BaslangicTarihi, BitisTarihi = @BitisTarihi, ProgramAciklamasi = @ProgramAciklamasi WHERE DiyetProgramiID = @DiyetProgramiID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@DiyetProgramiID", Convert.ToInt32(diyetProgramiID)); 
                        cmd.Parameters.AddWithValue("@MusteriID", Convert.ToInt32(musteriID));
                        cmd.Parameters.AddWithValue("@BesinID", Convert.ToInt32(besinID)); 
                        cmd.Parameters.AddWithValue("@BaslangicTarihi", Convert.ToDateTime(baslangicTarihi)); 
                        cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi); 
                        cmd.Parameters.AddWithValue("@ProgramAciklamasi", programAciklamasi); 

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Diyet programı başarıyla güncellendi.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

    }
}
