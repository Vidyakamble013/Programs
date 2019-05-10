//-----------------------------------------------------------------------
// <copyright file="JSONInventoryModelClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.JSONInventory
{
    using System.Collections.Generic;
   
    /// <summary>
    /// JSONInventoryModelClass as class
    /// </summary>
    public class JSONInventoryModelClass
    {
        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public int Price
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the product is active.
        /// </summary>
        public int Weight
        {
            get;
            set;
        }
    }

    /// <summary>
    /// InventoryDisplayInfo as partial class 
    /// </summary>
    public partial class InventoryDisplayInfo
    {
        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public List<JSONInventoryModelClass> RiceInformation
        {
            get;
            set;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public List<JSONInventoryModelClass> WheatInformation
        {
            get;
            set;
        }

        /// <summary>
        ///   Gets or sets the name of the PulsesInformation. 
        /// </summary>
        public List<JSONInventoryModelClass> PulsesInformation
        {
            get;
            set;
        }
    }
}
