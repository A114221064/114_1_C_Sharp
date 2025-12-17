namespace Pay_and_Bonus
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數（自動產生）。
        /// 下方 InitializeComponent 已將所有元件的 Text 屬性改為繁體中文，
        /// 並將各元件字型設定為 18pt，適度調整元件大小與相對位置以符合較大字型顯示需求。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源為 true，否則為 false。</param>
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
        /// 設計工具所需的方法 — 請勿使用程式碼編輯器變更此方法內容。
        /// 變更內容：
        /// - 所有 Text 屬性改為繁體中文
        /// - 所有元件字型改為 18pt
        /// - 調整元件大小與位置以配合較大字型
        /// - 以繁體中文加入詳細註解（下方各元件區塊前）
        /// </summary>
        private void InitializeComponent()
        {
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossPayPromptLabel
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayPromptLabel.Location = new System.Drawing.Point(20, 20);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(161, 40);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "總薪資：";
            // 
            // bonusPromptLabel
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusPromptLabel.Location = new System.Drawing.Point(20, 70);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(197, 40);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "獎金金額：";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayTextBox.Location = new System.Drawing.Point(220, 18);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(367, 48);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusTextBox.Location = new System.Drawing.Point(220, 68);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(367, 48);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 120);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(197, 40);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "退休提撥：";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionLabel.Location = new System.Drawing.Point(220, 118);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(923, 36);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(60, 180);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(177, 50);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算提撥";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(362, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "薪資與獎金";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

