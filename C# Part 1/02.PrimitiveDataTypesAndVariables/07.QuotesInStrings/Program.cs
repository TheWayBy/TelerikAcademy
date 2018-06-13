using System;

namespace QuotesInStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence1 = "The \"use\" of quotations causes difficulties.";
            string sentence2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(sentence1);
            Console.WriteLine(sentence2);
            Console.ReadKey();
        }
    }
}
