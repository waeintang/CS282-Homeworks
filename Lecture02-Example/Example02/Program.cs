using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 / 2); //error 1/2 = 0.5 會變成整數 0
            Console.WriteLine(1.0 / 2.0);// right 一定要加入點數
        }
    }
}
