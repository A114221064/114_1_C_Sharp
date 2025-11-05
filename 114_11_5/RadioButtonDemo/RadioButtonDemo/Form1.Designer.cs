namespace RadioButtonDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.coffeeRadioButton = new System.Windows.Forms.RadioButton();
            this.milkTeaRadioButton = new System.Windows.Forms.RadioButton();
            this.blackTeaRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceRadioButton = new System.Windows.Forms.RadioButton();
            this.tunasandwichButton = new System.Windows.Forms.RadioButton();
            this.hamsandwichradioButton = new System.Windows.Forms.RadioButton();
            this.jamsandwichRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeRadioButton
            // 
            this.coffeeRadioButton.AutoSize = true;
            this.coffeeRadioButton.Location = new System.Drawing.Point(49, 22);
            this.coffeeRadioButton.Name = "coffeeRadioButton";
            this.coffeeRadioButton.Size = new System.Drawing.Size(69, 22);
            this.coffeeRadioButton.TabIndex = 0;
            this.coffeeRadioButton.TabStop = true;
            this.coffeeRadioButton.Text = "咖啡";
            this.coffeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // milkTeaRadioButton
            // 
            this.milkTeaRadioButton.AutoSize = true;
            this.milkTeaRadioButton.Location = new System.Drawing.Point(49, 71);
            this.milkTeaRadioButton.Name = "milkTeaRadioButton";
            this.milkTeaRadioButton.Size = new System.Drawing.Size(69, 22);
            this.milkTeaRadioButton.TabIndex = 1;
            this.milkTeaRadioButton.TabStop = true;
            this.milkTeaRadioButton.Text = "奶茶";
            this.milkTeaRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackTeaRadioButton
            // 
            this.blackTeaRadioButton.AutoSize = true;
            this.blackTeaRadioButton.Location = new System.Drawing.Point(49, 116);
            this.blackTeaRadioButton.Name = "blackTeaRadioButton";
            this.blackTeaRadioButton.Size = new System.Drawing.Size(69, 22);
            this.blackTeaRadioButton.TabIndex = 2;
            this.blackTeaRadioButton.TabStop = true;
            this.blackTeaRadioButton.Text = "紅茶";
            this.blackTeaRadioButton.UseVisualStyleBackColor = true;
            // 
            // juiceRadioButton
            // 
            this.juiceRadioButton.AutoSize = true;
            this.juiceRadioButton.Location = new System.Drawing.Point(49, 167);
            this.juiceRadioButton.Name = "juiceRadioButton";
            this.juiceRadioButton.Size = new System.Drawing.Size(69, 22);
            this.juiceRadioButton.TabIndex = 3;
            this.juiceRadioButton.TabStop = true;
            this.juiceRadioButton.Text = "果汁";
            this.juiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // tunasandwichButton
            // 
            this.tunasandwichButton.AutoSize = true;
            this.tunasandwichButton.Location = new System.Drawing.Point(6, 130);
            this.tunasandwichButton.Name = "tunasandwichButton";
            this.tunasandwichButton.Size = new System.Drawing.Size(123, 22);
            this.tunasandwichButton.TabIndex = 4;
            this.tunasandwichButton.TabStop = true;
            this.tunasandwichButton.Text = "鮪魚三明治";
            this.tunasandwichButton.UseVisualStyleBackColor = true;
            // 
            // hamsandwichradioButton
            // 
            this.hamsandwichradioButton.AutoSize = true;
            this.hamsandwichradioButton.Location = new System.Drawing.Point(6, 85);
            this.hamsandwichradioButton.Name = "hamsandwichradioButton";
            this.hamsandwichradioButton.Size = new System.Drawing.Size(123, 22);
            this.hamsandwichradioButton.TabIndex = 5;
            this.hamsandwichradioButton.TabStop = true;
            this.hamsandwichradioButton.Text = "火腿三明治";
            this.hamsandwichradioButton.UseVisualStyleBackColor = true;
            // 
            // jamsandwichRadioButton
            // 
            this.jamsandwichRadioButton.AutoSize = true;
            this.jamsandwichRadioButton.Location = new System.Drawing.Point(6, 36);
            this.jamsandwichRadioButton.Name = "jamsandwichRadioButton";
            this.jamsandwichRadioButton.Size = new System.Drawing.Size(123, 22);
            this.jamsandwichRadioButton.TabIndex = 6;
            this.jamsandwichRadioButton.TabStop = true;
            this.jamsandwichRadioButton.Text = "果醬三明治";
            this.jamsandwichRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juiceRadioButton);
            this.groupBox1.Controls.Add(this.blackTeaRadioButton);
            this.groupBox1.Controls.Add(this.milkTeaRadioButton);
            this.groupBox1.Controls.Add(this.coffeeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 238);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jamsandwichRadioButton);
            this.groupBox2.Controls.Add(this.hamsandwichradioButton);
            this.groupBox2.Controls.Add(this.tunasandwichButton);
            this.groupBox2.Location = new System.Drawing.Point(226, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 235);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(56, 338);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(151, 65);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "送出訂單";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 65);
            this.button2.TabIndex = 10;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton coffeeRadioButton;
        private System.Windows.Forms.RadioButton milkTeaRadioButton;
        private System.Windows.Forms.RadioButton blackTeaRadioButton;
        private System.Windows.Forms.RadioButton juiceRadioButton;
        private System.Windows.Forms.RadioButton tunasandwichButton;
        private System.Windows.Forms.RadioButton hamsandwichradioButton;
        private System.Windows.Forms.RadioButton jamsandwichRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button button2;
    }
}

