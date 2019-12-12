using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class InsertionSort
    {
        public void Insertionsort()
        {
            int choice;
            Console.WriteLine("Select :: 1 :: for Integer Searching  ");
            Console.WriteLine("Select :: 2 :: for Strring Searching  ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter the Size of the Array");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] a = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("The Entered  Array is  ----> ");
                    foreach (int element in a)
                    {
                        Console.WriteLine(element);
                    }
                   
                    Utility utility = new Utility();
                    Console.WriteLine("Your Sorted Arry is ---> ");
                    Utility.InsertionSortInrteger(a, size);
                    break;
                case 2:

                    Console.WriteLine("Enter the Size of the Array");
                    int size1 = Convert.ToInt32(Console.ReadLine());
                    string[] S = new string[size1];
                    for (int i = 0; i < size1; i++)
                    {
                        S[i] = Console.ReadLine();
                    }
                    Console.WriteLine("The Entered  String  is  ----> ");
                    foreach (string element in S)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("Your Sorted Arry is ---> ");

                    Utility.InsertionsortString(S, size1);


                    break;
                default:
                    Console.WriteLine("You Select Worng Choice");
                    break;
            }
        }


    }

}
