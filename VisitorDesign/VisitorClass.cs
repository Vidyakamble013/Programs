//-----------------------------------------------------------------------
// <copyright file="VisitorClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// VisitorClass as class
    /// </summary>
    public abstract class VisitorClass
    {
        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementAClass">concreteElementAClass as object</param>
        public abstract void ConcreteElementA(ConcreteElementAClass concreteElementAClass);

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementBClass">concreteElementBClass as object</param>
        public abstract void ConcreteElementB(ConcreteElementBClass concreteElementBClass);
    }
}
