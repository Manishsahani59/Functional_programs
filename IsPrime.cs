using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
  public class IsPrime
    {

        public void isPrime()
        {
            bool result;
            Console.WriteLine("Enter the value to check weather Prime or Not");
            int value = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            result=utility.isPrime(value);
            if (result)
            {
                Console.WriteLine(value + " is Prime  ");
            }
            else {
                Console.WriteLine(value + " is not Prime");
            }
        }
    }
}
