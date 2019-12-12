using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class sqrtusingNetwonsMethod
    {
        public void netwonmethod()
        {
           
            Console.WriteLine("Enter the Value of c to get the sqrt using netwons method");
            double c = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("The sqrt of the value " + c + " is " + Utility.netwonmethod(c)); 
        }
       

    }
}
