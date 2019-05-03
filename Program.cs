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

                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UnorderedList.UnorderedList.Unordred();
                        break;
                }
            }
            while (choice != 0);
            Console.WriteLine();
        }
    }
}
