//-----------------------------------------------------------------------
// <copyright file="InventoryClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ObserverDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventoryClass as class
    /// </summary>
    public class InventoryClass : InventoryInterface
    {
        /// <summary>
        /// name as field
        /// </summary>
        private string name;

        /// <summary>
        /// StockClass as class
        /// </summary>
        private StockClass stock;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryClass"/> class.
        /// </summary>
        /// <param name="name">name as parameter</param>
        public InventoryClass(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets or sets StockClass
        /// </summary>
        public StockClass StockClass
        {
            get
            {
                return this.StockClass;
            }

            set
            {
                this.StockClass = value;
            }
        }

        /// <summary>
        /// Update as function
        /// </summary>
        /// <param name="stockClass">stockClass as object</param>
        public void Update(StockClass stockClass)
        {
            try
            {
                Console.WriteLine("Placed position {0} {1}'s" + "change to {2 : C}", this.name, this.stock.Symbol, this.stock.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
