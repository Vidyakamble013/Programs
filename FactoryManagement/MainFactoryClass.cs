//-----------------------------------------------------------------------
// <copyright file="MainFactoryClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MainFactoryClass as class
    /// </summary>
    public class MainFactoryClass
    {
        /// <summary>
        /// Factory as function
        /// </summary>
        public static void Factory()
        {
            try
            {
                //// create Instance of ServerFactoryClass class
                ServerFactoryClass serverFactory = new ConcreteComputerFactoryClass();
                IFactory laptop = serverFactory.GetFactory("laptop");
                laptop.LaptopInformation("HP_Laptop");

                IFactory pc = serverFactory.GetFactory("PC");
                //// call LaptopInformation function of the IFactory interface
                pc.LaptopInformation("HCL_PC");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
