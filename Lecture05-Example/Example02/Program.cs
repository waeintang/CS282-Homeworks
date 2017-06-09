using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector v1 = new Vector();
            v1.Print();
            Vector v2 = new Vector();
            v2.Print();

            Vector[] vectors = new Vector[]
            {
                new Vector(),
                new Vector(3,4),
                new Vector (1,2)
            };

            foreach (Vector v in vectors)
                v.Print();
        }
    }
}