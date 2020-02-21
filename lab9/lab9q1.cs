using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] output = new int[1000];

            for (int i = 0; i < 999; i++)
            {
                output[i] = i;
                Console.WriteLine(i);
            }
        }
    }
}
