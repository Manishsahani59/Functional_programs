using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class DecimalToBinary
    {
        public void DecimalTobinary()
        {
          
            Console.WriteLine("Enter the value in Decimal ");
            int no= Convert.ToInt32(Console.ReadLine());
            Utility.decimatoBnry(no);

        }

    }
}
