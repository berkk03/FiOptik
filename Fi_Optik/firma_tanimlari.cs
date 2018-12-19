using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fi_Optik
{
    public partial class firma_tanimlari : Form
    {
        public firma_tanimlari()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ana_menu ac = new ana_menu();
            ac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilgileri_duzenle ac = new bilgileri_duzenle();
            ac.Show();
            this.Hide();
        }

        private void firma_tanimlari_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * FROM firma_tanimlari ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                label9.Text = oku["firma_adi"].ToString();
                label10.Text=oku["yetkili"].ToString();
                label11.Text = oku["telefon1"].ToString();
                label12.Text = oku["telefon2"].ToString();
                label13.Text = oku["telefon3"].ToString();
                label14.Text = oku["tc"].ToString();
                label15.Text = oku["vergi_no"].ToString();
                label16.Text = oku["adres"].ToString();

            }
            baglan.Close();


        }
    }
}
