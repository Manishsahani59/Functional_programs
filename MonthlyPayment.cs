using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class MonthlyPayment
    {
        public void monthlyPayemnt()
        {
            double result;
            Console.WriteLine("Enter the value of Principal Lone (P)");
            double P = Convert.ToDouble(Console.ReadLine());
            
         
            Console.WriteLine("Enter the value of Year to pay (Y)");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Rate of Intereset (R)");
            double R = Convert.ToDouble(Console.ReadLine());
            result= Utility.MonthlyPay(P, Y, R);
            Console.WriteLine("Monthly Payment is ---- > " + result);

        }
    }
}
