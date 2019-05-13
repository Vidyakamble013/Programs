//-----------------------------------------------------------------------
// <copyright file="ServerFactoryClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FactoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ServerFactoryClass as class
    /// </summary>
    public abstract class ServerFactoryClass
    {
        /// <summary>
        /// GetFactory as function
        /// </summary>
        /// <param name="company">company as parameter</param>
        /// <returns>return string</returns>
        public abstract IFactory GetFactory(string company);
    }
}
