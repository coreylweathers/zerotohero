using System;
using System.Diagnostics;

namespace loop_performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var SIZE = 100000000;
            var arrayA = new short[SIZE];

            CompareTester[] objArrayA = new CompareTester[SIZE];

            BuildArray(SIZE, arrayA);
            BuildArray(SIZE, objArrayA);

            var arrayB = new short[SIZE];
            var objArrayB = new CompareTester[SIZE];

            arrayA.CopyTo(arrayB, 0);
            objArrayA.CopyTo(objArrayB, 0);

            var sw = new Stopwatch();
            sw.Start();
            var isEqual = CompareArrays(SIZE, arrayA, arrayB);
            sw.Stop();
            var shortComparison = sw.Elapsed;
            Console.WriteLine($"Short Comparison: {shortComparison}");

            sw.Restart();
            arrayA.Equals(arrayB);
            sw.Stop();
            shortComparison = sw.Elapsed;
            Console.WriteLine($"Short Comparison: {shortComparison}");

            
            sw.Restart();
            isEqual = CompareArrays(SIZE, objArrayA, objArrayB);
            sw.Stop();
            var objComparison = sw.Elapsed;

            Console.WriteLine("The arrays are " + (isEqual ? "equal" : "not equal"));
            Console.WriteLine($"Obj Comparison: {objComparison}");
        }

        private static bool CompareArrays(int SIZE, short[] arrayA, short[] arrayB)
        {
            var isEqual = true;
            var count = 0;
            while (isEqual && count < SIZE)
            {
                if (arrayA[count] != arrayB[count])
                {
                    isEqual = false;
                }

                count++;
            }

            return isEqual;
        }

        private static bool CompareArrays(int SIZE, CompareTester[] arrayA, CompareTester[] arrayB)
        {
            var isEqual = true;
            var count = 0;
            while (isEqual && count < SIZE)
            {
                if (arrayA[count].Value != arrayB[count].Value)
                {
                    isEqual = false;
                }

                count++;
            }

            return isEqual;
        }

        private static void BuildArray(int SIZE, short[] arrayA)
        {
            var r = new Random();
            for (var i = 0; i < SIZE; i++)
            {
                arrayA[i] = Convert.ToInt16(r.Next(0, Int16.MaxValue));
            }
        }

        private static void BuildArray(int SIZE, CompareTester[] arrayA)
        {
            var r = new Random();
            for (var i = 0; i < SIZE; i++)
            {
                arrayA[i] = new CompareTester {Value = Convert.ToInt16(r.Next(0, Int16.MaxValue))};
            }
        }
    }

    class CompareTester
    {
        public short Value { get; set; }
    }
}