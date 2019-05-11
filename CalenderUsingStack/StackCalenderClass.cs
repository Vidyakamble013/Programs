//-----------------------------------------------------------------------
// <copyright file="StackCalenderClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.CalenderUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackCalendarClass class
    /// </summary>
    public class StackCalenderClass
    {
        /// <summary>
        /// PrintCalendar function
        /// </summary>
        /// <param name="month">month as field</param>
        /// <param name="year">year as field</param>
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                StackClass stack = new StackClass();
                stack.StackInitialise(300);
                string[] monthsArray = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" Su\tMo\tTu\tWe\tTh\tFi\tSur");
                int days = Utility.DaysOfWeek(month, 1, year);
                for (int i = numberOfDaysArray[month]; i >= 0; i++)
                {
                    stack.Push(i);
                }

                for (int i = 0; i < days; i++)
                {
                    Console.Write("\t");
                }

                for (int i = 1; i <= numberOfDaysArray[month]; i++)
                {
                    if (i < 10)
                    {
                        Console.Write(" " + stack.Pop() + "\t");
                    }

                    if (i > 9)
                    {
                        Console.Write(string.Empty + i + "\t");
                    }

                    if ((i + days) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
