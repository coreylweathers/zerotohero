using System;
using System.Collections.Generic;

namespace _08_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string numEntries = "3";
            int entries;

            int.TryParse(numEntries, out entries);


            List<string> inputs = new List<string>
            {
                "sam 99912222",
                "tom 11122222",
                "harry 12299933"
            };

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach(string input in inputs)
            {
                var parts = input.Split(" ");
                dictionary.Add(parts[0], parts[1]);
            }

            List<string> names = new List<string>
            {
                "sam",
                "tony",
                "harry"
            };

            foreach(string name in names)
            {
                Console.WriteLine(dictionary.ContainsKey(name) ? $"{name}={dictionary[name]}" : "Not Found");
            }


            Console.ReadLine();
        }
    }
}
