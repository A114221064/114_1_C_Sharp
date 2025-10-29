namespace _2_2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowHeads = new System.Windows.Forms.Button();
            this.ShowTails = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_2_2.Properties.Resources.Tails1;
            this.pictureBox2.Location = new System.Drawing.Point(406, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2_2.Properties.Resources.Heads1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShowHeads
            // 
            this.ShowHeads.Location = new System.Drawing.Point(71, 297);
            this.ShowHeads.Name = "ShowHeads";
            this.ShowHeads.Size = new System.Drawing.Size(130, 60);
            this.ShowHeads.TabIndex = 2;
            this.ShowHeads.Text = "Show Heads";
            this.ShowHeads.UseVisualStyleBackColor = true;
            this.ShowHeads.Click += new System.EventHandler(this.ShowHeads_Click);
            // 
            // ShowTails
            // 
            this.ShowTails.Location = new System.Drawing.Point(247, 297);
            this.ShowTails.Name = "ShowTails";
            this.ShowTails.Size = new System.Drawing.Size(130, 60);
            this.ShowTails.TabIndex = 3;
            this.ShowTails.Text = "Show Tails";
            this.ShowTails.UseVisualStyleBackColor = true;
            this.ShowTails.Click += new System.EventHandler(this.ShowTails_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(406, 297);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(130, 60);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowTails);
            this.Controls.Add(this.ShowHeads);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Show Heads";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ShowHeads;
        private System.Windows.Forms.Button ShowTails;
        private System.Windows.Forms.Button Exit;
    }
}

