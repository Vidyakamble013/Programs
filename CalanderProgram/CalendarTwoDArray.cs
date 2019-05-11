//-----------------------------------------------------------------------
// <copyright file="CalendarTwoDArray.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructureProgram.CalanderProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar TwoDArray as class
    /// </summary>
    public class CalendarTwoDArray
    {
        /// <summary>
        /// PrintCalendar function
        /// </summary>
        /// <param name="month">month as parameter</param>
        /// <param name="year">year as parameter</param>
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                string[] monthsArray = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                ////to check if the given year is aleap year
                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" S   M   T   W   TH   F   S");

                ////getting the first day of specified month and year
                int day = Utility.DaysOfWeek(month, 1, year);

                //// check the days of week using for loop
                for (int i = 0; i < day; i++)
                {
                    Console.Write("    ");
                }

                //// take loop for month range
                for (int i = 1; i <= numberOfDaysArray[month]; i++)
                {
                    if (i < 10)
                    {
                        Console.Write("  " + i + " "); ////for spacing purpose when day i is less double space
                    }

                    if (i > 9)
                    {
                        Console.Write(" " + i + " ");  ////for single space
                    }

                    if ((i + day) % 7 == 0)
                    {
                        Console.WriteLine();  //// to get to the next line after 7 days
                    }
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
