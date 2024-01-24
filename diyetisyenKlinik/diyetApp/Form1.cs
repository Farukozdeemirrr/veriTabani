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

namespace diyetApp
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        string connectionString = "Server=localhost;Database=diyetisyensql;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                
                connection.Open();
                MessageBox.Show("Veritabanına başarıyla bağlandı!");
                
                listeAra("SELECT * FROM musteriler");
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

        private void musteriSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
            
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);

                
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("MusteriSil", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_MusteriID", musteriID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla silindi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri silme hatası: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                isim.Text = row.Cells["Isim"].Value.ToString();
                soyisim.Text = row.Cells["Soyisim"].Value.ToString();
                cinsiyet.Text = row.Cells["Cinsiyet"].Value.ToString();
                tarih.Text = row.Cells["DogumTarihi"].Value.ToString();
                telefon.Text = row.Cells["Telefon"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                adres.Text = row.Cells["Adres"].Value.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    string musteriIsim = dataGridView1.Rows[selectedRowIndex].Cells["Isim"].Value.ToString();



                    musteriSil(musteriIsim);

               
                    listeAra("SELECT * FROM musteriler");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.");
                }
            }
        }

        private void musteriSil(String musteriIsim)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);


                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("MusteriSil", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_MusteriID", musteriID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla silindi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri silme hatası: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin.");
            }
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            listeAra("SELECT * FROM musteriler WHERE Isim LIKE '%" + ara.Text + "%' OR Soyisim LIKE '%" + ara.Text + "%'");

        }



        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();  // Bağlantıyı açın

                using (MySqlCommand cmd = new MySqlCommand("MusteriEkle", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametrelerin eklenmesi
                    cmd.Parameters.AddWithValue("@Isim", isim.Text);
                    cmd.Parameters.AddWithValue("@Soyisim", soyisim.Text);
                    cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@DogumTarihi", tarih.Text);
                    cmd.Parameters.AddWithValue("@Telefon", telefon.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Adres", adres.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri başarıyla eklendi.");
                listeAra("SELECT * FROM musteriler");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri ekleme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(isim.Text))
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçin.");
                    return;
                }

                MySqlCommand cmd = new MySqlCommand("MusteriGuncelle", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Isim", isim.Text);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", tarih.Text);
                cmd.Parameters.AddWithValue("@Telefon", telefon.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Adres", adres.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla güncellendi.");

               
                listeAra("SELECT * FROM musteriler");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
            this.Hide();
        }
    }
}
