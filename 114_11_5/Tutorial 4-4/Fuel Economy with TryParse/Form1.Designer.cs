namespace Fuel_Economy_with_TryParse
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// 必要的設計器變數。此處以繁體中文註解說明用途與釋放時機。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。disposing 為 true 時會釋放受控資源（components）。
        /// 清除任何使用中的資源。disposing 為 true 時會釋放受控資源（components）。
        /// 清除任何使用中的資源。disposing 為 true 時會釋放受控資源（components）。
        /// </summary>
        /// <param name="disposing">如果為 true，表示應該釋放受控資源；否則只釋放非受控資源。</param>
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
        /// 此方法為設計器所需的方法。不要手動修改以避免設計器失效。
        /// 這裡已將所有元件 Text 改為繁體中文，並將表單字型大小設定為 18（讓子控制項繼承）。
        /// 同時調整部分控制項尺寸與位置以符合較大的字型顯示。
        /// 此方法為設計器所需的方法。不要手動修改以避免設計器失效。
        /// 這裡已將所有元件 Text 改為繁體中文，並將表單字型大小設定為 18（讓子控制項繼承）。
        /// 同時調整部分控制項尺寸與位置以符合較大的字型顯示。
        /// 此方法為設計器所需的方法。不要手動修改以避免設計器失效。
        /// 這裡已將所有元件 Text 改為繁體中文，並將表單字型大小設定為 18（讓子控制項繼承）。
        /// 同時調整部分控制項尺寸與位置以符合較大的字型顯示。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(589, 492);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(490, 142);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(61, 492);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(490, 142);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "計算 MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(545, 284);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(520, 100);
            this.mpgLabel.TabIndex = 13;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(32, 314);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(493, 40);
            this.outputDescriptionLabel.TabIndex = 12;
            this.outputDescriptionLabel.Text = "您車輛的每加侖英里 (MPG)：";
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(440, 185);
            this.gallonsTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(515, 48);
            this.gallonsTextBox.TabIndex = 11;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(380, 47);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(515, 48);
            this.milesTextBox.TabIndex = 10;
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(32, 185);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(413, 40);
            this.gallonsPromptLabel.TabIndex = 9;
            this.gallonsPromptLabel.Text = "輸入使用的汽油加侖數：";
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(32, 55);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(341, 40);
            this.milesPromptLabel.TabIndex = 8;
            this.milesPromptLabel.Text = "輸入行駛的英里數：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 795);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label milesPromptLabel;
    }
}

