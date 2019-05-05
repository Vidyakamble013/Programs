using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.PalindromeChecker
{
   public class PalindromeClass
    {
        public static void CheckePalindromeString()
        {
            string inputstring = string.Empty;
            try
            {
                Dequeue<char> dequeue = new Dequeue<char>();
                bool flag = true;
                while(flag)
                {
                    Console.WriteLine("Enter any String");
                    inputstring = Console.ReadLine();
                    if (Utility.StringChecker(inputstring))
                    {
                        Console.WriteLine("Null string not consider");
                        continue;
                    }
                    flag = false;
                }

                for (int i=0; i<inputstring.Length; i++)
                {
                    char character = inputstring[i];
                    dequeue.AddToRear(character);
                }
                
                while(dequeue.Size() > 1)
                {
                    if(dequeue.RemoveToFront() != dequeue.RemoveToRear())
                    {
                        Console.WriteLine("String not palindrome");
                        return;
                    }
                    Console.WriteLine("String is a Palindrome");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
