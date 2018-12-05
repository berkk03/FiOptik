using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fi_Optik
{
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler yeni = new urunler();
            yeni.Show();
            this.Hide();
        }
    }
}
