//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Anagram Palindrome Number as class
    /// </summary>
   public class AnagramPalindromeNumber
    {
        /// <summary>
        /// AnagramPalindrome as function
        /// </summary>
        public static void AnagramPalindrome()
        {
            try
            {
                int number = 0;
                Console.WriteLine("Enetr Number");
                Utility.FindAnagramPalindrome(number);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
