using System;

namespace NullValuesArithmetic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int? numb1 = null;
            double? numb2 = null;

            Console.WriteLine("int = {0}, double = {1}", numb1, numb2);
            Console.WriteLine("Add some number to int:" + (numb1 + 10));
            Console.WriteLine("Add some number to double:" + (numb2 + 5.144));
            Console.ReadKey();
        }
    }
}
