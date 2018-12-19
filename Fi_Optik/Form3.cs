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

            private void aramayap()
            {
                
               try {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Select * FROM musteriler WHERE musteri_adi LIKE '%" + textBox2.Text + "%' ", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = oku["musteri_adi"].ToString();
                        ekle.SubItems.Add(oku["musteri_soyadi"].ToString());
                        ekle.SubItems.Add(oku["telefon"].ToString());
                        ekle.SubItems.Add(oku["tc_no"].ToString());
                        ekle.SubItems.Add(oku["adres"].ToString());
                        ekle.SubItems.Add(oku["tarih"].ToString());
                        listView1.Items.Add(ekle);

                    }
                    baglan.Close();
                }
                catch (Exception) { MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                Form3 fo = new Form3();
                fo.Show();
                this.Hide();
                }
             }
        
        private void verilerigoster()
            {
                try
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("select * from musteriler", baglan);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = oku["musteri_adi"].ToString();
                        ekle.SubItems.Add(oku["musteri_soyadi"].ToString());
                        ekle.SubItems.Add(oku["telefon"].ToString());
                        ekle.SubItems.Add(oku["tc_no"].ToString());
                        ekle.SubItems.Add(oku["adres"].ToString());
                        ekle.SubItems.Add(oku["tarih"].ToString());
                        listView1.Items.Add(ekle);

                    }
                    baglan.Close();
                }
                catch (Exception) { MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                Form3 fo = new Form3();
                fo.Show();
                this.Hide();
                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("delete from musteriler where telefon=(" + textBox1.Text + ")", baglan);
                SqlCommand komutcuk = new SqlCommand("delete from satis where musteri_numarası=(" + textBox1.Text + ")", baglan);
                komut.ExecuteNonQuery();
                komutcuk.ExecuteNonQuery();
                baglan.Close();
                listView1.Items.Clear();
                verilerigoster();
            }
            catch (Exception) { MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            Form3 fo = new Form3();
            fo.Show();
            this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            aramayap();
        }
    }
}
