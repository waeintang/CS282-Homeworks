using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee data = new Employee();
            Console.Write("please input employes's BaseSalary:");
            int BaseSalary = int.Parse(Console.ReadLine());
            data.BaseSalary = BaseSalary;
            Console.Write("please input employes's Benefit:");
            int Benefit = int.Parse(Console.ReadLine());
            data.Benefit = Benefit;
            Console.WriteLine("Your salary is {0}", data.Salary);
        }
    }
}