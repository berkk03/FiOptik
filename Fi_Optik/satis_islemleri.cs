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
    public partial class satis_islemleri : Form
    {
        public satis_islemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BERK-1903;Initial Catalog=FiOptik;Integrated Security=True");
        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select musteri_adi,musteri_soyadi,telefon,barkod,odeme_turu,tutar,CONVERT(NVARCHAR, tarih, 101) as tarih from musteriler,satis where musteriler.telefon=satis.musteri_numarası group by musteri_adi,musteri_soyadi,telefon,barkod,odeme_turu,tutar,tarih", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteri_adi"].ToString();
                ekle.SubItems.Add(oku["musteri_soyadi"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["barkod"].ToString());
                ekle.SubItems.Add(oku["odeme_turu"].ToString());
                ekle.SubItems.Add(oku["tutar"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ana_menu yeni = new ana_menu();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeni_satis yeni = new yeni_satis();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
        }
    }
}
