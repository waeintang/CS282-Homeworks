using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10, -20, 20);// 因為用了static 所有不用在 new
            foreach (Vector v in vectors)
                v.Print();
        }
    }
}