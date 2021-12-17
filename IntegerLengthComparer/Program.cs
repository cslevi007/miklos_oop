using System;
using System.Diagnostics;

namespace IntegerLengthComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[random.Next(1297380, 1297385)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(3, 8232);
            }

            Stopwatch first = new Stopwatch();
            first.Start();

            WithString(arr);

            first.Stop();
            Console.WriteLine($"Meme elso megoldasa: { first.ElapsedMilliseconds }");

            Stopwatch second = new Stopwatch();
            second.Start();

            WithLog(arr);

            second.Stop();
            Console.WriteLine($"Meme masodik megoldasa: { second.ElapsedMilliseconds }");
        }



        static void WithString(int[] arr)
        {
            int[] count = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                count[i] = arr[i].ToString().Length;
                if(i < 100)
                {
                    Console.WriteLine(count[i]);
                }
            }
        }

        static void WithLog(int[] arr)
        {
            int[] count = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[i] = 1 + (int)Math.Floor(Math.Log10(arr[i]));
                if (i < 100)
                {
                    Console.WriteLine(count[i]);
                }
            }
        }
        
    }
}
