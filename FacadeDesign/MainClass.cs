//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MainClass as class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// MinFunction as function
        /// </summary>
        public void MinFunction()
        {
            try
            {
                BookFacadeClass bookFacade = new BookFacadeClass();
                bookFacade.CreateBookFunction();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
