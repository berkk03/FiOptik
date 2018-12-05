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
    public partial class toplam_stok : Form
    {
        public toplam_stok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stok_listesi yeni = new stok_listesi();
            yeni.Show();
            this.Hide();
        }
    }
}
