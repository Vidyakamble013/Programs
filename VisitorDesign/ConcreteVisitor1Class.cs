//-----------------------------------------------------------------------
// <copyright file="ConcreteVisitor1Class.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ConcreteVisitor1Class as class
    /// </summary>
    public class ConcreteVisitor1Class : VisitorClass
    {
        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementAClass">concreteElementAClass as object</param>
        public override void ConcreteElementA(ConcreteElementAClass concreteElementAClass)
        {
            try
            {
                Console.WriteLine("{0} visited by {1}", concreteElementAClass.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementBClass">concreteElementBClass as object</param>
        public override void ConcreteElementB(ConcreteElementBClass concreteElementBClass)
        {
            try
            {
                Console.WriteLine("{0} Visited by {1}", concreteElementBClass.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
