using System;
using System.IO;
namespace ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, 'OMG!'");
            Console.WriteLine(GetRandomfact());
        }

        public static string GetRandomfact()
        {
            string filePath = @"C:\Users\opilane\Samples\Logitpe21\FunFacts.txt";
            string[] RandomFacts = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, RandomFacts.Length);


            return RandomFacts[randomIndex];
        }
    }
}