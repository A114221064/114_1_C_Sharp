using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal F_OIL_CHANGE = 780m;
        private const decimal F_LUBRICATION = 540m;
        private const decimal F_RADIATOR_CLEAN = 900m;
        private const decimal F_TRNS_CLEAN = 2400m;
        private const decimal F_INSPECTION = 450m;
        private const decimal F_MUFFLER = 3000m;
        private const decimal F_TIRE_ROTATE = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        private bool isReportSaved = true;

        public Form1()
        {
            InitializeComponent();

            // Designer 不含 textBoxReport / btnSave，移除嘗試存取以避免編譯錯誤
        }

        // 計算方法：機油與潤滑服務費用
        private decimal OilLubeCharges()
        {
            decimal sum = 0m;
            if (checkBox1.Checked) sum += F_OIL_CHANGE;      // 更換機油
            if (checkBox2.Checked) sum += F_LUBRICATION;    // 潤滑保養
            return sum;
        }

        // 計算方法：清洗服務費用
        private decimal FlushCharges()
        {
            decimal sum = 0m;
            if (checkBox7.Checked) sum += F_RADIATOR_CLEAN; // 水箱清洗
            if (checkBox6.Checked) sum += F_TRNS_CLEAN;     // 變速箱清洗
            return sum;
        }

        // 計算方法：其他服務費用
        private decimal MiscCharges()
        {
            decimal sum = 0m;
            if (checkBox4.Checked) sum += F_INSPECTION;     // 檢驗
            if (checkBox3.Checked) sum += F_MUFFLER;        // 更換消音器
            if (checkBox5.Checked) sum += F_TIRE_ROTATE;    // 輪胎換位
            return sum;
        }

        // 計算方法：零件與工時（回傳零件費用與工時費用）
        // 若輸入驗證失敗，回傳 false，out 參數為 0
        private bool OtherCharges(out decimal partsCost, out decimal laborCost)
        {
            partsCost = 0m;
            laborCost = 0m;

            if (!ValidateInputs(out partsCost, out decimal hours))
                return false;

            laborCost = hours * LABOR_RATE_PER_HOUR;
            return true;
        }

        // 計算稅金（零件稅率 6%），四捨五入至整數
        private decimal TaxCharges(decimal partsCost)
        {
            return Math.Round(partsCost * PARTS_TAX_RATE, 0, MidpointRounding.AwayFromZero);
        }

        // 計算所有費用總和，若輸入驗證失敗回傳 false
        private bool TotalCharges(out decimal servicesSum, out decimal laborCost, out decimal serviceAndLaborTotal, out decimal partsCost, out decimal tax, out decimal grandTotal)
        {
            servicesSum = 0m;
            laborCost = 0m;
            serviceAndLaborTotal = 0m;
            partsCost = 0m;
            tax = 0m;
            grandTotal = 0m;

            // 先計算各類服務
            decimal oilLube = OilLubeCharges();
            decimal flushes = FlushCharges();
            decimal misc = MiscCharges();

            servicesSum = oilLube + flushes + misc;

            // 取得零件與工時（並驗證輸入）
            if (!OtherCharges(out partsCost, out laborCost))
                return false;

            serviceAndLaborTotal = servicesSum + laborCost;
            tax = TaxCharges(partsCost);
            grandTotal = serviceAndLaborTotal + partsCost + tax;

            return true;
        }

        // 事件處理：使用者點選「計算」按鈕
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!TotalCharges(out decimal servicesSum, out decimal laborCost, out decimal serviceAndLaborTotal, out decimal partsCost, out decimal tax, out decimal grandTotal))
            {
                // 驗證失敗，已由 ValidateInputs 顯示訊息
                return;
            }

            // 使用文化設定格式化貨幣顯示
            var culture = new CultureInfo("zh-TW");

            // 將計算結果寫入費用摘要的 label（對應 Designer 的 label6/label7/label5/label8）
            // label6 => 服務與工資
            // label7 => 零件
            // label5 => 稅金（零件）
            // label8 => 總費用
            try
            {
                label6.Text = serviceAndLaborTotal.ToString("C0", culture);
                label7.Text = partsCost.ToString("C0", culture);
                label5.Text = tax.ToString("C0", culture);
                label8.Text = grandTotal.ToString("C0", culture);
            }
            catch
            {
                // 若任何 label 不存在或其他問題，忽略
            }

            // 產生完整報表文字（僅供儲存用）
            string report = BuildReport(servicesSum, laborCost, serviceAndLaborTotal, partsCost, tax, grandTotal);

            isReportSaved = false;
        }

        // 事件處理：使用者點選「清除」按鈕
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            isReportSaved = true;
        }

        // 事件處理：使用者點選「離開」按鈕
        // 現在：把「儲存明細」功能合併到離開按鈕內，外觀與按鈕名稱不變
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 先嘗試計算所有費用（並驗證）
            if (!TotalCharges(out decimal servicesSum, out decimal laborCost, out decimal serviceAndLaborTotal, out decimal partsCost, out decimal tax, out decimal grandTotal))
            {
                // 驗證失敗：提示使用者並中止關閉以便修正輸入
                MessageBox.Show("輸入資料有誤或未完成，請修正後再離開以便儲存明細。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 產生完整報表文字
            string report = BuildReport(servicesSum, laborCost, serviceAndLaborTotal, partsCost, tax, grandTotal);

            // 呼叫儲存對話框並儲存（把原本的「儲存明細」功能放進離開按鈕）
            bool saved = SaveServiceDetailsToFile(report);

            if (saved)
            {
                // 儲存成功後關閉，外觀與原先按鈕行為保持不變
                isReportSaved = true;
                Close();
            }
            else
            {
                // 使用者取消或儲存失敗：不關閉，讓使用者決定後續
                // 不改變按鈕外觀或其他行為
            }
        }

        // 清除：機油與潤滑相關選項
        private void ClearOilLube()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        // 清除：清洗服務相關選項
        private void ClearFlushes()
        {
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        // 清除：其他服務相關選項
        private void ClearMisc()
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        // 清除：零件與工時輸入
        private void ClearOther()
        {
            textBoxParts.Text = "0";
            textBoxHours.Text = "0";
        }

        // 清除：費用（會清空費用摘要的 label）
        private void ClearFees()
        {
            try
            {
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                label5.Text = string.Empty;
                label8.Text = string.Empty;
            }
            catch
            {
                // 忽略不存在的控制項
            }
        }

        // 儲存維修明細到檔案（使用對話框，接受報表文字）
        private bool SaveServiceDetailsToFile(string reportText)
        {
            if (string.IsNullOrWhiteSpace(reportText))
            {
                MessageBox.Show("目前沒有要儲存的明細。請先按「計算」產生明細。", "尚無內容", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return false;

            try
            {
                // 使用 UTF8 確保中文顯示正常
                File.WriteAllText(saveFileDialog1.FileName, reportText, Encoding.UTF8);
                MessageBox.Show("已成功儲存明細。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isReportSaved = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message, "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 自動儲存（保留，當使用者以視窗關閉時會執行）
        private bool SaveReportAuto(string reportText, out string savedPath)
        {
            savedPath = null;
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = $"RepairReport_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                savedPath = Path.Combine(folder, fileName);

                File.WriteAllText(savedPath, reportText, Encoding.UTF8);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SaveReportAuto error: " + ex.Message);
                savedPath = null;
                return false;
            }
        }

        // 現存方法：保留並繫結 Designer 事件，轉呼叫新命名事件 (保持與 Designer 相容)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateButton_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Designer 未包含 btnSave；若未來加入可呼叫本方法。
            if (!TotalCharges(out decimal servicesSum, out decimal laborCost, out decimal serviceAndLaborTotal, out decimal partsCost, out decimal tax, out decimal grandTotal))
            {
                MessageBox.Show("輸入資料有誤或未完成，請先修正。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string report = BuildReport(servicesSum, laborCost, serviceAndLaborTotal, partsCost, tax, grandTotal);
            SaveServiceDetailsToFile(report);
        }

        // 輔助：輸入驗證（保留原有行為）
        private bool ValidateInputs(out decimal partsCost, out decimal hours)
        {
            partsCost = 0m;
            hours = 0m;

            // parts
            if (!decimal.TryParse(textBoxParts.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out partsCost) &&
                !decimal.TryParse(textBoxParts.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out partsCost))
            {
                MessageBox.Show("請輸入有效的零件費用數字（以新台幣為單位）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxParts.Focus();
                return false;
            }

            if (partsCost < 0)
            {
                MessageBox.Show("零件費用不可為負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxParts.Focus();
                return false;
            }

            // hours
            if (!decimal.TryParse(textBoxHours.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out hours) &&
                !decimal.TryParse(textBoxHours.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out hours))
            {
                MessageBox.Show("請輸入有效的工時數（可為小數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHours.Focus();
                return false;
            }

            if (hours < 0)
            {
                MessageBox.Show("工時數不可為負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHours.Focus();
                return false;
            }

            return true;
        }

        // 報表生成（保留原有格式）
        private string BuildReport(decimal servicesSum, decimal laborCost, decimal serviceAndLaborTotal, decimal partsCost, decimal tax, decimal grandTotal)
        {
            var culture = new CultureInfo("zh-TW");
            var sb = new StringBuilder();

            sb.AppendLine("==== 汽車維修費用明細 ====");
            sb.AppendLine($"日期時間: {DateTime.Now:yyyy/MM/dd HH:mm:ss}");
            sb.AppendLine();

            sb.AppendLine("已選服務項目：");
            if (checkBox1.Checked) sb.AppendLine($" - 更換機油：{F_OIL_CHANGE.ToString("C0", culture)}");
            if (checkBox2.Checked) sb.AppendLine($" - 潤滑保養：{F_LUBRICATION.ToString("C0", culture)}");
            if (checkBox7.Checked) sb.AppendLine($" - 水箱清洗：{F_RADIATOR_CLEAN.ToString("C0", culture)}");
            if (checkBox6.Checked) sb.AppendLine($" - 變速箱清洗：{F_TRNS_CLEAN.ToString("C0", culture)}");
            if (checkBox4.Checked) sb.AppendLine($" - 檢驗：{F_INSPECTION.ToString("C0", culture)}");
            if (checkBox3.Checked) sb.AppendLine($" - 更換消音器：{F_MUFFLER.ToString("C0", culture)}");
            if (checkBox5.Checked) sb.AppendLine($" - 輪胎換位：{F_TIRE_ROTATE.ToString("C0", culture)}");
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && !checkBox7.Checked)
                sb.AppendLine(" - （無）");

            sb.AppendLine();
            sb.AppendLine("費用明細：");
            sb.AppendLine($" - 服務費用合計：{servicesSum.ToString("C0", culture)}");
            sb.AppendLine($" - 工時費用 ({textBoxHours.Text.Trim()} 小時 × {LABOR_RATE_PER_HOUR.ToString("C0", culture)}/小時)：{laborCost.ToString("C0", culture)}");
            sb.AppendLine($" => 服務與工資總額：{serviceAndLaborTotal.ToString("C0", culture)}");
            sb.AppendLine($" - 零件費用：{partsCost.ToString("C0", culture)}");
            sb.AppendLine($" - 零件稅金 (6%)：{tax.ToString("C0", culture)}");
            sb.AppendLine();
            sb.AppendLine($"總費用：{grandTotal.ToString("C0", culture)}");
            sb.AppendLine("==== 計算依據 ====");
            sb.AppendLine(" - 工時費率：NT$600/小時");
            sb.AppendLine(" - 零件稅率：6%（僅對零件收取）");
            sb.AppendLine();
            sb.AppendLine("感謝您的使用。");

            return sb.ToString();
        }

        // 在關閉視窗前詢問是否儲存（改為自動儲存於「我的文件」）
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 如果已儲存或沒有要儲存的內容，允許關閉
            if (isReportSaved)
                return;

            // 嘗試計算與自動儲存；若計算失敗，詢問是否放棄儲存（並取消關閉）
            if (!TotalCharges(out decimal servicesSum, out decimal laborCost, out decimal serviceAndLaborTotal, out decimal partsCost, out decimal tax, out decimal grandTotal))
            {
                var r = MessageBox.Show("輸入資料有誤或未完成。要放棄儲存並離開嗎？", "未儲存資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    // 允許關閉但不儲存
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            string report = BuildReport(servicesSum, laborCost, serviceAndLaborTotal, partsCost, tax, grandTotal);
            if (!SaveReportAuto(report, out string savedPath))
            {
                var r = MessageBox.Show("自動儲存失敗。要放棄儲存並離開嗎？", "儲存失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    // 允許關閉但不儲存
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                // 成功自動儲存，標記為已儲存（不顯示儲存位置）
                isReportSaved = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
