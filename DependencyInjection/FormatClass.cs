//-----------------------------------------------------------------------
// <copyright file="FormatClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FormatClass as class
    /// </summary>
    public class FormatClass : ITextInterface
    {
        /// <summary>
        /// Display as function
        /// </summary>
        public void Display()
        {
            try
            {
                Console.WriteLine("In format class implement interface method");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
