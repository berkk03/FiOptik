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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
            SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
            private void verilerigoster()
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from musteriler",baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["musteri_adi"].ToString();
                    ekle.SubItems.Add(oku["musteri_soyadi"].ToString());
                    ekle.SubItems.Add(oku["telefon"].ToString());
                    ekle.SubItems.Add(oku["adres"].ToString());
                    ekle.SubItems.Add(oku["tarih"].ToString());
                    listView1.Items.Add(ekle);
                    
                }
                baglan.Close();
            }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ana_menu yeni = new ana_menu();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri_ekle git =new musteri_ekle();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
