using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(containsxory("fdfdyasfda"));
            Console.WriteLine(containsxory("fdfdasfdasx"));
            Console.WriteLine(containsxory("fdfdasfdas"));







        }


        static int containsxory(string inputString)
        {
            bool answer = false;
            int count = 0;


            for (int i = 0; i < inputString.Length; i++)
            {

                if (inputString[i] == 'x' || inputString[i] == 'y')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
