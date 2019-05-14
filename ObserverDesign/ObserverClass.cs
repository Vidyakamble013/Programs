//-----------------------------------------------------------------------
// <copyright file="ObserverClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ObserverDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ObserverClass as class
    /// </summary>
    public class ObserverClass
    {
        /// <summary>
        /// ObserverFunction as function
        /// </summary>
        public static void ObserverFunction()
        {
            try
            {
                //// create Instance od an CompanyClass class.
                CompanyClass companyClass = new CompanyClass("Capgemini", 100.00);
                companyClass.Attach(new InventoryClass("Attach"));
                companyClass.Detach(new InventoryClass("Detach"));

                companyClass.Price = 100.10;
                companyClass.Price = 100.20;
                companyClass.Price = 100.30;
                companyClass.Price = 100.40;

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
