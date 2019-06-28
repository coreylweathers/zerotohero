using System;

namespace _05_Class_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numOfCases = Convert.ToInt32(Console.ReadLine());

            for(var i = 0; i < numOfCases; i++)
            {
                var temp = Convert.ToInt32(Console.ReadLine());
                var corey = new Person(temp);
            }

            
            var asciimo = new Person(18);
        }
    }
}
