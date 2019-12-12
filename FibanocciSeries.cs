using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class FibanocciSeries
    {
        public void Fibanocci()
        { 
                Console.WriteLine("Enter the value up to need Fibnocci Series  ");
                int length = Convert.ToInt32(Console.ReadLine());
               Utility.FacbanocciSeries(length); 

        }

    }
}
