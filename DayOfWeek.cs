using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class DayOfWeek
    {

        public void DayOfweek()
        {
            Console.WriteLine("Enter the Day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Day of your Birth is ---->  ");
             Console.WriteLine(Utility.FindDayOfWeek(day, month, Year));
        }
    }
}
