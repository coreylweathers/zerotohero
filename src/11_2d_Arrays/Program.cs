using System;

namespace _11_2d_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines =
            {
                "1 1 1 0 0 0",
                "0 1 0 0 0 0",
                "1 1 1 0 0 0",
                "0 0 2 4 4 0",
                "0 0 0 2 0 0",
                "0 0 1 2 4 0"
            };
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(lines[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int maxsum = 0, start = 0, length = 6, end = start + 2;
            int sum = 0;
            for (int h = 0; h < length; h++)
            {
                for (int j = start; j <= start + 2; j++)
                {
                    for (int k = 0; k <= end; k++)
                    {
                        if (k < length - 2)
                        {
                            if ((j == start + 1 && k != (end - start) / 2))
                            {
                                continue;
                            }
                            sum += arr[j][k];
                        }
                    }
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                    sum = 0;
                }

                start++;
                end++;
            }

            Console.WriteLine($"Maxsum: {maxsum}");
        }
    }
}
