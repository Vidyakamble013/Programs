//-----------------------------------------------------------------------
// <copyright file="TwoDimensionalArray.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Two Dimensional Array as class
    /// </summary>
    public class TwoDimensionalArray
    {
        /// <summary>
        /// Input Array as class
        /// </summary>
        public static void InputArray()
        {
            try
            {
                int row = 0;
                int column = 0;
                Console.WriteLine("2D arry multipication");
                Utility u = new Utility();
                u.Multiplicationofarray(row, column);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
