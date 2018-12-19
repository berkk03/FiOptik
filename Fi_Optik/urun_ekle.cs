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
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            urunler yeni = new urunler();
            yeni.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into urunler (barkod,qr_kod,marka,urun_adi,cam_ozelligi,lens,aksesuar,yedek_parca,solusyon,adet,fiyat) values ('" + textBox1.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı!");
                textBox1.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
            catch(Exception)
            {MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");}
                
        }
    }
}
