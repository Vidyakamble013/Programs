//-----------------------------------------------------------------------
// <copyright file="CalenderInputArray.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructureProgram.CalanderProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar InputArray is class
    /// </summary>
   public class CalenderInputArray
    {
        /// <summary>
        /// InputDisplay function
        /// </summary>
        /// <param name="args">args parameter</param>
        public static void InputDisplay(string[] args)
        {
            try
            {
                int year = 0;
                int month = 0;
                //// checks the number of Arguments passed by user
                if (args.Length != 2)
                {
                    Console.WriteLine("Please Enter the month and Year correctly in MM/YYYY");
                    Console.ReadLine();
                    return;
                }
                ////checks for valid month input
                if (Utility.IsNumber(args[0]) == false)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }
                ////conversion of month into integer
                month = Convert.ToInt32(args[0]);
                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }

                //// call IsNumber function in Utility class
                if (Utility.IsNumber(args[1]) == false)
                {
                    Console.WriteLine("Invalid year");
                    Console.Read();
                    return;
                }
                ////when length is less 
                if (args[1].Length < 4)
                {
                    Console.WriteLine("Wrong Year specified");
                    Console.Read();
                    return;
                }

                year = Convert.ToInt32(args[1]);
                ////call to displaying calender
                CalendarTwoDArray.PrintCalendar(month, year);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
