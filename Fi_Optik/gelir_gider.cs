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
    public partial class gelir_gider : Form
    {
        public gelir_gider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genel_raporlar ac = new genel_raporlar();
            ac.Show();
            this.Hide();

        }
    }
}
