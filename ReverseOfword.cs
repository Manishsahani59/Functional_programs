using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class ReverseOfword
    {
        public void ReverseofWord()
        {
            Console.WriteLine("Enter the sentence to reverse each word");
            string sentence = Console.ReadLine();
            Console.WriteLine("The Original Sentence is ----->");
            Console.WriteLine("The After reverse Sentence  is ----->");

            Utility.reverseWord(sentence); 
        }

    }
}
