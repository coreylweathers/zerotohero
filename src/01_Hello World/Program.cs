using System;

namespace _01_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = args[0];
            Console.WriteLine("Hello, World.");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
