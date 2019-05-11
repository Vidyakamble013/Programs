//-----------------------------------------------------------------------
// <copyright file="BankTransaction.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.BankingOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BankTransaction as class
    /// </summary>
   public class BankTransaction
    {
        /// <summary>
        /// Deposit AccountDetails as function
        /// </summary>
        /// <param name="person">person as parameter</param>
        public static void DepositAccountDetails(Person person)
        {
            try
            {
                bool booldepositeamount = true;

                //// check condition true and false
                while (booldepositeamount)
                {
                    Console.WriteLine("Enter deposite amount" + " " + person.Balance + " " + "in your account");
                    string depositeamount = Console.ReadLine();

                    //// call IsNumber function in Utility class
                    if (Utility.IsNumber(depositeamount) == false)
                    {
                        Console.WriteLine("Invalid deposite amount");
                        continue;
                    }

                    if (person.Deposit(Convert.ToInt32(depositeamount)) == false)
                    {
                        continue;
                    }

                    booldepositeamount = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// WithdrawAccountDetails as function
        /// </summary>
        /// <param name="person">person as parameter</param>
        public static void WithdrawAccountDetails(Person person)
        {
            try
            {
                bool boolwithdraw = true;
                while (boolwithdraw)
                {
                    Console.WriteLine("Enter withdraw amount" + " " + person.Balance + " " + "in your saving account");
                    string withdrawamount = Console.ReadLine();

                    //// call IsNumber function in Utility class
                    if (Utility.IsNumber(withdrawamount) == false)
                    {
                        Console.WriteLine("Invalid input amount");
                        continue;
                    }

                    if (person.WithdrawAmount(Convert.ToInt32(withdrawamount)) == false)
                    {
                        continue;
                    }

                    boolwithdraw = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
