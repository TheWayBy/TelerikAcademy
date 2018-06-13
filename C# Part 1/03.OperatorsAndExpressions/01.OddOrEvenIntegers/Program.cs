using System;

namespace OddOrEvenIntegers
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool OddOrEvven = num % 2 != 0; 
            Console.WriteLine((num%2 != 0));
            Console.WriteLine("OddOrEven: {0}", OddOrEvven);
            Console.ReadKey();
        }
    }
}
