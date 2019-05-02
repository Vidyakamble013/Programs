//-----------------------------------------------------------------------
// <copyright file="HarmonicProgram.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  here create harmonic Program  
    /// </summary>
    public class HarmonicProgram
    {
        /// <summary>
        /// Harmonic the number.
        /// </summary>
        public static void Hormonic()
        {
            try
            {
                float number = 0;
                Utility u = new Utility();
                u.Harmonic(number);
                Console.WriteLine();
             }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
