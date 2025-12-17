using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
           decimal grossPay = 0.0m;
           decimal bonus=0.0m;
           decimal contribution = 0.0m;
            if (InputIsValid(ref grossPay,ref bonus ))
            {
                contribution = CONTRIB_RATE * (grossPay + bonus);
                contributionLabel.Text = 
                    "您的退休金提撥金額為：" + contribution.ToString("c");

            }
            else
            {
                MessageBox.Show("請輸入有效的數值。","輸入錯誤");
            }

        }
        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool isValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("獎金金額輸入無效，請輸入數字。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("總薪資金額輸入無效，請輸入數字。", "輸入錯誤");
            }

            return isValid;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
