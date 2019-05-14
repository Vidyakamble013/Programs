//-----------------------------------------------------------------------
// <copyright file="MainVisitorClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MainVisitorClass as class
    /// </summary>
    public class MainVisitorClass
    {
        /// <summary>
        /// VisitorFunction as function
        /// </summary>
        public static void VisitorFunction()
        {
            try
            {
                //// create Instance of an StructurClass class
                StructureClass structurClass = new StructureClass();
                structurClass.Attach(new ConcreteElementAClass());
                structurClass.Attach(new ConcreteElementBClass());

                //// create Instance of an ConcreteVisitor1Class class
                ConcreteVisitor1Class concreteVisitor1 = new ConcreteVisitor1Class();

                //// create Instance of an ConcreteVisitor2Class class
                ConcreteVisitor2Class concreteVisitor2 = new ConcreteVisitor2Class();

                structurClass.AcceptVisitor(concreteVisitor1);
                structurClass.AcceptVisitor(concreteVisitor2);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
