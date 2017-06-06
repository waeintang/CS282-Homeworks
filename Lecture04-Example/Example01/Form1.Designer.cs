namespace Example01
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ScencePictureBox = new System.Windows.Forms.PictureBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScencePictureBox
            // 
            this.ScencePictureBox.Image = global::Example01.Properties.Resources._10;
            this.ScencePictureBox.Location = new System.Drawing.Point(12, 12);
            this.ScencePictureBox.Name = "ScencePictureBox";
            this.ScencePictureBox.Size = new System.Drawing.Size(497, 334);
            this.ScencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScencePictureBox.TabIndex = 0;
            this.ScencePictureBox.TabStop = false;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(41, 367);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(154, 52);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "我選 1";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(313, 367);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(154, 52);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "我選 2";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 431);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.ScencePictureBox);
            this.Name = "Form1";
            this.Text = "上班族心事";
            ((System.ComponentModel.ISupportInitialize)(this.ScencePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ScencePictureBox;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button NoButton;
    }
}

