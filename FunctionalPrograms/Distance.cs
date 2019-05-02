//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Distance as class
    /// </summary>
   public class Distance
    {
        /// <summary>
        /// Calculate Distance as function
        /// </summary>
        public static void CalculateDistance()
        {
            try
            {
                int i = 0, j = 0;
                Utility u = new Utility();
                u.DistanceFromPoint(i, j);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
