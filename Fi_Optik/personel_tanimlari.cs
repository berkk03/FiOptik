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
    public partial class personel_tanimlari : Form
    {
        public personel_tanimlari()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");

        private void aramayap()
        {

            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * FROM personel_tanimlari WHERE adi LIKE '%" + textBox2.Text + "%' ", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["adi"].ToString();
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telefon"].ToString());
                    ekle.SubItems.Add(oku["tc"].ToString());
                    ekle.SubItems.Add(oku["eposta"].ToString());
                    ekle.SubItems.Add(oku["adres"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                Form3 fo = new Form3();
                fo.Show();
                this.Hide();
            }
        }
        private void kayitlar()
        {

            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * FROM personel_tanimlari", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["adi"].ToString();
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telefon"].ToString());
                    ekle.SubItems.Add(oku["tc"].ToString());
                    ekle.SubItems.Add(oku["eposta"].ToString());
                    ekle.SubItems.Add(oku["adres"].ToString());
                    listView1.Items.Add(ekle);

                }
                baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                personel_tanimlari fo = new personel_tanimlari();
                fo.Show();
                this.Hide();
            }
        }
        private void sil()
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("delete from personel_tanimlari where telefon=("+textBox1.Text+")",baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                listView1.Items.Clear();
                kayitlar();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                personel_tanimlari fo = new personel_tanimlari();
                fo.Show();
                this.Hide();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            yenipersonel_kayit ye = new yenipersonel_kayit();
            ye.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayitlar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            aramayap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ana_menu ana = new ana_menu();
            ana.Show();
            this.Hide();
        }
    }
}
