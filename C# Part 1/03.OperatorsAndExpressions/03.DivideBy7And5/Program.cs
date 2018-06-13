using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool answer = ((num % 7) == 0 && (num % 5) == 0);
            Console.WriteLine("The answer is: {0}", answer);
            Console.ReadKey();
        }
    }
}
