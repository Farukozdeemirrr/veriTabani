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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                // Bağlantıyı açın
                connection.Open();
                MessageBox.Show("Veritabanına başarıyla bağlandı!");
                // Burada veritabanına bağlandığınızı doğrulamak için bir bildirim gösterilebilir.
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
                cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                MessageBox.Show("İşlem başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Bağlantıyı kapat
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
    }
}
