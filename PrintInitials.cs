using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class PrintInitials
    {

        public void printinitilas()
        {
            Console.WriteLine("Enter the Any Name ");
            string str = Console.ReadLine();
            Utility.printinitials(str);

        }
    }
}
