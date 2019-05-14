//-----------------------------------------------------------------------
// <copyright file="BookClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookClass as class
    /// </summary>
    public class BookClass
    {
        /// <summary>
        /// SetOfBook as function
        /// </summary>
        public void SetOfBook()
        {
            Console.WriteLine("Enter Book-Name");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter Author-Name");
            string authorName = Console.ReadLine();
        }
    }
}
