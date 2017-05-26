using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "vicky";
            someone.birthday = "1988/05/20";
            
            Console.WriteLine("Student's name:{0}", someone.name);
        }
    }
}
