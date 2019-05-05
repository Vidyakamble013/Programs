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

        public static bool CheckLeapYear(int year)
        {

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DaysOfWeek(int m, int d, int y)
        {
            int y0, x, m0, d0;
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + (12 * ((14 - m) / 12)) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;
            int[] days = { 0, 1, 2, 3, 4, 5, 6 };
            return days[d0];
        }

        public static bool PrimeNumber(int n)
        {
            try
            {
                //// Checks if number is 0 or 1
                if (n == 0 || n == 1)
                {
                    return false;
                }

                //// Loops over to find out the number is prime or not
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        public static bool AnagramNumber(string string1, string string2)
        {
            try
            {
                if (string1.Length == 1 || string2.Length == 1)
                {
                    //// If string length are not equal returns false
                    if (string1.Length != string2.Length)
                    {
                        return false;
                    }
                }

                char[] char1 = string1.ToLower().ToCharArray();
                char[] char2 = string2.ToLower().ToCharArray();

                //// Sorts the array using Array.Sort() method
                Array.Sort(char1);
                Array.Sort(char2);

                //// Storing charachters in String 
                string s3 = new string(char1);
                string s4 = new string(char2);

                //// Checks if the two arrays are equal or not
                if (s3.Equals(s4))
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
    }
}
