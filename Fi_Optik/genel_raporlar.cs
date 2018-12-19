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
    public partial class genel_raporlar : Form
    {
        public genel_raporlar()
        {
            InitializeComponent();
        }

        private void genel_raporlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            izinler izin = new izinler();
            izin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ana_menu ana = new ana_menu();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelir_gider ac = new gelir_gider();
            ac.Show();
            this.Hide();

        }
    }
}
