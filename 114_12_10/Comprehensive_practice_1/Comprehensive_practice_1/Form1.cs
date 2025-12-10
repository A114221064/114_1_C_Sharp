using System;
using System.Linq;
using System.Windows.Forms;

namespace Comprehensive_practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowMax_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string givenName = textBoxGiven.Text;
            int q1, q2, q3;
            if (int.TryParse(textBoxQ1.Text,out q1)&& 
                int.TryParse(textBoxQ2.Text, out q2) &&
                int.TryParse(textBoxQ3.Text, out q3) )
            {
                showResult(surname, givenName, q1, q2, q3);
            }else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
                clearTextBoxes();
            }



            // 解析三個小考成績，若解析失敗顯示錯誤
            //  int s1, s2, s3;
            // bool ok1 = int.TryParse(textBoxQ1.Text.Trim(), out s1);
            // bool ok2 = int.TryParse(textBoxQ2.Text.Trim(), out s2);
            //bool ok3 = int.TryParse(textBoxQ3.Text.Trim(), out s3);

            //if (!ok1 || !ok2 || !ok3)
            // {
            //    MessageBox.Show("請確認三個小考成績皆為整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // int[] scores = new int[] { s1, s2, s3 };
            // int max = scores.Max();
            // int index = Array.IndexOf(scores, max) + 1; // 取得是小考1/2/3

            // labelResult.Text = $"最高分: {max} (小考{index})";
        }

        private void showResult(string surname, string givenName, int q1, int q2, int q3)
        {
            int highestScore;
            if (q1>=q2 && q2>= q3)
            {
                highestScore = q1;
            }
            else if (q2 >=q1&& q2>= q3)
            {
                highestScore = q2;
            }else
            {
                highestScore = q3;
            }
            q2 = 200; // test debug
            lblResult.Text = $"{surname}{givenName}，你的最高分是 {highestScore} 分";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearTextBoxes()
        {
            textBoxQ1.Clear();
            textBoxQ2.Clear();
            textBoxQ3.Clear();
            textBoxQ1.Focus();
        }
    }
}
