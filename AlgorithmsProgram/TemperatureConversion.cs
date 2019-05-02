//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TemperatureConversion as class
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// TemperatureConversionFunction as method
        /// </summary>
        public static void TemperatureConversionFunction()
        {
            try
            {
                int temperatur = 0;
                Utility.TemperatureConversionMethod(temperatur);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
