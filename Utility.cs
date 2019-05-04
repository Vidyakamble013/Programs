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

        public static bool StringChecker(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool ContainsCharacter(string personName)
        {
            char[] personNameArray = personName.ToCharArray();
            for (int i = 0; i < personNameArray.Length; i++)
            {
                if (!char.IsLetterOrDigit(personNameArray[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
