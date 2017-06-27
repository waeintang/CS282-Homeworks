namespace ipad
{
    partial class Ipad
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
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.DataTimer = new System.Windows.Forms.Timer();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StationNameLabel
            // 
            this.StationNameLabel.AutoSize = true;
            this.StationNameLabel.Location = new System.Drawing.Point(37, 29);
            this.StationNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(171, 19);
            this.StationNameLabel.TabIndex = 13;
            this.StationNameLabel.Text = "資料來源: 站台名稱";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(323, 29);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 19);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "更新時間";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(127, 164);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(250, 43);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "開始接收資料";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(410, 95);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(61, 19);
            this.PressureLabel.TabIndex = 11;
            this.PressureLabel.Text = "壓力 0";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(239, 95);
            this.HumidityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(66, 19);
            this.HumidityLabel.TabIndex = 10;
            this.HumidityLabel.Text = "濕度  0";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(68, 95);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(54, 19);
            this.TemperatureLabel.TabIndex = 9;
            this.TemperatureLabel.Text = "0 度C";
            // 
            // Ipad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 247);
            this.Controls.Add(this.StationNameLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Ipad";
            this.Text = "Ipad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Timer DataTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label TemperatureLabel;
    }
}

