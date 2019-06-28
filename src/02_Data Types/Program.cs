using System;

namespace _02_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARE
            int num1;
            double num2;
            String value;

            // INITIALIZE
            int.TryParse(Console.ReadLine(), out i);
            double.TryParse(Console.ReadLine(), out d);
            s = Console.ReadLine();

            Console.WriteLine(i + num1);
            Console.WriteLine(Math.Round(d + num2,1));
            Console.WriteLine(s + value);
        }
    }
}
