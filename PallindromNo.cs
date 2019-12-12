using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class PallindromNo
    {
        Utility utility = new Utility();
        public void pallindrom()
        {
            bool result;
            Console.WriteLine("Enter the value to check ---->");
            int value = Convert.ToInt32(Console.ReadLine());
            result=Utility.pallindrom(value);
            if (result)
            {
                Console.WriteLine(value + " is Pallindrom No");
            }else
                Console.WriteLine(value + " is Not Pallindrom No");
        }
    }
}
