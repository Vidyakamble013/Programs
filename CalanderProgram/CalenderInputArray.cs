using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalanderProgram
{
    class CalenderInputArray
    {
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
                CalanderTwoDArray.PrintCalendar(month, year);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
