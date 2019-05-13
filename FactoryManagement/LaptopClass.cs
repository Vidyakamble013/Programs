//-----------------------------------------------------------------------
// <copyright file="LaptopClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LaptopClass as class
    /// </summary>
   public class LaptopClass : IFactory
    {
        /// <summary>
        /// LaptopInformation as function
        /// </summary>
        /// <param name="brand">brand as parameter</param>
        public void LaptopInformation(string brand)
        {
            try
            {
                Console.WriteLine("The name of the laptop " + brand);
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
