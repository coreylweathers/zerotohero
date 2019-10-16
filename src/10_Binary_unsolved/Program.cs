using System;

namespace _10_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = Convert.ToInt32(439);
            int counter = 0, streak = 0;
            char current;

            string binary = Convert.ToString(n,2);
            
            for (int i = 0; i < binary.Length; i++ )
            {
                current = binary[i];
    
                if (current == '1' )
                {
                    counter++;
                }
                else if (current == '0' || i == binary.Length -1)
                {
                    if (counter > streak)
                    {
                        streak = counter; 
                    }
                    counter = 0;
                }
            }

            Console.WriteLine($"Final counter = {streak}");
        }
    }
}
