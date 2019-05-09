//-----------------------------------------------------------------------
// <copyright file="StockModelClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.StockReoprt
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
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public int Numofshare
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public int Shareprice
        {
            get;
            set;
        }
    }
}
