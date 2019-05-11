//-----------------------------------------------------------------------
// <copyright file="Person.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.BankingOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person as class
    /// </summary>
   public class Person
    {
        /// <summary>
        /// name as private field
        /// </summary>
        private string name;

        /// <summary>
        /// balance as private field
        /// </summary>
        private double balance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">name as parameter</param>
        /// <param name="balance">balance as parameter</param>
        public Person(string name, int balance)
        {
            try
            {
                this.name = name;
                if (balance < 0)
                {
                    Console.WriteLine("Account must be positive");
                    return;
                }

                this.balance = balance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        /// <summary>
        /// Deposit as class
        /// </summary>
        /// <param name="deposit"> deposit as parameter</param>
        /// <returns>returns boolean</returns>
        public bool Deposit(int deposit)
        {
            try
            {
                if (deposit <= 0)
                {
                    Console.WriteLine("deposite amount must be greater then 0");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    this.balance = this.balance + deposit;
                    Console.WriteLine("Total Acount balance" + " " + this.balance);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// WithdrawAmount as function
        /// </summary>
        /// <param name="withdraw">withdraw as parameter</param>
        /// <returns>return boolean</returns>
        public bool WithdrawAmount(int withdraw)
        {
            try
            {
                if (withdraw > this.balance)
                {
                    Console.WriteLine("enough money");
                    return false;
                }
                else
                {
                    this.balance = this.balance - withdraw;
                    Console.WriteLine("Abailable Balance" + " " + this.balance);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
