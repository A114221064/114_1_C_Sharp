namespace Lottery_Numbers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所使用的資源。
        /// </summary>
        /// <param name="disposing">若為 true 表示需要釋放管理資源，否則為 false。</param>
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
        /// 設計工具所需的方法 — 請勿手動更動此方法以外之內容（僅修改註解與屬性以繁體中文）。
        /// 以下初始化所有元件，並調整字型為 18，適度放大並重新定位元件以利顯示。
        /// </summary>
        private void InitializeComponent()
        {
            // 標示用的五個 Label，顯示產生出來的號碼。
            // 將字型改為 18pt 粗體以利閱讀，並調整尺寸與間距。
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();

            // 兩個按鈕：產生號碼、離開。字型改為 18pt，按鈕尺寸放大以便使用者操作。
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // firstLabel
            // 
            // 此 Label 用來顯示第一個號碼，預設為空白，中心對齊。
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(12, 12);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(64, 48);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLabel
            // 
            // 此 Label 用來顯示第二個號碼，與第一個置於同一水平線。
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(84, 12);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(64, 48);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdLabel
            // 
            // 此 Label 用來顯示第三個號碼，與前兩個等間距排列。
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(156, 12);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(64, 48);
            this.thirdLabel.TabIndex = 2;
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthLabel
            // 
            // 此 Label 用來顯示第四個號碼。
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthLabel.Location = new System.Drawing.Point(228, 12);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(64, 48);
            this.fourthLabel.TabIndex = 3;
            this.fourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthLabel
            // 
            // 此 Label 用來顯示第五個號碼。
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthLabel.Location = new System.Drawing.Point(300, 12);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(64, 48);
            this.fifthLabel.TabIndex = 4;
            this.fifthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            // 按下此按鈕會產生一組號碼。文字以繁體中文顯示，字型與大小已調整。
            this.generateButton.Location = new System.Drawing.Point(96, 72);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(120, 44);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "產生號碼";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            // 按下此按鈕關閉表單（離開程式）。
            this.exitButton.Location = new System.Drawing.Point(232, 72);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 調整表單大小以容納放大的標籤與按鈕，並將標題改為繁體中文。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 130);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "Form1";
            this.Text = "樂透號碼產生器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

