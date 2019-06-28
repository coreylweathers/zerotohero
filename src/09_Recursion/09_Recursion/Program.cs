using System;

namespace _09_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = int.Parse("10");
            
            Console.WriteLine(Factorial(number));
        }

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
