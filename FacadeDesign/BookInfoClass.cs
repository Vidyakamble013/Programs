//-----------------------------------------------------------------------
// <copyright file="BookInfoClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookInfoClass as class
    /// </summary>
    public class BookInfoClass
    {
        /// <summary>
        /// BookInformation as function
        /// </summary>
        public void BookInformation()
        {
            try
            {
                Console.WriteLine("Book Info class function called");
                Console.WriteLine("Book price");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select your standard");
                string standard = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
