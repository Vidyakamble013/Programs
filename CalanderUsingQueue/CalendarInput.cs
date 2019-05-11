//-----------------------------------------------------------------------
// <copyright file="CalendarInput.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructureProgram.CalanderUsingQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar Input as class
    /// </summary>
   public class CalendarInput
    {
        /// <summary>
        /// CalendarStart function
        /// </summary>
        public static void CalendarStart()
        {
            try
            {
                int month = 0;
                int year = 0;
                bool loopForMonth = true; ////loops untill valid input for month is given
                while (loopForMonth)
                {
                    Console.WriteLine("Enter the month");
                    string stringMonth = Console.ReadLine();

                    //// call IsNumber function in Utility class
                    if (Utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }

                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    loopForMonth = false;
                }

                bool loopForYear = true; ////loops untill valid input for year is given
                while (loopForYear)
                {
                    Console.WriteLine("Enter the year");
                    string stringYear = Console.ReadLine();

                    //// call IsNumber function in Utility class
                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }  
                    
                    if (stringYear.Length < 4 || stringYear.Length > 4)
                    {
                        Console.WriteLine("Wrong Year specified");
                        continue;
                    }

                    year = Convert.ToInt32(stringYear);
                    loopForYear = false;
                }

                QueueCalendarClass.PrintCalendar(month, year);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
