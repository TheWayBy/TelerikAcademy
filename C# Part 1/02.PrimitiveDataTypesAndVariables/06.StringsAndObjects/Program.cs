using System;

namespace StringsAndObjects
{
    public class Program
    {
        public static void Main()
        {
            string word1 = "Hello";
            string word2 = "Word";
            object word3 = word1 + " " + word2;
            string word4 = (string)word3;
            Console.WriteLine(word3);
            Console.WriteLine(word4);
            Console.ReadKey();
        }
    }
}
