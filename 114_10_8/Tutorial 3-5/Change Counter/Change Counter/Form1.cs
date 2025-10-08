using System;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        private decimal total ;
        const decimal FIVE_CENT =5.0m;
        const decimal TEN_CENT = 10.0m;
        const decimal TWENTY_FIVE_CENT = 25.0m;
        const decimal FIFTY_CENT = 50.0m;

        public Form1()
        {
            InitializeComponent();
        }

        // 5分硬幣點擊事件
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
           
            total += FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        // 10分硬幣點擊事件
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {

            total += TEN_CENT;
            totalLabel.Text = total.ToString();
        }

        // 25分硬幣點擊事件
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {

            total += TWENTY_FIVE_CENT;
            totalLabel.Text = total.ToString();
        }

        // 50分硬幣點擊事件
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {

            total += FIFTY_CENT;
            totalLabel.Text = total.ToString();
        }

        // 離開按鈕點擊事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 更新總額顯示
        private void UpdateTotalLabel()
        {
            totalLabel.Text = total.ToString("C2");
        }
    }
}
