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
    public partial class bilgileri_duzenle : Form
    {
        public bilgileri_duzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bilgileri_duzenle_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("insert into firma_tanimlari (firma_adi,yetkili,telefon1,telefon2,telefon3,tc,vergi_no,adres) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
            catch (Exception) { MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            bilgileri_duzenle ne = new bilgileri_duzenle();
            ne.Show();
            this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firma_tanimlari ac = new firma_tanimlari();
            ac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from firma_tanimlari",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Tüm kayıtlar silindi!");
        }
    }
}
