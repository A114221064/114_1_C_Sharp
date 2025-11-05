using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容：";
            String drink = "";
            String sandwich = "";

            if (coffeeRadioButton.Checked)
            {
                drink = "咖啡";
            }
            else if (milkTeaRadioButton.Checked)
            {
                drink = "奶茶";
            }
            else if (blackTeaRadioButton.Checked)
            {
                drink = "紅茶";
            }
            else if (juiceRadioButton.Checked)
            {
                drink = "果汁";
            }
            else 
            {
                drink = "";
            }


            if (jamsandwichRadioButton.Checked)
            {
                sandwich = "果醬三明治";
            }
            else if (hamsandwichradioButton.Checked)
            {
                sandwich = "火腿三明治";
            }
            else if (tunasandwichButton.Checked)
            {
                sandwich = "鮪魚三明治";
            }
            else 
            {
                sandwich = "";
            }

            message = drink + sandwich;
            MessageBox.Show(message, "您的餐點內容");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
