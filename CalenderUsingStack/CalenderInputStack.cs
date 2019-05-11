
//-----------------------------------------------------------------------
// <copyright file="CalenderInputStack.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.CalenderUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// CalendarInputStack class
    /// </summary>
    public class CalenderInputStack
    {
        /// <summary>
        /// StackCalendar function
        /// </summary>
        public static void StackCalender()
        {
            try
            {
                int year = 0;
                int month = 0;
                bool forMonth = true;
                while (forMonth)
                {
                    Console.WriteLine("Enter months name");
                    string monthname = Console.ReadLine();

                    //// call IsNumber function in Utility class
                    if (Utility.IsNumber(monthname) == false)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    //// call IsNumber function in Utility class
                    month = Convert.ToInt32(monthname);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    forMonth = false;
                }

                bool forYear = true;
                while (forYear)
                {
                    Console.WriteLine("Enter the year");
                    string stringYear = Console.ReadLine();
                    ////checks year is number or not
                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid year");
                        continue;
                    }
                    ////checks for length of year
                    if (stringYear.Length < 4 || stringYear.Length > 4)
                    {
                        Console.WriteLine("Wrong Year specified");
                        continue;
                    }

                    year = Convert.ToInt32(stringYear);
                    forYear = false;
                }

                StackCalenderClass.PrintCalendar(month, year);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
