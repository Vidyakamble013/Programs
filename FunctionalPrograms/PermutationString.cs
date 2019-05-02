//-----------------------------------------------------------------------
// <copyright file="PermutationString.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Permutation String as class
    /// </summary>
   public class PermutationString
    {
        /// <summary>
        /// Permutation as function
        /// </summary>
        public static void Permutation()
        {
            try
            {
                string str = "null";
   
                int m = 0, n = 0;
                Utility u = new Utility();
                u.FindPermutation(str, m, n);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
