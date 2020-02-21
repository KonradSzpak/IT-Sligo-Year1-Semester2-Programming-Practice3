using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] output = new int[1000];

            for (int i = 0; i < 999; i++) //loops
            {
                output[i] = i;   //outpits array 1 by 1
                Console.WriteLine(i);
            }
        }
    }
}
