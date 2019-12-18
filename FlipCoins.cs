using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
   public class FlipCoins
    {
        Utility utility = new Utility();
        public void Flipcoins()
        {

            bool falg = true;
            Console.WriteLine("Enter the Size up to you want to flip");

            try
            {
                int Flip = Convert.ToInt32(Console.ReadLine());
                utility.FlipCoins(Flip);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter the valid input");
             }


          


        }

    }
}
