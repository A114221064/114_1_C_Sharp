namespace North_America
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// 注意：此檔案僅調整元件的 Text 與字型大小、元件尺寸與位置，並加入繁體中文註解。
        /// 其他程式邏輯或事件繫結皆維持原樣，請勿在此檔案以外變更行為。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則釋放受控資源；否則僅釋放非受控資源。</param>
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
        /// 初始化元件：將所有可見文字改為繁體中文、字型大小調為 18、並適度調整大小與位置以符合較大字型。
        /// 註解皆以繁體中文說明每個元件用途與調整內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(354, 346);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 69);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCountriesButton.Location = new System.Drawing.Point(120, 346);
            this.getCountriesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(180, 69);
            this.getCountriesButton.TabIndex = 6;
            this.getCountriesButton.Text = "取得國家";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(24, 17);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(239, 40);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "北美洲的國家";
            // 
            // countriesListBox
            // 
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 40;
            this.countriesListBox.Location = new System.Drawing.Point(30, 75);
            this.countriesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(538, 204);
            this.countriesListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 443);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "北美洲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        protected System.Windows.Forms.OpenFileDialog openFile;
    }
}

