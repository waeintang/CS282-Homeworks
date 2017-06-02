namespace Example03
{
    partial class MainForm
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
            this.WeatherDataPanel = new System.Windows.Forms.Panel();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.WeatherDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeatherDataPanel
            // 
            this.WeatherDataPanel.Controls.Add(this.pressureLabel);
            this.WeatherDataPanel.Controls.Add(this.humidityLabel);
            this.WeatherDataPanel.Controls.Add(this.temperatureLabel);
            this.WeatherDataPanel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeatherDataPanel.Location = new System.Drawing.Point(49, 31);
            this.WeatherDataPanel.Name = "WeatherDataPanel";
            this.WeatherDataPanel.Size = new System.Drawing.Size(160, 192);
            this.WeatherDataPanel.TabIndex = 0;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(39, 113);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(66, 19);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "壓力: 0";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(38, 71);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(66, 19);
            this.humidityLabel.TabIndex = 1;
            this.humidityLabel.Text = "濕度: 0";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(38, 28);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(66, 19);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "溫度: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 262);
            this.Controls.Add(this.WeatherDataPanel);
            this.Name = "MainForm";
            this.Text = "不準確觀測站";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.WeatherDataPanel.ResumeLayout(false);
            this.WeatherDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WeatherDataPanel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label temperatureLabel;
    }
}

