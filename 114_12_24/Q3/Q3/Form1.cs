using System;
using System.IO;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        private int[] userNumbers = new int[5];
        private int[] winningNumbers = new int[5];
        private Random rnd = new Random();
        private const int MinNumber = 1;
        private const int MaxNumber = 49;
        private bool winningLoaded = false;

        public Form1()
        {
            InitializeComponent();
            // 初始狀態：必須先按「讀取開獎檔案」才能產生號碼
            this.button1.Enabled = false; // 產生號碼
            this.button2.Enabled = true;  // 讀取開獎檔案
            Log("請先按「讀取開獎檔案」以載入本期開獎號碼，載入後才可按「產生號碼」。");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 若尚未讀取開獎號碼，不允許產生
            if (!winningLoaded)
            {
                MessageBox.Show("請先讀取開獎檔案，再產生號碼。", "動作順序", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerateNumbers();
            DisplayUserNumbers();
            Log("已產生號碼，開始比對開獎號碼。");

            int matchCount = CompareNumbers();
            string prize = DeterminePrize(matchCount);
            Log($"比對完成：中獎數量 {matchCount}，獎項：{prize}");
            MessageBox.Show($"比對結果：中 {matchCount} 個號碼\n獎項：{prize}", "比對結果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 使用者可以在不重新讀取檔案的情況下繼續產生新號碼並比對
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 讀取檔案，但不立即比對（先載入開獎號碼，允許產生後再比對）
            bool ok = ReadWinningNumbersFromFile();
            if (!ok) return;

            DisplayWinningNumbers();
            winningLoaded = true;
            this.button1.Enabled = true; // 讀檔成功後允許產生號碼
            Log("已載入開獎號碼，現在可以按「產生號碼」。");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 產生不重複亂數（基本迴圈與條件判斷）
        private void GenerateNumbers()
        {
            for (int i = 0; i < userNumbers.Length; i++)
            {
                int n;
                bool unique;
                do
                {
                    n = rnd.Next(MinNumber, MaxNumber + 1);
                    unique = true;
                    // 檢查與已產生號碼是否重複
                    for (int j = 0; j < i; j++)
                    {
                        if (userNumbers[j] == n)
                        {
                            unique = false;
                            break;
                        }
                    }
                } while (!unique);
                userNumbers[i] = n;
            }
        }

        private void DisplayUserNumbers()
        {
            // 顯示在五個 label 上（簡單映射）
            Label[] labels = new Label[] { label1, label2, label3, label4, label5 };
            for (int i = 0; i < userNumbers.Length; i++)
            {
                labels[i].Text = userNumbers[i].ToString();
            }
        }

        // 讀取開獎檔案（五行，每行一個數字），完整錯誤處理
        private bool ReadWinningNumbersFromFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "選擇開獎號碼文字檔（每行一個數字，共 5 行）";
                ofd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return false;

                try
                {
                    string[] lines;
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        // 讀取所有非空白行
                        var temp = new System.Collections.Generic.List<string>();
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line != null)
                            {
                                line = line.Trim();
                                if (line.Length > 0) temp.Add(line);
                            }
                        }
                        lines = temp.ToArray();
                    }

                    if (lines.Length != 5)
                    {
                        MessageBox.Show("檔案格式錯誤：檔案必須包含 5 行，每行一個數字。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // 解析並檢查範圍與重複
                    for (int i = 0; i < 5; i++)
                    {
                        int val;
                        if (!Int32.TryParse(lines[i], out val))
                        {
                            MessageBox.Show($"第 {i + 1} 行不是有效整數：'{lines[i]}'", "解析錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        if (val < MinNumber || val > MaxNumber)
                        {
                            MessageBox.Show($"第 {i + 1} 行數字超出範圍（{MinNumber} 至 {MaxNumber}）：{val}", "數字超出範圍", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        // 檢查與之前是否重複
                        for (int j = 0; j < i; j++)
                        {
                            if (winningNumbers[j] == val)
                            {
                                MessageBox.Show($"檔案第 {i + 1} 行數字與前面重複：{val}", "重複號碼", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        winningNumbers[i] = val;
                    }

                    Log($"已讀取開獎檔案：{Path.GetFileName(ofd.FileName)}");
                    return true;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("檔案不存在。", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("無法存取檔案（權限不足）。", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("讀取檔案時發生 IO 錯誤：" + ex.Message, "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未知錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void DisplayWinningNumbers()
        {
            listBoxWinning.Items.Clear();
            for (int i = 0; i < winningNumbers.Length; i++)
            {
                listBoxWinning.Items.Add($"第 {i + 1} 個號碼：{winningNumbers[i]}");
            }
        }

        // 比對使用者號碼與開獎號碼（不考慮順序）
        private int CompareNumbers()
        {
            int count = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                for (int j = 0; j < winningNumbers.Length; j++)
                {
                    if (userNumbers[i] == winningNumbers[j])
                    {
                        count++;
                        break; // 每個使用者號碼只算一次
                    }
                }
            }
            return count;
        }

        private string DeterminePrize(int matchCount)
        {
            // 範例獎項對應：5->頭獎、4->二獎、3->三獎、2->四獎、1->普獎、0->未中獎
            if (matchCount == 5) return "頭獎";
            if (matchCount == 4) return "貳獎";
            if (matchCount == 3) return "參獎";
            if (matchCount == 2) return "肆獎";
            if (matchCount == 1) return "普獎";
            return "未中獎";
        }

        private void Log(string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            textBoxLog.AppendText($"[{time}] {message}{Environment.NewLine}");
        }
    }
}
