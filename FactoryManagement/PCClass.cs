//-----------------------------------------------------------------------
// <copyright file="PCClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PCClass as class
    /// </summary>
   public class PCClass : IFactory
    {
        /// <summary>
        /// LaptopInformation as function
        /// </summary>
        /// <param name="brand">brand as parameter</param>
        public void LaptopInformation(string brand)
        {
            try
            {
                Console.WriteLine("Brand of the PC " + brand);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
