//-----------------------------------------------------------------------
// <copyright file="BinaryToDecimal.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BinaryToDecimal as class
    /// </summary>
    public class BinaryToDecimal
    {
        /// <summary>
        /// BinaryToDecimalConversion as class
        /// </summary>
        public static void BinaryToDecimalConversion()
        {
            try
            {
                int number = 0;
                Utility.BinaryToDecimal(number);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
