using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 當使用者按下「計算折扣後價格」按鈕時觸發的事件處理函式。
        /// 會讀取原價與折扣百分比，計算折扣後價格並顯示於 salePriceLabel。
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;      // 商品原價
            decimal discountPercentage; // 折扣百分比
            decimal salePrice;          // 折扣後價格

            // 取得原價輸入框的文字並轉為 decimal 型別
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            // 取得折扣百分比輸入框的文字並轉為 decimal 型別
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 計算折扣後價格：原價 * (1 - 折扣百分比 / 100)
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 將計算結果以貨幣格式顯示在 salePriceLabel
            salePriceLabel.Text = salePrice.ToString("C");
        }

        /// <summary>
        /// 當使用者按下「離開」按鈕時觸發的事件處理函式。
        /// 會關閉目前的表單（結束程式）。
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
