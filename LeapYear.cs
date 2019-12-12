using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class LeapYear
    {
        Utility utility = new Utility();
        public void IsLeapYear()
        {
            bool result;
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            result = utility.IsLeapYear(year);

            if (result)
            {
                Console.WriteLine("{0} is Leay Year ", year);
            }
            else {
                Console.WriteLine("{0} is Not Leay Year ", year);
            }
        }

    }
}
