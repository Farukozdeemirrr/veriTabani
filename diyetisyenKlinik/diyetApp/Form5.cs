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
    }
}
