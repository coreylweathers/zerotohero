using System;

namespace _16_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {

                var number = Int32.Parse("ab");
                Console.WriteLine(number);
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("BAD STRING");
            }
            finally
            {

            }

        }
    }
}
