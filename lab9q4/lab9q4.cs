using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters;

            Console.WriteLine("Enter letters");
            letters = Console.ReadLine();
            ReconstructingArray(letters);
        }





        static string ReconstructingArray(string letters)
        {
            string letters2 ;
                
            for (int i = 0; i < letters.Length; i++)
            {
                letters2[i] = letters[i];
            }
            return letters2;
            
        }
    }
}