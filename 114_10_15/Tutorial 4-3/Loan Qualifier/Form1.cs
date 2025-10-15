using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構函式：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 當「資格審查」按鈕被點擊時執行的事件處理函式
        /// 目前尚未實作審查邏輯
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            // TODO: 在此加入貸款資格審查的邏輯
            const decimal MINIMUM_SALARY = 1200000m; // 最低年薪要求
            const int MINIMUM_YEARS = 2; // 最低年資要求
            decimal salary; // 使用者輸入的年薪
            int yearsOnJob; // 使用者輸入的年資

            try 
            {
                salary = decimal.Parse(salaryTextBox.Text); // 解析年薪轉化為 decimal
                yearsOnJob = int.Parse(yearsTextBox.Text); // 解析年資轉化為 int

                // 檢查使用者輸入的年薪及年資是否符合資格
                if (salary >= MINIMUM_SALARY) 
                {
                    if(yearsOnJob>=MINIMUM_YEARS)
                    {
                        decisionLabel.Text = "符合資格";
                    } else
                    {
                        decisionLabel.Text = "不符合資格：年資未達最低標準";
                    }
                        
                } 
                else 
                {
                    decisionLabel.Text = "不符合資格：收入未達最低標準";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 顯示錯誤訊息
            }

        }

        /// <summary>
        /// 當「清除」按鈕被點擊時執行的事件處理函式
        /// 清空年薪、年資輸入欄位及審查結果標籤，並將游標移至年薪欄位
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪輸入欄位
            salaryTextBox.Text = "";
            // 清空年資輸入欄位
            yearsTextBox.Text = "";
            // 清空審查結果標籤
            decisionLabel.Text = "";

            // 將游標移至年薪輸入欄位，方便使用者再次輸入
            salaryTextBox.Focus();
        }

        /// <summary>
        /// 當「離開」按鈕被點擊時執行的事件處理函式
        /// 關閉表單，結束程式
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
