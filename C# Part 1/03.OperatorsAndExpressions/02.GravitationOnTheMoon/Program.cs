using System;

namespace GravitationOnTheMoon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = weight * 0.17;
            Console.WriteLine("Moonweight: {0}", moonWeight);
            Console.WriteLine(weight * 0.17);
            Console.ReadLine();
            

        }
    }
}
