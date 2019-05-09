//-----------------------------------------------------------------------
// <copyright file="RegexExpressionClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.RegularExpression
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// RegexExpressionClass as class
    /// </summary>
    public class RegexExpressionClass
    {
        /// <summary>
        /// MatchFunction function
        /// </summary>
        /// <param name="text">text data member</param>
        /// <param name="expression">expression data member</param>
        /// <param name="pattern">pattern data member</param>
        /// <returns>return string</returns>
        public static string MatchFunction(string text, string expression, string pattern)
        {
            Regex regex = new Regex(pattern);
            string newString = regex.Replace(text, expression);
            return newString;
        }

        /// <summary>
        /// OperationFunction function
        /// </summary>
        public void OperationFunction()
        {
            this.ReadInfo();
        }

        /// <summary>
        /// RetrieveData function
        /// </summary>
        /// <param name="firstName">firstName as field</param>
        /// <param name="lastName">lastName as field</param>
        /// <param name="mobNumber">mobNumber as field</param>
        /// <param name="date">date as field</param>
        public void RetrieveData(string firstName, string lastName, string mobNumber, string date)
        {
            try
            {
                string pattern = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz MM/DD/YYYY";
                string namePattern = "<<name>>";
                pattern = RegexExpressionClass.MatchFunction(pattern, firstName, namePattern);
                string fullNamePattern = "<<full name>>";
                pattern = RegexExpressionClass.MatchFunction(pattern, firstName + " " + lastName, fullNamePattern);
                string mobilePattern = "91-xxxxxxxxxx";
                pattern = RegexExpressionClass.MatchFunction(pattern, "91" + " " + mobNumber, mobilePattern);
                string currentdateformat = "<<dd/mm/yyyy>>";
                DateTime today = DateTime.Today;
                pattern = RegexExpressionClass.MatchFunction(pattern, today.ToString(), currentdateformat);
                Console.WriteLine(pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ReadInfo as function
        /// </summary>
        public void ReadInfo()
        {
            try
            {
                Console.WriteLine("Your First Name");
                string firstName = RegexClass.IsStringChecker(Console.ReadLine());
                Console.WriteLine("Your Last Name");
                string lastName = RegexClass.IsStringChecker(Console.ReadLine());
                Console.WriteLine("Mobile Number");
                string contactNo = Console.ReadLine();
                int length = contactNo.Length;
                if (length > 10 && length < 10)
                {
                    Console.WriteLine("Mobile number must be 10 digit");
                }

                DateTime currentDay = DateTime.Today;
                string todaysDate = currentDay.ToString("d");

                //// IsMatch method used to check for validation
                if (Regex.IsMatch(contactNo, @"[0-9]{10}") && Regex.IsMatch(firstName, @"[a-zA-z]") && Regex.IsMatch(lastName, @"[a-zA-z]"))
                {
                    this.RetrieveData(firstName, lastName, contactNo, todaysDate);
                }
                else
                {
                    Console.WriteLine("Wrong information");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
