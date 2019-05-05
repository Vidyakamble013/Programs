using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalanderUsingQueue
{
    class CalanderInput
    {
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

                QueueCalenderClass.PrintCalendar(month, year);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
