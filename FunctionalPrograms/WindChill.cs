//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// WindChill as class
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// CalculateWindChill as function
        /// </summary>
        public static void CalculateWindChill()
        {
            try
            {
                int temp = 0, speed = 0;
                Utility u = new Utility();
                u.CalculateTemperature(temp, speed);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
