//-----------------------------------------------------------------------
// <copyright file="Headstails.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Heads tails as class
    /// </summary>
    public class HeadsTails
    {
        /// <summary>
        /// Toss coin
        /// </summary>
        public static void Tosscoin()
        {
            try
            {
                Console.WriteLine("Enter positive integer");
                int flipcoin = Convert.ToInt32(Console.ReadLine());
                Utility u = new Utility();
                u.Tossgame(flipcoin);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
