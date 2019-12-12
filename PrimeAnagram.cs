using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class PrimeAnagram
    {
        public void primeAnagram()
        {
            Console.WriteLine("Enter the Range");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime And Anagram No ids ---- >");
            Utility.primeAngram(range);
        }

    }
}
