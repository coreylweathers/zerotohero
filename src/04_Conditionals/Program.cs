using System;

namespace _04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = Int32.Parse(Console.ReadLine());
            
            if (n % 2 == 1)
            {
                PrintWeird(true);
            }
            else
            {
                if (n == 2 || n == 4)
                {
                    /* This is now 
                    a multiline comment */
                    PrintWeird(false);
                }
                else if (n>=6 && n <= 20)
                {
                    // do something else
                    PrintWeird(true);

                }
                else if (n > 20)
                {
                    // do the final thing
                    PrintWeird(false);
                }
            }

        }
   
        static void PrintWeird(bool isWierd)
        {
            if (isWierd)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
