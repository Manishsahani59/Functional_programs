using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class Factorial
    {
        Utility utility = new Utility();
        public void factorial()
        {
            int result;
            Console.Write("Enter the value to get the factorial");
            int value = Convert.ToInt32(Console.ReadLine());
            result=utility.Factorial(value);
            Console.WriteLine("Factorial using General Method is ");
            Console.WriteLine("The Facorial of " + value + " is --- > " + result);
            int result1 = Utility.RecFact(value);
            Console.WriteLine("Factorial using Resursion Method is ");
            Console.WriteLine("The Facorial of " + value + " is --- > " + result1);

        }
    }
}
