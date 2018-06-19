using System;

namespace PrintCompanyInformation
{
    public class Program
    {
        public static void Main()
        {
            string CompanyName = "Telerik Academy";
            string CompanyAddress = "31 Al. Malinov, Sofia";
            string PhoneNumber = "+359 888 55 55 555";
            string FaxNumber = string.Empty;
            string WebSite = "http://telerikacademy.com/";
            string ManagerFirstName = "Nikolay";
            string ManagerLastName = "Kostov";
            int ManagerAge = 25;
            string ManagerPhone = "+359 2 981 981";
            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n {7}\n {8}\n", CompanyName, CompanyAddress, PhoneNumber, string.IsNullOrEmpty(FaxNumber)?"(no fax)":FaxNumber,
                WebSite, ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone);
            Console.ReadKey();

        }
    }
}
