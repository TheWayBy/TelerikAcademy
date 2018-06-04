using System;
using System.Globalization;

namespace AgeAfterTenYears
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your birthday (dd/MM/yyyy):");
            DateTime today = DateTime.Now;
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(birthday.ToShortDateString());
            int age = 0;

            if (today.Month < birthday.Month)
            {
                age = today.Year - birthday.Year - 1;
            }
            else
            {
                if (today.Day < birthday.Day)
                {
                    age = today.Year - birthday.Year - 1;
                }
                else
                {
                    age = today.Year - birthday.Year;
                }
            }

            Console.WriteLine("You are {0} years old.\nAfter 10 years you will be {1} years old baby!", age, age + 10);
            Console.ReadKey();
        }
    }
}
