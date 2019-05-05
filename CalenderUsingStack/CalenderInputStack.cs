using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalenderUsingStack
{
   public class CalenderInputStack
    {
        public static void StackCalender()
        {
            try
            {
                int year = 0;
                int month = 0;

                bool ForMonth = true;
                while(ForMonth)
                {
                    Console.WriteLine("Enter months name");
                    string monthname = Console.ReadLine();

                    if (Utility.IsNumber(monthname)== false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }
                    month = Convert.ToInt32(monthname);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }
                    ForMonth = false;
                }
                bool ForYear = true;
                while(ForYear)
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
                    ForYear = false;
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
