using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class VendingMachine
    {
        public void vendingMachine()
        {

            Console.WriteLine("Enter the Money you need to change");
            int change = Convert.ToInt32(Console.ReadLine());
            //int[] repees = {50, 100, 200, 500, 2000 };
            int[] repees = {2000,500,200,100,50};
            Console.WriteLine(Utility.collectMponey(change, repees, repees.Length, 0));


        }
    }
}
