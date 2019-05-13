//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IFactory as interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// LaptopInformation as method
        /// </summary>
        /// <param name="brand">Brand as parameter</param>
        void LaptopInformation(string brand);
    }
}
