using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            StreamReader inputFile;
            decimal totalSales = 0.0m;
            decimal currentSales = 0.0m;
            string line;
            try 
            {
                // 開啟銷售數據文件
                inputFile = File.OpenText("Sales.txt");
                // 讀取並累加每筆銷售數據
                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse( line = inputFile.ReadLine(), out currentSales)) 
                    {
                         salesListBox.Items.Add(line);
                        totalSales += currentSales;
                    }
                    else
                    {
                        MessageBox.Show("無法解析數值: " + line);
                        break;
                    }
                    
                   
                }
                // 關閉文件
                inputFile.Close();
                // 顯示總銷售額
                totalLabel.Text = totalSales.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
