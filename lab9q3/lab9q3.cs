using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            if (containsxory("fdfdasfdasx") == true)
            {
                counter++;
            }
            Console.WriteLine(containsxory("fdfdyasfda"));
            Console.WriteLine(containsxory("fdfdasfdasx"));
            Console.WriteLine(containsxory("fdfdasfdas"));

            Console.WriteLine("\ntrue: {0}", counter);






        }


        static bool containsxory(string inputString)
        {
            bool answer = false;

            for (int i = 0; i < inputString.Length; i++)
            {

                if (inputString[i] == 'x' || inputString[i] == 'y')
                {
                    answer = true;
                    if (answer == true)
                    {

                    }
                }
            }

            return answer;
        }
    }
}
