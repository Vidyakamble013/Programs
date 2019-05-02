//-----------------------------------------------------------------------
// <copyright file="SquareRootFunction.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SquareRootFunction as class
    /// </summary>
    public class SquareRootFunction
    {
        /// <summary>
        /// FindSquareRoot of function
        /// </summary>
        public static void FindSquareRoot()
        {
            try
            {
                int number = 0;
                Utility.SquarerootMethod(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
