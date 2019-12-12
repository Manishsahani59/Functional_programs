using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class AnagramDetection
    {

        public void AnagramString()
        {
            bool status;
            Console.WriteLine("Enter the First String  -----> ");
            string f_name = Console.ReadLine();
            Console.WriteLine("Enter the Second String  -----> ");
            string s_name = Console.ReadLine();
            status=Utility.IsAnagram(f_name, s_name);
            if (status)
            {
                Console.WriteLine(f_name + " and" + s_name + " is Anagram");
            }
            else
            {
                Console.WriteLine(f_name + " and " + s_name + " Not Anagram");
            }
          
        }
    }
}
