namespace Tutonrial_2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardBackpictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardBackpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(130, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "顯示背面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(441, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "顯示正面";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cardBackpictureBox2
            // 
            this.cardBackpictureBox2.Image = global::Tutonrial_2_5.Properties.Resources.Ace_Hearts;
            this.cardBackpictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("cardBackpictureBox2.InitialImage")));
            this.cardBackpictureBox2.Location = new System.Drawing.Point(291, 57);
            this.cardBackpictureBox2.Name = "cardBackpictureBox2";
            this.cardBackpictureBox2.Size = new System.Drawing.Size(205, 246);
            this.cardBackpictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackpictureBox2.TabIndex = 2;
            this.cardBackpictureBox2.TabStop = false;
            // 
            // cardBackpictureBox1
            // 
            this.cardBackpictureBox1.Image = global::Tutonrial_2_5.Properties.Resources.Backface_Red;
            this.cardBackpictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("cardBackpictureBox1.InitialImage")));
            this.cardBackpictureBox1.Location = new System.Drawing.Point(291, 57);
            this.cardBackpictureBox1.Name = "cardBackpictureBox1";
            this.cardBackpictureBox1.Size = new System.Drawing.Size(205, 246);
            this.cardBackpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackpictureBox1.TabIndex = 0;
            this.cardBackpictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cardBackpictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardBackpictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackpictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cardBackpictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

