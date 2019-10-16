using System;

namespace _14_Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var difference = new Difference(new[]{ 1,2,5});
            difference.ComputeDifference();
            Console.WriteLine(difference.MaximumDifference);
        }
    }

    
}
