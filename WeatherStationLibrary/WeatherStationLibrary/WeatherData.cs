using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace WeatherStationLibrary
{
    public class WeatherData:EventArgs
    {
        private double temperature; // 數字敏感，可能會壞掉，要寫一個接口
        private double humidity;
        private double pressure;
        private static Random random;
        public DateTime Time;

      

        public double Pressure1 //ctrl R E
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public double Humidity
        {
            get { return this.humidity; }

            set
            {
                if (value > 100)
                {
                    this.humidity = 100;
                }
                else if (value < 0)
                {
                    this.humidity = 0;
                }
                else
                {
                    this.humidity = value;
                }
            }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set
            {
                if (value > 1)
                {
                    this.pressure = 1;
                }
                else if (value < 0)
                {
                    this.pressure = 0;
                }
                else
                {
                    this.pressure = value;
                }
            }
        }

        public double Temperature
        {
            get
            {
                return this.temperature;
            }
            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        /*
                public void SetTemperature(double value) // 公開的藉口private double Temperature;
                {
                    if (value > 40)
                    {
                        this.temperature = 40;
                    }
                    else if (value < -10)
                    {
                        this.temperature = -10;
                    }
                    else
                    {
                        this.temperature = value;
                    }
                }

                public double getTemperature()
                {
                    return this.temperature;
                }
                */

        public bool Equals(WeatherData other)
        {
            return this.Temperature == other.Temperature
                && this.Humidity == other.Humidity
                && this.Pressure == other.Pressure;
        }
        public static WeatherData Generate()
        {
            if (random == null)
                random = new Random();

            return new WeatherData()
            {
                Temperature = random.NextDouble(25.0, 33.0),
                Humidity = random.NextDouble(80, 100),
               Pressure = random.NextDouble(0.99,1.0),
               Time = new DateTime()

            };
        }
    }//public class WeatherData
    
}