//-----------------------------------------------------------------------
// <copyright file="VendorAdapterClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// VendorAdapterClass as class
    /// </summary>
    public class VendorAdapterClass : IAdapter
    {
        /// <summary>
        /// Use List as generic collection of GetProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        public List<string> GetProductDetails()
        {
            //// Create Instance of an AdapterClass classs
            AdapterClass adapterClass = new AdapterClass();
            return adapterClass.ListOfProductDetails();
        }
    }
}
