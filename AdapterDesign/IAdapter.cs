//-----------------------------------------------------------------------
// <copyright file="IAdapter.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IAdapter interface 
    /// </summary>
   public interface IAdapter
    {
        /// <summary>
        /// GetProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        List<string> GetProductDetails();
    }
}
