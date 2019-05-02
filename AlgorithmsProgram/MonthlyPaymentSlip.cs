//-----------------------------------------------------------------------
// <copyright file="MonthlyPaymentSlip.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MonthlyPaymentSlip as class
    /// </summary>
   public class MonthlyPaymentSlip
    {
        /// <summary>
        /// monthlyPayment as function
        /// </summary>
        public static void MonthlyPayment()
        {
            try
            {       
                Console.WriteLine("Enter amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number of years");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter rate of interest");
                int rate = Convert.ToInt32(Console.ReadLine());
                Utility.PaymentSlip(amount, year, rate);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
