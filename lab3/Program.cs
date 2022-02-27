using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main");
            RomanNumber num1 = new(10), num2 = new(9);
            
            Console.WriteLine(num1.CompareTo(num2));
        }
    }
}
