using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class Max_min
    {
        public void Max_MIn()
        {
           
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter The Element of the Arrays ----> ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The Entered Element is  --->");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("The Max Element of the Array is  ---> ");
            int result= Utility.Max(arr);
            Console.WriteLine(result);
            Console.WriteLine("The Min Element of the Array is  ---> ");
            int result1= Utility.Min(arr);
            Console.WriteLine(result1);

        }

    }
}
