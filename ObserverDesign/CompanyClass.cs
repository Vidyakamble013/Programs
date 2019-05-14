//-----------------------------------------------------------------------
// <copyright file="CompanyClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ObserverDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// CompanyClass as class
    /// </summary>
    public class CompanyClass : StockClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyClass"/> class.
        /// </summary>
        /// <param name="symbol">symbol as parameter</param>
        /// <param name="price">price as parameter</param>
        public CompanyClass(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
