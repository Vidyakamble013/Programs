//-----------------------------------------------------------------------
// <copyright file="AnagramString.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AnagramString as class
    /// </summary>
   public class AnagramString
    {
        /// <summary>
        /// CheckAnagram as function
        /// </summary>
        public static void CheckAnagram()
        {
            try
            {
                string string1 = " ";
                string string2 = " ";
                Console.WriteLine("Enter String");
                Utility.AnagramFunction(string1, string2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
