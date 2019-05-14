//-----------------------------------------------------------------------
// <copyright file="ElementClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ElementClass as class
    /// </summary>
    public abstract class ElementClass
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitorClass">AcceptVisitor as object</param>
        public abstract void AcceptVisitor(VisitorClass visitorClass);
    }
}
