//-----------------------------------------------------------------------
// <copyright file="BubbleSortString.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BubbleSortString as class
    /// </summary>
    public class BubbleSortString
    {
        /// <summary>
        /// SortStringUsingBubbleSort as class
        /// </summary>
        public static void SortStringUsingBubbleSort()
        {
            try
            {
                Utility.BubbleSortForString();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
