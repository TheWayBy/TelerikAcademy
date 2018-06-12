using System;

namespace BankAccountData
{
   public class Program
    {
        public static void Main()
        {
            string firstName = "Viki";
            string secondName = "Vesselinova";
            string thirdName = "Veleva";
            string holderName = firstName + " " + secondName + " " + thirdName;
            decimal balance = 200000;
            string bankName = "DSK";
            string IBAN = "BG ALA BALA 193784286673";
            long creditNumb1 = 4012888888881881;
            long creditNumb2 = 3782822463100053;
            long creditNumb3 = 4844264826820130;

            Console.WriteLine("Names: {0}, balance: {1}, bank: {2}, IBAN: {3}, credit Card1 {4}, credit Card1 {5}, credit Card1 {6}", holderName, balance, bankName, IBAN, creditNumb1, creditNumb2, creditNumb3);
            Console.ReadKey();

        }
    }
}
