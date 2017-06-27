namespace Lecture_Obeserve
{
    partial class WeatherStation
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
            this.components = new System.ComponentModel.Container();
            this.DataTimer = new System.Windows.Forms.Timer(this.components);
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataTimer
            // 
            this.DataTimer.Tick += new System.EventHandler(this.DataTimer_Tick);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(46, 147);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(54, 19);
            this.TemperatureLabel.TabIndex = 0;
            this.TemperatureLabel.Text = "0 度C";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(193, 147);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(66, 19);
            this.HumidityLabel.TabIndex = 1;
            this.HumidityLabel.Text = "濕度  0";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(340, 147);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(61, 19);
            this.PressureLabel.TabIndex = 2;
            this.PressureLabel.Text = "壓力 0";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(185, 224);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(83, 27);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "開始接收資料";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StationNameLabel
            // 
            this.StationNameLabel.AutoSize = true;
            this.StationNameLabel.Location = new System.Drawing.Point(37, 46);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(85, 19);
            this.StationNameLabel.TabIndex = 7;
            this.StationNameLabel.Text = "站台名稱";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(307, 46);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 19);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "更新時間";
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 281);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StationNameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WeatherStation";
            this.Text = "氣象站";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer DataTimer;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Label TimeLabel;
    }
}

