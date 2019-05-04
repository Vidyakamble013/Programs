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
                }
            }
            while (choice != 0);
            Console.WriteLine();
        }
    }
}
