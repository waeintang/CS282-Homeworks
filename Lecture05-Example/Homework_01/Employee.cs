using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    public class Employee
    {
        public int BaseSalary;

        private int salary;
        public int Benefit;

        public int Salary
        {
            get
            {
                return this.BaseSalary + this.Benefit;
            }
        }
    }
}