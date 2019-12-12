using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class PallindromAnagram
    {
        public void PallPrime()
        {
            Console.WriteLine("Enter the Range to check Prime Pallindrom");
            int size = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            Utility.Pallindromprime(size);
        }

    }
}
