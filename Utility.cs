//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1
{
    using System;
    
    /// <summary>
    /// Utility as class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// IsStringCharacter as function
        /// </summary>
        /// <param name="character">character as field</param>
        /// <returns>returns boolean</returns>
        public static bool IsStringCharacter(string character)
        {
            try
            {
                int length = character.Length;
                if (character.Contains(" "))
                {
                    Console.WriteLine("Empty Spaces in not allowed");
                    return false;
                }

                for (int num = 0; num < 10; num++)
                {
                    if (character.Contains(num.ToString()))
                    {
                        Console.WriteLine("integer number is not allowed");
                        return false;
                    }
                }

                if (character.Contains("@") || character.Contains("*") || character.Contains("#"))
                {
                    Console.WriteLine("Special Symbol not allowed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        /// <summary>
        /// IsNumberOnly as function
        /// </summary>
        /// <param name="number">number as field</param>
        /// <returns>returns boolean</returns>
        public static bool IsNumberOnly(double number)
        {
            try
            {
                if (number < 0 || number == 0)
                {
                    Console.WriteLine("Number must be positive Integer");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }      
    }
}
