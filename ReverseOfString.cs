using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class ReverseOfString
    {
        Utility utility = new Utility();
        public void ReverseString()
        {

            Console.WriteLine("Enter the Sentence to Reverese It ");

            string name=Console.ReadLine();
            Console.WriteLine("The Original Sentence is   ---- >  " +name);
            Console.WriteLine("After Reverse the Sentence is    ---- >  " + Utility.ReverseString(name));


        }
    }
}
