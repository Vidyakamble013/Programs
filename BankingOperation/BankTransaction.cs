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
        /// DepositeAccountDetails as function
        /// </summary>
        /// <param name="person">person as parameter</param>
        public static void DepositeAccountDetails(Person person)
        {
            try
            {
                bool booldepositeamount = true;

                while (booldepositeamount)
                {
                    Console.WriteLine("Enter deposite amount" + " " + person.Balance + " " + "in your account");
                    string depositeamount = Console.ReadLine();

                    if (Utility.IsNumber(depositeamount) == false)
                    {
                        Console.WriteLine("Invalid deposite amount");
                        continue;
                    }

                    if (person.Deposite(Convert.ToInt32(depositeamount)) == false)
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
