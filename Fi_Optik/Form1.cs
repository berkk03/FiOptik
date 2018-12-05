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
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from admin where personel_isim='" + textBox1.Text + "'and personel_sifre='" + textBox2.Text + "'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) { 
                ana_menu yeni = new ana_menu();
            yeni.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            
        }
    }
}
