using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WeatherData data1 = new WeatherData()
            {
                Temperature = 28.5,
                Humidity = 100,
                Pressure = 1
            };

                WeatherData data2 = new WeatherData()
            {
                Temperature = 30.5,
                Humidity = 100,
                Pressure = 2
            };

            Console.WriteLine(data1.Equals(data2));
            if (data1.Equals(data2))
            {
                Console.WriteLine("data1 等於 data2");
            }
            else
            {
                Console.WriteLine("data1 不等於 data2");

                /*知道所有資料都發生變化*/
                if (data1.Temperature != data2.Temperature)
                   Console.WriteLine("溫度發生變化");
                if (data1.Humidity != data2.Humidity)
                    Console.WriteLine("濕度發生變化");
                if (data1.Pressure != data2.Pressure)
                    Console.WriteLine("壓力發生變化");

                /*若只想知道其中某一個，第一個不成立就執行第二個 就用 if .. else ...*/
            }
        }
    }
}
