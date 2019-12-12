using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class HarmonicSeries
    {
        public void Harmonicseries()
        {
            Console.WriteLine("Enter the Size of the Series  ----> ");
            int size = Convert.ToInt32(Console.ReadLine());
            Utility.HarmonicSeries(size);
        }

    }
}
