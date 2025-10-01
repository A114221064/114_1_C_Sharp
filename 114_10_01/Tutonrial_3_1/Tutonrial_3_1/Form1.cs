using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutonrial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showdate_Click(object sender, EventArgs e)
        {
            string dayOFweek;
            dayOFweek = dayofweekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearsTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string output = "中華民國"+year + "年" + month + "月" + dayOfMonth + "日" + ",星期"+dayOFweek;
            dateOutput.Text = output;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            dayofweekTextBox.Text = "";
            monthTextBox.Text = "";
            yearsTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            dateOutput.Text = "";
        }
    }
}
