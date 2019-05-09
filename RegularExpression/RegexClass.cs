//-----------------------------------------------------------------------
// <copyright file="RegexClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.RegularExpression
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Regex Class
    /// </summary>
   public class RegexClass
    {
        /// <summary>
        /// IsStringChecker function
        /// </summary>
        /// <param name="text">text data member</param>
        /// <returns>return string</returns>
        public static string IsStringChecker(string text)
        {
            try
            {
                int i = 0;
                if (text.Contains(" "))
                {
                    Console.WriteLine("White spaces noe allowed");
                }

                for (i = 0; i < 10; i++)
                {
                    if (text.Contains(i.ToString()))
                    {
                        Console.WriteLine("digit not allowed");
                    }                    
                }

                return text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
