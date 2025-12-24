using System;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private enum Choice { None = 0, Stone = 1, Paper = 2, Scissor = 3 }

        private readonly Random rnd = new Random();
        private Choice playerChoice = Choice.None;
        private Choice computerChoice = Choice.None;
        private int playerWins = 0;
        private int computerWins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化：圖片區域為空白，結果為空，統計歸零
            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            resultLabel.Text = string.Empty;
            playerWins = 0;
            computerWins = 0;
        }

        // 產生電腦隨機選擇並儲存
        private void getCompChoice()
        {
            int v = rnd.Next(1, 4); // 1..3
            computerChoice = (Choice)v;
        }

        // 根據電腦選擇顯示圖片
        private void showComputerImage()
        {
            switch (computerChoice)
            {
                case Choice.Stone:
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case Choice.Paper:
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case Choice.Scissor:
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
                default:
                    computerPictureBox.Image = null;
                    break;
            }
        }

        // 根據玩家選擇顯示圖片
        private void showPlayerImage()
        {
            switch (playerChoice)
            {
                case Choice.Stone:
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case Choice.Paper:
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case Choice.Scissor:
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
                default:
                    playerPictureBox.Image = null;
                    break;
            }
        }

        // 比較選擇、更新勝場統計並顯示結果
        private void showWinner()
        {
            if (playerChoice == Choice.None || computerChoice == Choice.None)
            {
                resultLabel.Text = string.Empty;
                return;
            }

            if (playerChoice == computerChoice)
            {
                resultLabel.Text = "平手";
                return; // 平手不記勝場
            }

            bool playerWon = false;

            if (playerChoice == Choice.Stone && computerChoice == Choice.Scissor) playerWon = true;
            else if (playerChoice == Choice.Paper && computerChoice == Choice.Stone) playerWon = true;
            else if (playerChoice == Choice.Scissor && computerChoice == Choice.Paper) playerWon = true;

            if (playerWon)
            {
                playerWins++;
                resultLabel.Text = "玩家贏！";
            }
            else
            {
                computerWins++;
                resultLabel.Text = "電腦贏！";
            }
        }

        // 玩家按下「石頭」
        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Stone;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        // 玩家按下「布」
        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Paper;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        // 玩家按下「剪刀」
        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissor;
            getCompChoice();
            showPlayerImage();
            showComputerImage();
            showWinner();
        }

        // 結束遊戲：顯示統計，確認後關閉程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            string msg = $"遊戲統計：\n玩家勝場：{playerWins} 次\n電腦勝場：{computerWins} 次\n\n按 [確定] 結束程式，按 [取消] 回到遊戲。";
            var dr = MessageBox.Show(msg, "遊戲結束 - 統計", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
