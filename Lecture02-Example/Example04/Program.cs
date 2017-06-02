using System;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 12;
            numbers[2] = 21;
            numbers[3] = 89;
            numbers[4] = 33;
            Console.WriteLine(numbers[3]); //the forth
            Console.WriteLine(numbers.Length); // array's length
        }
    }
}