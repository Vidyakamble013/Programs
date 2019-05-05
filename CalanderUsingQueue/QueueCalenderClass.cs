using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalanderUsingQueue
{
    class QueueCalenderClass
    {
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                Queue<int> queueInt = new Queue<int>();
                Queue<string> queueString = new Queue<string>();
                string[] monthsArray = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] days = { "S", "M", "Tu", "W", "Th", "F", "S" };

                ////to check if the given year is aleap year
                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" S\tM\tT\tW\tTH\tF\tS");

                //// to get the first day of the given month.
                int day = Utility.DaysOfWeek(month, 1, year);

                //// enqueing all the days of specified month.
                for (int i = 1; i < numberOfDaysArray[month]; i++)
                {
                    queueInt.Enqueue(i);
                }

                for (int i = 1; i < days.Length; i++)
                {
                    queueString.Enqueue(days[i]);
                }

                Console.WriteLine();

                //// leaves empty spaces till the first day starts.
                for (int i = 0; i < day; i++)
                {
                    Console.Write("\t");
                }

                for (int i = 1; i <= numberOfDaysArray[month]; i++)
                {
                    if (i < 10)
                    {
                        Console.Write("  " + queueInt.Dequeue() + "\t");
                    }

                    if (i > 9)
                    {
                        Console.Write(" " + i + "\t");
                    }

                    //// to get to the next line after.
                    if ((i + day) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
