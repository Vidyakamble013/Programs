//-----------------------------------------------------------------------
// <copyright file="InventoryModelClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.InventoryManagement
{
    using System.Collections.Generic;
    
    /// <summary>
    /// InventoryModelClass class
    /// </summary>
    public class InventoryModelClass
    {
        /// <summary>
        /// name private data member 
        /// </summary>
        private string name;

        /// <summary>
        /// price private data member
        /// </summary>
        private double price;

        /// <summary>
        /// weight private data member
        /// </summary>
        private double weight;

        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether the product is active. 
        /// </summary>
        public double Price
        {
            get => this.price;
            set => this.price = value;
        }

        /// <summary>
        ///   Gets or sets the name of the Weight. 
        /// </summary>
        public double Weight
        {
            get => this.weight;
            set => this.weight = value;
        }

        /// <summary>
        /// InventoryInfo class
        /// </summary>
        public class InventoryInfo
        {
            /// <summary>
            ///   Gets or sets the name of the RiceInformation. 
            /// </summary>
            public List<InventoryModelClass> RiceInformation
            {
                get;
                set;
            }

            /// <summary>
            ///   Gets or sets the name of the WheatInformation. 
            /// </summary>
            public List<InventoryModelClass> WheatInformation
            {
                get;
                set;
            }

            /// <summary>
            ///   Gets or sets the name of the PulsesInformation. 
            /// </summary>
            public List<InventoryModelClass> PulsesInformation
            {
                get;
                set;
            }
        }
    }
}
