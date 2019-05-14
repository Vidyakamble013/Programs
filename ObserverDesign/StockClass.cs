//-----------------------------------------------------------------------
// <copyright file="StockClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ObserverDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StockClass as class
    /// </summary>
    public abstract class StockClass
    {
        /// <summary>
        /// symbol as field
        /// </summary>
        private string symbol;

        /// <summary>
        /// price as field
        /// </summary>
        private double price;

        /// <summary>
        /// create Instance of InventoryInterface.
        /// </summary>
        private List<InventoryInterface> interfaces  = new List<InventoryInterface>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StockClass"/> class.
        /// </summary>
        /// <param name="symbol1">symbol1 as parameter</param>
        /// <param name="price1">price1 as parameter</param>
        public StockClass(string symbol1, double price1)
        {
            this.symbol = symbol1;
            this.price = price1;
        }

        /// <summary>
        /// Gets or sets Price
        /// </summary>
        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();                    
                }
            }
        }

        /// <summary>
        /// Gets Symbol
        /// </summary>
        public string Symbol
        {
            get { return this.symbol; }
        }

        /// <summary>
        /// Attach as function
        /// </summary>
        /// <param name="inventoryInterface">inventoryInterface as object of an InventoryInterface</param>
        public void Attach(InventoryInterface inventoryInterface)
        {
            try
            {
                this.interfaces.Add(inventoryInterface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Detach as function
        /// </summary>
        /// <param name="interface">interface as object of an InventoryInterface</param>
        public void Detach(InventoryInterface @interface)
        {
            try
            {
                this.interfaces.Remove(@interface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Notify as function
        /// </summary>
        public void Notify()
        {
            try
            {
                foreach (InventoryInterface @interface in this.interfaces)
                {
                    @interface.Update(this);
                }

                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
