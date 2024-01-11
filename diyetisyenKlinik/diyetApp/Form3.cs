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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hasta_Click(object sender, EventArgs e)
        {
            Form1 form1gecis = new Form1();
            form1gecis.Show();
            this.Hide();
        }

        private void randevu_Click(object sender, EventArgs e)
        {
            Form5 form5gecis = new Form5();
            form5gecis.Show();
            this.Hide();
        }

        private void diyet_Click(object sender, EventArgs e)
        {
            Form4 form4gecis = new Form4();
            form4gecis.Show();
            this.Hide();
        }
    }
}
