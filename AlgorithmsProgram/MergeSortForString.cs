//-----------------------------------------------------------------------
// <copyright file="MergeSortForString.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MergeSortForString as class
    /// </summary>
   public class MergeSortForString
    {
        /// <summary>
        /// MergeSort as parameter
        /// </summary>
        public static void MergeSort()
        {
            try
            {
                Utility.SortStringUsingMergeSort();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
