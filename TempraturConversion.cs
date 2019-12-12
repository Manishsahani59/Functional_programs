using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class TempraturConversion
    {
        public void tempratureConversion()
        {
            Console.WriteLine("Enter the Tempratur in Fehrenhite");
            double C = Convert.ToDouble(Console.ReadLine());
            double ctof = (C * 9 / 5) + 32;
            double ftoc = (ctof-32) *5/9;
            Console.WriteLine("The Tempratur celcesius to Fehrenhite is ----> " +ctof);
            Console.WriteLine("The Tempratur Fehrenhite  to celcesius is ----> " + ftoc);


        }
        
    }
}
