//-----------------------------------------------------------------------
// <copyright file="AdapterClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.AdapterDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AdapterClass as class
    /// </summary>
    public class AdapterClass
    {
        /// <summary>
        /// ListOfProductDetails as function
        /// </summary>
        /// <returns>return string</returns>
        public List<string> ListOfProductDetails()
        {
            //// Use List as generic collection type
            List<string> news = new List<string>();
            try
            {
                Console.WriteLine("Industrial News");
                Console.WriteLine("Television News");
                Console.WriteLine("Educational News");
                Console.WriteLine("Share Market News");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return news;
        }
    }
}
