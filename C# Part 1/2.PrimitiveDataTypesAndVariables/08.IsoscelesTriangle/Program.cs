using System;

namespace IsoscelesTriangle
{
    public class Program
    {
        public static void Main()
        {
            //169
            char word = '\u00A9';
            Console.WriteLine("    {0}", word);
            Console.WriteLine();
            Console.WriteLine("   {0}{1}", word, word);
            Console.WriteLine();
            Console.WriteLine(" {0}   {1} ", word, word);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} {3}", word, word, word, word);
            Console.WriteLine();
            Console.ReadKey();
           
        }
    }
}
