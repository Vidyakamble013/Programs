//-----------------------------------------------------------------------
// <copyright file="InventoryInterface.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ObserverDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventoryInterface as interface
    /// </summary>
    public interface InventoryInterface
    {
        /// <summary>
        /// Update as function
        /// </summary>
        /// <param name="stockClass">stockClass as object</param>
        void Update(StockClass stockClass);
    }
}
