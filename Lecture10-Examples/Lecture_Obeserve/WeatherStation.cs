using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationLibrary;

namespace Lecture_Obeserve
{
    public partial class WeatherStation : Form, IObservable, IObserver
    {
        private List<WeatherData> DataLog;
        private List<IObserver> observers;
        private WeatherData data;
        public string StationName { get; set; }
        public Ipad ipadAir2;
        public Ipad ipadAir3;


        public WeatherStation()
        {
            InitializeComponent();
            DataLog = new List<WeatherData>();
            observers = new List<IObserver>();
        }

        public void Render(object sender, EventArgs e)
        {
            WeatherData Data = e as WeatherData;
            WeatherStation stationName = sender as WeatherStation;
           
            this.TemperatureLabel.Text ="溫度:" +  Data.Temperature.ToString() + "度";
            this.HumidityLabel.Text = "濕度: " + Data.Humidity.ToString("#.##") + "%"; ;
            this.PressureLabel.Text = "氣壓: " + Data.Pressure.ToString("#.##");
            this.TimeLabel.Text = "更新時間: " + Data.Time.ToString();
        }
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            WeatherData other = WeatherData.Generate();
            OnMeasurementsChanged(other);
        }

        public void StartButton_Click(object sender, EventArgs e)
        {
            this.DataTimer.Enabled = this.DataTimer.Enabled;
        }

        private void Data_load(object sender, EventArgs e)
        {
            this.data = WeatherData.Generate();
            Render(this, data);
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

         public void Remove(IObserver o)
        {
            observers.Remove(o);
        }
         public void Notify()
         {
             foreach (IObserver o in observers)
                 o.Render(this, data);
         }

        public void OnMeasurementsChanged(WeatherData other)
        {
            if(!this.data.Equals(other))
            {
                this.data = other;
                Notify();
            }
        }

    }
}
