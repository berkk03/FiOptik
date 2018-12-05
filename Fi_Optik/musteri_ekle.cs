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
    public partial class musteri_ekle : Form
    {
        public musteri_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                baglan.Open();
         
            SqlCommand komut = new SqlCommand("Insert into musteriler (musteri_adi,musteri_soyadi,telefon,adres,tarih) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + DateTime.Now.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı!");
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }
    }
}
