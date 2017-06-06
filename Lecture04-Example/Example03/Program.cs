using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomGenerator random = new RandomGenerator();
            List<int> numbers = new List<int>();

            for (int index = 0; index < 10; index++)
                numbers.Add(index); // 用 for 把數字加入到 numbers 的list
            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(0, numbers.Count);
            }
        }
    }
}