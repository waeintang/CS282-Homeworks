namespace Lecture_Obeserve
{
    partial class Ipad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.DataTimer = new System.Windows.Forms.Timer(this.components);
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
            this.StationNameLabel.Location = new System.Drawing.Point(14, 34);
            this.StationNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(171, 19);
            this.StationNameLabel.TabIndex = 13;
            this.StationNameLabel.Text = "資料來源: 站台名稱";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(403, 46);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 19);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "更新時間";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(152, 187);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(138, 43);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "開始接收資料";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(388, 107);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(61, 19);
            this.PressureLabel.TabIndex = 11;
            this.PressureLabel.Text = "壓力 0";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(180, 107);
            this.HumidityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(66, 19);
            this.HumidityLabel.TabIndex = 10;
            this.HumidityLabel.Text = "濕度  0";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(45, 107);
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
            this.ClientSize = new System.Drawing.Size(473, 415);
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
            this.Load += new System.EventHandler(this.Ipad_Load);
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