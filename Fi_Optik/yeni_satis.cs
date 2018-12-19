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
    public partial class yeni_satis : Form
    {
        public yeni_satis()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            satis_islemleri yeni = new satis_islemleri();
            yeni.Show();
            this.Hide();
        }

        private void yeni_satis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into musteriler (musteri_adi,musteri_soyadi,telefon,adres,tarih,tc_no) values ('" + textBox1.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "','" + textBox5.Text.ToString() + "')", baglan);
                SqlCommand komutcuk = new SqlCommand("Insert into satis (barkod,odeme_turu,tutar,musteri_numarası) values ('" + textBox7.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglan);

                komut.ExecuteNonQuery();
                komutcuk.ExecuteNonQuery();

                baglan.Close();
                MessageBox.Show("Satış Başarılı!");
            }
            catch (Exception) { MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz."); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
