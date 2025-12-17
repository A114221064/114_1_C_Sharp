using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
           const int SIZE = 5; // Number of lottery numbers to generate
           int[] lotteryNumbers = new int[SIZE];
            Label[] labels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            Random random = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                lotteryNumbers[i] = random.Next(1, 50); // Generate numbers between 1 and 49
            }
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
