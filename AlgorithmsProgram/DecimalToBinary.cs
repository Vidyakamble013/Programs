//-----------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DecimalToBinary as class
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// DecimalToBinaryConversion as function
        /// </summary>
        public static void DecimalToBinaryConversion()
        {
            try
            {
                int number = 0;
                Utility.ToBinaryConversion(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
