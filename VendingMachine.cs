using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class VendingMachine
    {
        public void vendingMachine()
        {
            int yoursavemoney;
            int pepsi = 30;
            int cococola = 50;
            int thupsUp = 40;
            Console.WriteLine("Enter the Product Which You want");
            int product =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            int totalAmount = product * Quantity;
            Console.WriteLine("Enter Your Cash");
            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash < totalAmount)
            {
                Console.WriteLine("Enter the Sufficient Mony");
                cash = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                yoursavemoney = cash - totalAmount;
                collectMoney(yoursavemoney);
            }

       static void collectMoney(int money)
            {

                int[] a = { 100, 200, 50, 2000, 20, 10, 1, 5, 2 };
                for(int i=0;i<a.Length;i++)
                { int collect = money / a[i];
                    if (collect != 0)
                    {
                        Console.WriteLine(collect);
                    }
                    money = collect % a[i];
                }
                

            }


                }
                
                

            }






        }
