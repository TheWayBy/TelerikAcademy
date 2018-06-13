using System;

namespace ThirdDigitIs7
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool thirdDigit = num > 100 ? ((num / 100) % 10 == 7) : false;
            Console.WriteLine(thirdDigit);
            Console.ReadKey();
        }
    }
}
