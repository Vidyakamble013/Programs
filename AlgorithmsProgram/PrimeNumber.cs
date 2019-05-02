//-----------------------------------------------------------------------
// <copyright file="PrimeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeNumber as class
    /// </summary>
    public class PrimeNumber
    {
        /// <summary>
        /// CheckPrimeNumber as function
        /// </summary>
        public static void CheckPrimeNumber()
        {
            try
            {
                int number = 0;
                Console.WriteLine("Enter number");
                Utility.FindPrimeNumber(number);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
