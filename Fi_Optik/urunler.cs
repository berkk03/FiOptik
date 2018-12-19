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
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from urunler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["barkod"].ToString());
                ekle.SubItems.Add(oku["qr_kod"].ToString());
                ekle.SubItems.Add(oku["marka"].ToString());
                ekle.SubItems.Add(oku["urun_adi"].ToString());
                ekle.SubItems.Add(oku["cam_ozelligi"].ToString());
                ekle.SubItems.Add(oku["lens"].ToString());
                ekle.SubItems.Add(oku["aksesuar"].ToString());
                ekle.SubItems.Add(oku["yedek_parca"].ToString());
                ekle.SubItems.Add(oku["solusyon"].ToString());
                ekle.SubItems.Add(oku["adet"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
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
            urun_ekle yeni = new urun_ekle();
            yeni.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from urunler where ID=(" + textBox2.Text + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listView1.Items.Clear();
            verilerigoster();
        }

       

      
    }
}
