using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2
{
    public partial class Form1 : Form
    {
        private decimal total;
        const decimal BANANA = 115;
        const decimal APPLE = 80;
        const decimal ORANGE = 90;
        const decimal PEAR = 120;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += BANANA;
            showTotal.Text = total.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            total +=APPLE;
            showTotal.Text = total.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            total += ORANGE;
            showTotal.Text = total.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            total += PEAR;
            showTotal.Text = total.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            total = 0;
            showTotal.Text = "0";
        }
    }
}
