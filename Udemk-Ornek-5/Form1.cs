using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemk_Ornek_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar, alan, cevre, sınav1, sınav2, sınav3, ortalama;
            kısakenar = 10; 
            uzunkenar = 20;
            alan = kısakenar * uzunkenar;
            cevre = (kısakenar * 2) + (uzunkenar * 2);
            label1.Text = "ALAN: " + alan + " ÇEVRE:" + cevre;
            sınav1 = 60;
            sınav2 = 80;
            sınav3 = 45;
            ortalama = (sınav1 + sınav2 + sınav3) / 3;
            label2.Text = "ORTALAMA: " + ortalama;
        }
    }
}
