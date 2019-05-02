//-----------------------------------------------------------------------
// <copyright file="BinarySearchForInteger.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BinarySearchForInteger as class
    /// </summary>
    public class BinarySearchForInteger
    {
        /// <summary>
        /// BinarySearchInteger as function
        /// </summary>
        public static void BinarySearchInteger()
        {
            try
            {
                int[] array = { };             
                Utility.IntegerBinarySearch(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
