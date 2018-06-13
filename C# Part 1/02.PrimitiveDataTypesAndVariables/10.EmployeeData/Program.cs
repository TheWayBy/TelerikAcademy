using System;

namespace EmployeeData
{
    public class Program
    {
        public static void Main()
        {
            string firstName = "Viki";
            string secondName = "Veleva";
            byte age = 26;
            char gender = 'f';
            long personalID = 8306112507;
            int employeeNumber = 27569999;
            Console.WriteLine("Employee first name is {0}, Second name: {1}, age: {2}, gender: {3}, personalID: {4}, employeeNumber: {5}", 
                               firstName, secondName, age, gender, personalID, employeeNumber);
            Console.ReadKey();
            
        }
    }
}
