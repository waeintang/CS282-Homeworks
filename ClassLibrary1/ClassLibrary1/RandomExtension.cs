using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class RandomExtension //靜態類別 => 追加擴充方法
    {
        public static double NextDouble(this Random random, double start, double end) //.net 的 NextDouble  會產生0 和1 之間 ( 0<a< 1 )
        {
            return random.NextDouble() * (end - start) + start;
        }
    }
}