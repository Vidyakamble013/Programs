//-----------------------------------------------------------------------
// <copyright file="StructureClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.VisitorDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StructureClass as class
    /// </summary>
    public class StructureClass
    {
        /// <summary>
        /// ElementClass as class
        /// </summary>
        private List<ElementClass> elementClasses = new List<ElementClass>();

        /// <summary>
        /// Attach as function
        /// </summary>
        /// <param name="element">element as object</param>
        public void Attach(ElementClass element)
        {
            try
            {
                this.elementClasses.Add(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Detach as function
        /// </summary>
        /// <param name="element">element as object</param>
        public void Detach(ElementClass element)
        {
            try
            {
                this.elementClasses.Remove(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitorClass">visitorClass as object</param>
        public void AcceptVisitor(VisitorClass visitorClass)
        {
            try
            {
                foreach (ElementClass elementClass in this.elementClasses)
                {
                    elementClass.AcceptVisitor(visitorClass);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
