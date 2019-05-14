//-----------------------------------------------------------------------
// <copyright file="BookTypeClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookTypeClass as class
    /// </summary>
    public class BookTypeClass
    {
        /// <summary>
        /// SetOfBookDetails as function
        /// </summary>
        public void SetOfBookDetails()
        {
            try
            {
                Console.WriteLine("Which tyoe Of Book you have");
                string booktype = Console.ReadLine();               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
