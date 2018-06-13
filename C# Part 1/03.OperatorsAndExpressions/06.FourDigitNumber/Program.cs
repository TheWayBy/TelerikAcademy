using System;

namespace FourDigitNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int a = (numb / 1000) % 10; 
            int b = (numb / 100) % 10;
            int c = (numb / 10) % 10;
            int d = (numb / 1) % 10;
            // Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a,b,c,d);
            Console.WriteLine("Sum is: {0}", a+b+c+d);
            Console.WriteLine("Concatenated: {0}{1}{2}{3}", d,c,b,a);
            Console.WriteLine("FirstLastDig: {0}{1}{2}{3}", d,a,b,c);
            Console.WriteLine("Exchanged: {0}{1}{2}{3}", a,c,b,d);
            Console.ReadKey();
        }
    }
}
