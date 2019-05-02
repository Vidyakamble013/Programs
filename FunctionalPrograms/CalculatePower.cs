//-----------------------------------------------------------------------
// <copyright file="CalculatePower.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// here create Calculate_Power class
    /// </summary>
    public class CalculatePower
    {
        /// <summary>
        /// Powers the function.
        /// </summary>
        public static void PowerFunction()
        {
            try
            {
                Console.WriteLine("Enter The Number");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility u = new Utility();
                u.PowerFunction(number);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
