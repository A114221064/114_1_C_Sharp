namespace Cups_To_Ounces
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，表示應釋放受控資源；否則為 false。</param>
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
        /// 設計工具所需方法 — 請勿使用程式碼編輯器修改此方法內容。
        /// 以下方法會初始化表單上的所有元件、設定屬性與位置。
        /// 所有註解皆為繁體中文說明，說明每個元件用途與版面調整原因。
        /// </summary>
        private void InitializeComponent()
        {
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(24, 17);
            this.bannerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(350, 40);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "杯數轉液盎司換算器";
            // 
            // cupsPromptLabel
            // 
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupsPromptLabel.Location = new System.Drawing.Point(42, 86);
            this.cupsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(125, 40);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "杯數：";
            // 
            // cupsTextBox
            // 
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupsTextBox.Location = new System.Drawing.Point(168, 80);
            this.cupsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(238, 48);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouncesLabel.Location = new System.Drawing.Point(241, 154);
            this.ouncesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(343, 49);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 158);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(197, 40);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "液體盎司：";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(48, 228);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(180, 55);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(288, 228);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 55);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 305);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "杯數轉液盎司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label cupsPromptLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

