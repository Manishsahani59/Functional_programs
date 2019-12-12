using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class PermutationofString
    {

        public void permutation()
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            int r= input.Length;
           
            Utility.Permutions(input, 0, r-1);
        }
    }
}
