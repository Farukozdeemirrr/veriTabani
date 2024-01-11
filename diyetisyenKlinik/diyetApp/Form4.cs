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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        string connectionString = "Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;";
        private void Form4_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                // Bağlantıyı açın
                connection.Open();
                MessageBox.Show("Veritabanına başarıyla bağlandı!");
                // Burada veritabanına bağlandığınızı doğrulamak için bir bildirim gösterilebilir.
                listeAra("SELECT * FROM besinler");
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
        

        private void ekle_Click(object sender, EventArgs e)
        {

            
        }

        private void ekle_Click_1(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO diyetprogramlari (BesinAdi, KaloriMiktari, Karbonhidrat,Protein,Yag) VALUES ('" + besinAdi.Text + "','" + kaloriMiktari.Text + "','" + karbonhidrat.Text + "','" + protein.Text + "','" + yag.Text + "')";
            ESG(insertQuery);
            
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
            this.Hide();
        }
    }
}
