using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class Gambler
    {

        Utility utility = new Utility();
        public void gambler()
        {
            Console.WriteLine("Enter the Stack");
            int stack = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Goal");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trail");
            int Trails = Convert.ToInt32(Console.ReadLine());
            utility.Gambler(stack, goal, Trails);
        }

    }
}
