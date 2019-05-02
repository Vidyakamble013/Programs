//-----------------------------------------------------------------------
// <copyright file="UtilityClass.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UtilityClass as class
    /// </summary>
    public class UtilityClass
    {
        /// <summary>
        /// SortMethod as function
        /// </summary>
        public static void SortMethod()
        {
            try
            {              
                int i = 0;              
                string[] array = new string[i];
                string search = " ";
                Utility.BinarySearchForString(array, search);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
