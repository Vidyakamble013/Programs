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
        /// Person is constructor
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
        /// get & set is the method of Name
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// get & set is the method of Balance
        /// </summary>
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        /// <summary>
        /// Deposite as class
        /// </summary>
        /// <param name="depositeamount">depositeamount as parameter</param>
        /// <returns>returns boolean</returns>
        public bool Deposite(int depositeamount)
        {
            try
            {
                if (depositeamount <= 0)
                {
                    Console.WriteLine("deposite amount must be greater then 0");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    this.balance = this.balance + depositeamount;
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
        /// <param name="amountwithdraw">amountwithdraw as parameter</param>
        /// <returns>return boolean</returns>
        public bool WithdrawAmount(int amountwithdraw)
        {
            try
            {
                if (amountwithdraw > this.balance)
                {
                    Console.WriteLine("enough money");
                    return false;
                }
                else
                {
                    this.balance = this.balance - amountwithdraw;
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
