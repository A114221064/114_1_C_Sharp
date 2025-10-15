using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // 初始化所有 UI 元件
        }

        /// <summary>
        /// 當使用者點擊「計算總薪資」按鈕時觸發的事件處理函式
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處可加入薪資計算邏輯
            const decimal OTMULTIPLER = 1.5m; 
            const decimal BASEHOURS = 40m; 

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= BASEHOURS) {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else {
                    
                    grossPay = (BASEHOURS * hourlyPayRate) + ((hoursWorked - BASEHOURS) * hourlyPayRate * OTMULTIPLER);
                }
                grossPayLabel.TextAlign = ContentAlignment.MiddleCenter;
                grossPayLabel.Text = grossPay.ToString("C");

            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 當使用者點擊「清除」按鈕時觸發的事件處理函式
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工時輸入框
            hoursWorkedTextBox.Text = "";
            // 清空時薪輸入框
            hourlyPayRateTextBox.Text = "";
            // 清空總薪資顯示標籤
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入框，方便使用者再次輸入
            hoursWorkedTextBox.Focus();
        }

        /// <summary>
        /// 當使用者點擊「離開」按鈕時觸發的事件處理函式
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
