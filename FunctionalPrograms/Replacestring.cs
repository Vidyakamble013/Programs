//-----------------------------------------------------------------------
// <copyright file="Replacestring.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Replace String as class
    /// </summary> 
    public class ReplaceString
    {
        /// <summary>
        /// Replace letter as function
        /// </summary>
        public static void Replaceletter()
        {
            try
            {
                Console.WriteLine("Enter Name");
                string username = Convert.ToString(Console.ReadLine());
                Utility u = new Utility();
                u.ReplaceUserName(username);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
