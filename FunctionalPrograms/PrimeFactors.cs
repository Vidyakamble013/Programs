//-----------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// here i declare the PrimeFactors() methods. 
    /// </summary>  
   public class PrimeFactors
    {
        /// <summary>
        /// Prime factor as function 
        /// </summary>
        public static void Primefactor()
        {
            try
            {
                Console.WriteLine("Enter any number");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility u = new Utility();
                u.PrimeFactor(number);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
