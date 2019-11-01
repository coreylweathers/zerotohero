using System;

namespace _21_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] values = new int[] {1,2,3};
            char[] letters = new char[] {'a','b','c'};
            PrintArray(values);
            PrintArray(letters);
        }

        static void PrintArray<T>(T[] arg)
        {
            foreach(T number in arg)
            {
                Console.WriteLine(number);
            }
        }
    }
}
