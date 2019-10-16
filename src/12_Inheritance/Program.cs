using System;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student s = new Student("Heraldo","Memelli",8135627, new[]{55, 70});
            char avg = s.calculate();

            s.printPerson();
            Console.WriteLine($"Grade: {avg}");
        }
    }
}
