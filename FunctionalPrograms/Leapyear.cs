//-----------------------------------------------------------------------
// <copyright file="Leapyear.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Leap year is a class
    /// </summary>
    public class Leapyear
    {
        /// <summary>
        /// Check leap Year is method
        /// </summary>
        public static void CheckleapYear()
        {
            try
            {
                Console.WriteLine("Enter leap year");
                int year = Convert.ToInt32(Console.ReadLine());              
                Utility utility = new Utility();
                utility.FindLeapYear(year);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
