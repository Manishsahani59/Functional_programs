using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class PowerOfTwo
    {
        public void POTwo()
        {
            Console.WriteLine("Enter the value to get Power up to lenngth");
            int value = Convert.ToInt32(Console.ReadLine());
            Utility.poweroftwo(value);
        }
    }
}
