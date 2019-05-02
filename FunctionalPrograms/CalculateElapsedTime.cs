//-----------------------------------------------------------------------
// <copyright file="CalculateElapsedTime.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calculate Elapsed Time as class
    /// </summary>
   public class CalculateElapsedTime
    {
        /// <summary>
        /// Elapsed Time Different as function
        /// </summary>
        public static void ElapsedTimeDifferent()
        {
            try
            {
                Utility u = new Utility();
                u.ElapsedTime();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
