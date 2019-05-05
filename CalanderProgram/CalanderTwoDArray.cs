using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalanderProgram
{
    public class CalanderTwoDArray
    {
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

                for (int i = 0; i < day; i++)
                {
                    Console.Write("    ");
                }

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
