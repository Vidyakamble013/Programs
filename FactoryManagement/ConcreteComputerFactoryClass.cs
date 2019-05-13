//-----------------------------------------------------------------------
// <copyright file="ConcreteComputerFactoryClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ConcreteComputerFactoryClass as class
    /// </summary>
   public class ConcreteComputerFactoryClass : ServerFactoryClass
    {
        /// <summary>
        /// IFactory as interface
        /// </summary>
        /// <param name="company">company as parameter</param>
        /// <returns>return exception</returns>
        public override IFactory GetFactory(string company)
        {
            switch (company)
            {
                case "laptop":
                    return new LaptopClass();

                case "PC":
                    return new PCClass();

                default:
                    throw new ApplicationException(string.Format("laptop{0} cannot found", company));
            }
        }
    }
}
