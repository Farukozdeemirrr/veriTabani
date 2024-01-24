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
               
                connection.Open();
                MessageBox.Show("Veritabanına başarıyla bağlandı!");
               
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
        

        private void ekle_Click(object sender, EventArgs e)
        {

            
        }

        private void ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;"))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Besinler (BesinAdi, KaloriMiktari, Karbonhidrat, Protein, Yag) VALUES (@BesinAdi, @KaloriMiktari, @Karbonhidrat, @Protein, @Yag)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BesinAdi", besinAdi.Text);
                        cmd.Parameters.AddWithValue("@KaloriMiktari", Convert.ToDecimal(kaloriMiktari.Text));
                        cmd.Parameters.AddWithValue("@Karbonhidrat", Convert.ToDecimal(karbonhidrat.Text));
                        cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(protein.Text));
                        cmd.Parameters.AddWithValue("@Yag", Convert.ToDecimal(yag.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Besin başarıyla eklendi.");

                    }
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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Besinler WHERE BesinID = @BesinID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                     

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Besin başarıyla silindi.");

                        
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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Besinler SET BesinAdi = @BesinAdi, KaloriMiktari = @KaloriMiktari, Karbonhidrat = @Karbonhidrat, Protein = @Protein, Yag = @Yag WHERE BesinID = @BesinID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@BesinAdi", besinAdi.Text);
                        cmd.Parameters.AddWithValue("@KaloriMiktari", Convert.ToDecimal(kaloriMiktari.Text));
                        cmd.Parameters.AddWithValue("@Karbonhidrat", Convert.ToDecimal(karbonhidrat.Text));
                        cmd.Parameters.AddWithValue("@Protein", Convert.ToDecimal(protein.Text));
                        cmd.Parameters.AddWithValue("@Yag", Convert.ToDecimal(yag.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Besin başarıyla güncellendi.");

                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }


        private void geri_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
            this.Hide();
        }
    }
}
