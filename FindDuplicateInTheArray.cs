using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class FindDuplicateInTheArray
    {

        public void findDuplicate()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int []arr = new int[size];
            Console.WriteLine("Enter the Element of the Array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Array is ---> ");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("The Duplicate Element in the Array is --->");
             Utility.DuplicatElement(arr);

        }
    }
}
