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
    public partial class izinler : Form
    {
        public izinler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");

        private void kaydet()
        {
            try
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Insert into izinler (personel,pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "'", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı!");


            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                izinler ne = new izinler();
                ne.Show();
                this.Hide();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            genel_raporlar genel = new genel_raporlar();
            genel.Show();
            this.Hide();
        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void izinler_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from izinler",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Tüm kayıtlar silindi!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }


        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
