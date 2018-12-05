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
    public partial class stok_listesi : Form
    {
        public stok_listesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ana_menu yeni = new ana_menu();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam_stok yeni = new toplam_stok();
            yeni.Show();
            this.Hide();
        }
    }
}
