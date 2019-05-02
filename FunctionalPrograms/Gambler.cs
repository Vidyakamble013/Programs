//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Gambler as class
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gambler Game as function
        /// </summary>
        public static void GamblerGame()
        {
            int stake, goal;

            Console.WriteLine("Enter stake number");
            stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter goal number");
            goal = Convert.ToInt32(Console.ReadLine());

            Utility u = new Utility();
            u.Winlossgame(stake, goal);
            Console.ReadLine();
        }
    }
}
