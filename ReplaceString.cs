using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class ReplaceString
    {
        public void replacestring() {
            string name = "Hello << username >> how are You";
            Console.WriteLine("The Original Name is --> " +name);
            Console.WriteLine("Enter the Name to replace to get proper sentences");
            string newname = Console.ReadLine();
            Utility.RepalceString(name, newname);

        }
     

    }
}
