using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_Obeserve
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WeatherStation());

            WeatherStation 玉山氣象站 = new WeatherStation();
            玉山氣象站.StationName = "玉山氣象站";
           
            WeatherStation 陽明山氣象站 = new WeatherStation();
            陽明山氣象站.StationName = "陽明山氣象站";
            陽明山氣象站.Show();
            Application.Run(玉山氣象站);
        }
    }
}
