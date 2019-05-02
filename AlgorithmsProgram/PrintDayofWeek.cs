//-----------------------------------------------------------------------
// <copyright file="PrintDayofWeek.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Print Day of Week as class
    /// </summary>
    public class PrintDayofWeek
    {
        /// <summary>
        /// PrintDay as function
        /// </summary>
        public static void PrintDay()
        {
            try
            {
            int year = 0, month = 0,  day = 0;
                Utility.DayOfWeek(year, month, day);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
