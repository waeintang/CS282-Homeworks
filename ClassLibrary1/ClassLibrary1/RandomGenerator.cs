using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RandomGenerator // 讓其他專案可以公用 所以class 前面要加 public
    {
        private Random random;

        public RandomGenerator()
        {
            random = new Random();
        }

        public double NextDouble(double start, double end) //.net 的 NextDouble  會產生0 和1 之間 ( 0<a< 1 )
        {
            return random.NextDouble() * (end - start) + start;
        }

        public double NextDouble()
        {
            return random.NextDouble();
        }
    }
}