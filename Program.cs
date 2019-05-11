//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;

    /// <summary>
    /// Program as class
    /// </summary>
   public class Program
    {
        /// <summary>
        /// main as static function
        /// </summary>
        /// <param name="args">args as parameter</param>
       public static void Main(string[] args)
        {            
            int choice;
            do
            {
                Console.WriteLine("1. UnorderedList ");
                Console.WriteLine("2. OrderedList ");
                Console.WriteLine("3. Parentheses Balanced");
                Console.WriteLine("4. Banking Transaction");
                Console.WriteLine("5. Palindrome Checker");
                Console.WriteLine("6. CalendarProgramUsing_Array");
                Console.WriteLine("7. CalendarProgramUsing_Queue");
                Console.WriteLine("8. CalendarProgramUsing_Stack");
                Console.WriteLine("9. PrimeNumber Program");
                Console.WriteLine("10. Anagram Number find prime Number Program");
                Console.WriteLine("11. PrimeWithAnagramProgramUsingQueue");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UnorderedList.UnorderedList.Unordred();
                        break;
                    case 2:
                        OrderedList.OrderedInput.OrderedLinkedList();
                        break;
                    case 3:
                        BalancedParentheses balancedParentheses = new BalancedParentheses();
                        BalancedParentheses.BalancedParenthesesProgram();
                        break;
                    case 4:
                        BankingOperation.BankCounter.Counter();
                        break;
                    case 5:
                        PalindromeChecker.PalindromeClass.CheckPalindromeString();
                        break;
                    case 6:
                        CalanderProgram.CalenderInputArray.InputDisplay(args);
                        break;
                    case 7:
                        CalanderUsingQueue.CalendarInput.CalendarStart();
                        break;
                    case 8:
                        CalenderUsingStack.CalenderInputStack.StackCalender();
                        break;
                    case 9:
                        PrimeNumberProgram.PrimeNumber();
                        break;
                    case 10:
                        PrimeNumberAnagramWithTwoDArray.FindAnagramIntoPrimeNumberArray();
                        break;
                    case 11:
                        PrimeWithAnagramNumberQueueOperation.PrimeWithAnagramQueue.PrimeWithAnagramNumber();
                        break;
                }
            }
            while (choice != 0);
            Console.WriteLine();
        }
    }
}
