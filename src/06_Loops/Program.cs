using System;
using System.Threading.Tasks;

namespace _06_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            //int min = 1,max = 11;
            int[] numbers = new[]{1,2,3,4,5,6,7,8,9,10};

            /* for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");   
            }*/

            /* Parallel.For(min,max,(i)=> 
            {
                Console.WriteLine($"{n} x {i} = {n * i}");   
            });*/

            Parallel.ForEach(numbers,num=> 
            {
                Console.WriteLine($"{n} x {num} = {n * num}");   

            });
        }
    }
}
