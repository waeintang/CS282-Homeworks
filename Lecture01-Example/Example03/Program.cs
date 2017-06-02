using System;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "vicky";
            someone.birthday = "1988/05/20";

            Console.WriteLine("Student's name:{0}", someone.name);
        }
    }
}