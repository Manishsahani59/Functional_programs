using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class PrimeInBetwwen
    {

        public void primeInBetween()
        {
            Console.WriteLine("Enter the value from wheres you to start ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End value ");
            int end = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            utility.primeInbetween(start, end);
                
                
           }
    }
}
