//-----------------------------------------------------------------------
// <copyright file="QuadraticFunction.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// QuadraticFunction as class
    /// </summary>
    public class QuadraticFunction
    {
        /// <summary>
        /// QuadraticMethods as function
        /// </summary>
        public static void QuadraticMethods()
        {
            try
            {
                int input1 = 0, input2 = 0, input3 = 0;
                Utility u = new Utility();
                u.Quadratic(input1, input2, input3);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
