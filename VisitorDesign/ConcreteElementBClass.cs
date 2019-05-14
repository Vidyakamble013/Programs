//-----------------------------------------------------------------------
// <copyright file="ConcreteElementBClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ConcreteElementBClass as class
    /// </summary>
    public class ConcreteElementBClass : ElementClass
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitorClass">visitorClass as object</param>
        public override void AcceptVisitor(VisitorClass visitorClass)
        {
            try
            {
                visitorClass.ConcreteElementB(this);
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
