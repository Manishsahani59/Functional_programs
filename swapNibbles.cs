using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class swapNibbles
    {
        public void swapnibble()
        {
            Console.WriteLine("Enter the First value ");
            int a = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("The Rsultant Number After Swaping The Nibbles in ----> " +Utility.swapNibbles(a));
        }

    }
}
