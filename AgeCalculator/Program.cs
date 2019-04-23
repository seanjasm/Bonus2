using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string day, month, year = string.Empty;
            DateTime birthdate;
            string birthDayMessage = "";
            int daysOld, age = 0;
            DateTime today = DateTime.Today;

            Console.WriteLine("\nEnter your birth year<YYYY>:  ");
            year = Console.ReadLine();

            Console.WriteLine("\nEnter your birth month<MM>:  ");
            month = Console.ReadLine();

            Console.WriteLine("\nEnter your birth day<DD>:  ");
            day = Console.ReadLine();            

            if (DateTime.TryParse(month + "/" + day + "/" + year, out birthdate))
            {
                age = today.Year - birthdate.Year;

                if (birthdate > today.AddYears(-age))
                {
                    age--;
                }
                if (birthdate.Day == today.Day && birthdate.Month == today.Month)
                {
                    birthDayMessage = "Happy birthday! ";
                }

                //Add age to birthdate to get last birthdate and subtract it from today's date              
                daysOld = today.Subtract(birthdate.AddYears(age)).Days;

                Console.WriteLine("\n\n{0}As of today, you are {1} years and {2} days " +
                    "young!\n\n", birthDayMessage, age, daysOld);
            }
            else
            {
                Console.WriteLine("\n\n\aWe encounter an error calculating your birthday.\n\n");
            }
        }
    }
}
