namespace Comprehensive_practice_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelGiven;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.Label labelQ2;
        private System.Windows.Forms.Label labelQ3;

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGiven;
        private System.Windows.Forms.TextBox textBoxQ1;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.TextBox textBoxQ3;

        private System.Windows.Forms.Button buttonShowMax;
        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.Label lblResult;

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
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGiven = new System.Windows.Forms.Label();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.labelQ2 = new System.Windows.Forms.Label();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxGiven = new System.Windows.Forms.TextBox();
            this.textBoxQ1 = new System.Windows.Forms.TextBox();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.textBoxQ3 = new System.Windows.Forms.TextBox();
            this.buttonShowMax = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.labelSurname.Location = new System.Drawing.Point(108, 36);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(68, 55);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "姓";
            // 
            // labelGiven
            // 
            this.labelGiven.AutoSize = true;
            this.labelGiven.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.labelGiven.Location = new System.Drawing.Point(488, 36);
            this.labelGiven.Name = "labelGiven";
            this.labelGiven.Size = new System.Drawing.Size(68, 55);
            this.labelGiven.TabIndex = 2;
            this.labelGiven.Text = "名";
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.labelQ1.Location = new System.Drawing.Point(79, 163);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(138, 55);
            this.labelQ1.TabIndex = 4;
            this.labelQ1.Text = "小考1";
            // 
            // labelQ2
            // 
            this.labelQ2.AutoSize = true;
            this.labelQ2.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.labelQ2.Location = new System.Drawing.Point(79, 239);
            this.labelQ2.Name = "labelQ2";
            this.labelQ2.Size = new System.Drawing.Size(138, 55);
            this.labelQ2.TabIndex = 6;
            this.labelQ2.Text = "小考2";
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.labelQ3.Location = new System.Drawing.Point(65, 320);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(138, 55);
            this.labelQ3.TabIndex = 8;
            this.labelQ3.Text = "小考3";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.textBoxSurname.Location = new System.Drawing.Point(223, 25);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 66);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxGiven
            // 
            this.textBoxGiven.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.textBoxGiven.Location = new System.Drawing.Point(589, 25);
            this.textBoxGiven.Name = "textBoxGiven";
            this.textBoxGiven.Size = new System.Drawing.Size(200, 66);
            this.textBoxGiven.TabIndex = 3;
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.textBoxQ1.Location = new System.Drawing.Point(223, 152);
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(200, 66);
            this.textBoxQ1.TabIndex = 5;
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.textBoxQ2.Location = new System.Drawing.Point(223, 228);
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(200, 66);
            this.textBoxQ2.TabIndex = 7;
            // 
            // textBoxQ3
            // 
            this.textBoxQ3.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.textBoxQ3.Location = new System.Drawing.Point(223, 309);
            this.textBoxQ3.Name = "textBoxQ3";
            this.textBoxQ3.Size = new System.Drawing.Size(200, 66);
            this.textBoxQ3.TabIndex = 9;
            // 
            // buttonShowMax
            // 
            this.buttonShowMax.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.buttonShowMax.Location = new System.Drawing.Point(163, 407);
            this.buttonShowMax.Name = "buttonShowMax";
            this.buttonShowMax.Size = new System.Drawing.Size(260, 56);
            this.buttonShowMax.TabIndex = 10;
            this.buttonShowMax.Text = "顯示最高分";
            this.buttonShowMax.UseVisualStyleBackColor = true;
            this.buttonShowMax.Click += new System.EventHandler(this.buttonShowMax_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.buttonExit.Location = new System.Drawing.Point(572, 407);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(260, 56);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.lblResult.Location = new System.Drawing.Point(549, 163);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(316, 166);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(916, 494);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelGiven);
            this.Controls.Add(this.textBoxGiven);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.textBoxQ1);
            this.Controls.Add(this.labelQ2);
            this.Controls.Add(this.textBoxQ2);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.textBoxQ3);
            this.Controls.Add(this.buttonShowMax);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

