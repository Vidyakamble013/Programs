//-----------------------------------------------------------------------
// <copyright file="StockModelClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StockModelClass as class
    /// </summary>
    public class StockModelClass
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string ShareName { get; set; }

        /// <summary>
        /// Gets or sets the available shares.
        /// </summary>
        /// <value>
        /// The available shares.
        /// </value>
        public int NumberOfShares { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int PriceOfShare { get; set; }
    }
}
