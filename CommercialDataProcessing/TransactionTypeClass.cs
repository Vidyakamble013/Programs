//-----------------------------------------------------------------------
// <copyright file="TransactionTypeClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TransactionTypeClass as class
    /// </summary>
    public class TransactionTypeClass
    {
        /// <summary>
        /// TransactionType enum type
        /// </summary>
        public enum TransactionType
        {
            /// <summary>
            /// The buy
            /// </summary>
            Buy = 0,

            /// <summary>
            /// The sell
            /// </summary>
            Sell = 1,
        }
    }
}
