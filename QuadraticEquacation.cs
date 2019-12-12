using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class QuadraticEquacation
    {
        Utility utility = new Utility();
        public void quadraticEqucation()
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());
            Utility.quadratucequcation(a, b, c);
        }
    }
}
