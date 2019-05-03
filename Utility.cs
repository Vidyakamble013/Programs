//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility as class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// IsNumber is function
        /// </summary>
        /// <param name="input">input as parameter</param>
        /// <returns>return boolean</returns>
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
