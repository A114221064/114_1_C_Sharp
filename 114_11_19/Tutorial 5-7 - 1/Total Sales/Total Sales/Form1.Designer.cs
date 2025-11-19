namespace Total_Sales
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理使用的資源。
        /// </summary>
        /// <param name="disposing">若為 true 則釋放受控資源；否則維持現狀。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 此為設計工具所需的方法 — 請勿使用程式碼編輯器直接修改內容。
        /// 以下程式碼已更新：
        /// 1) 將所有顯示文字（Text）確認為繁體中文。
        /// 2) 所有元件字型大小改為 18pt（維持預設字型家族）。
        /// 3) 新增 salesListBox（用以顯示檔案中讀取的文字）。
        /// 4) 根據新增的 listBox 與較大字型適度調整元件大小與相對位置以避免重疊並改善可視性。
        /// 5) 以繁體中文加入註解，說明元件用途與配置理由。
        /// </summary>
        private void InitializeComponent()
        {
            // 建立並設定 salesListBox
            // 用途：顯示從檔案讀取的每一行文字，允許使用者瀏覽原始資料。
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            // 放在表單左側，尺寸較大以容納多筆資料；字型 18pt 以利繁體中文與數字可讀性
            this.salesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.ItemHeight = 29;
            this.salesListBox.Location = new System.Drawing.Point(30, 30);
            this.salesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesListBox.Name = "salesListBox";
            // 高度設定為可顯示多筆清單，避免遮蔽其它控制項
            this.salesListBox.Size = new System.Drawing.Size(300, 444);
            this.salesListBox.TabIndex = 0;
            // 
            // outputDescriptionLabel
            // 
            // 將描述標籤移到 listBox 右側，並使用大字型
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(350, 40);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(197, 40);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "總銷售額：";
            // 
            // totalLabel
            // 
            // 顯示計算結果的方框（有邊框並置中），放置於描述標籤右側以利閱讀
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(560, 30);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(620, 70);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            // 讀取並計算按鈕放在右側中間區域，寬度加大以容納中文長句
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(350, 150);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(600, 80);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "讀取銷售數據並計算總額";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            // 退出按鈕放在計算按鈕右側，維持明顯且容易點擊的位置
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(980, 150);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 80);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 調整視窗大小以符合新增的 listBox 與較大字型配置
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 保留足夠空間以免字體被截斷或元件重疊
            this.ClientSize = new System.Drawing.Size(1232, 574);
            // 將控制項加入表單，注意加入順序會影響 TabIndex 視覺順序
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.salesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "總銷售額";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 以下欄位為表單上的 UI 元件宣告，名稱維持原有以免影響其他程式碼參照
        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

