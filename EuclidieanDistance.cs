using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   

    public class EuclidieanDistance
    {
        Utility utility = new Utility();
        public void Euclidieandistance()
        {
            double result;
            Console.WriteLine("Enter the Value of X ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Y ");
            int Y = Convert.ToInt32(Console.ReadLine());
            result=utility.EuclidieanDistance(X, Y);
            Console.WriteLine("The Euclidiean Distance is   ---->  " + result);
        }
        
     }
}
