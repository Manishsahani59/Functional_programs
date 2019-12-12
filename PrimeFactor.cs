using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class PrimeFactor
    {
        Utility utility = new Utility();
        public void primefactor()
        {
            Console.WriteLine("Enter The Value  --> ");
            int value = Convert.ToInt32(Console.ReadLine());
            utility.primeFactor(value);
        }

    }
}
