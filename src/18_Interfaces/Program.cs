using System;
using System.Diagnostics;

namespace _18_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Stopwatch sw = new Stopwatch();

            int n = new Random().Next(1000,5000);
            Console.WriteLine($"N is {n}");

            IAdvancedArithmetic myCalculator = new Calculator();

            sw.Start();
            int sum = myCalculator.DivisorSum(n);
            sw.Stop();
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.WriteLine($"Elapsed Time: {sw.Elapsed}");

            sw.Restart();
            sum = myCalculator.DivisorSumWithLinq(n);
            sw.Stop();
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.WriteLine($"Elapsed Time: {sw.Elapsed}");
            Console.ReadLine();
        }
    }
}
