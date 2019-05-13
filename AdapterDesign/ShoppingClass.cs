//-----------------------------------------------------------------------
// <copyright file="ShoppingClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ShoppingClass as class
    /// </summary>
    public class ShoppingClass
    {
        /// <summary>
        /// AdapterFunction as function
        /// </summary>
        public static void AdapterFunction()
        {
            try
            {
                //// create Instance of an interface an class assign to that interface
                IAdapter adapter = new VendorAdapterClass();

                //// access all values in GetProductDetails using foreach loop.
                foreach (string product in adapter.GetProductDetails())
                {
                    Console.WriteLine(product);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
