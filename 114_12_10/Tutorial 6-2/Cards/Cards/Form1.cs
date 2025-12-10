using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            // 確認有選取項目
            if (cardListBox.SelectedIndex != -1)
            {
                // 修正：使用 SelectedItem 取得被選取的項目字串
                // SelectedItems.ToString() 會回傳集合型別名稱，而非選到的文字，會導致比對失敗
                var selected = cardListBox.SelectedItem as string;

                if (!string.IsNullOrEmpty(selected))
                {
                    // 去除前後空白並傳入顯示函式
                    showSelectedCard(selected.Trim());
                }
                else
                {
                    // 安全性檢查：理論上不會到這裡，但提供友善提示
                    MessageBox.Show("選取的項目無效，請重新選擇。");
                }
            }
            else
            {
                MessageBox.Show("請先選擇一張撲克牌!");
            }
        }
        private void showSelectedCard(string cardName)
        {
            
            switch (cardName)
            {
                case "黑桃A":
                    showAceSpades();
                    break;
                case "紅心10":
                    showTenHearts();
                    break;
                case "梅花K":
                    showKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的撲克牌選擇。");
                    break;
            }
        }

        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
