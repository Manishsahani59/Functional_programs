using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{

    
   public class Triplates
    {

        Utility utility = new Utility();
        public static void FindTriplate()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Element of the Array");
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("Your Array is : ------> " );
            foreach (int element in a)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\n The Distnicit Triplates is -->");
            
            Utility.DistnictTriplate(a, size);


        }

    }
}
