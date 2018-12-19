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
    public partial class yenipersonel_kayit : Form
    {
        public yenipersonel_kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Insert into personel_tanimlari (adi,soyadi,telefon,tc,eposta,adres) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox4.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                musteri_ekle ne = new musteri_ekle();
                ne.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel_tanimlari pe = new personel_tanimlari();
            pe.Show();
            this.Hide();
        }
    }
}
