//-----------------------------------------------------------------------
// <copyright file="DataProcessingClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DataProcessingClass as class
    /// </summary>
    public class DataProcessingClass
    {
        /// <summary>
        /// CustomerData as function
        /// </summary>
        public void CustomerData()
        {
            try
            {
                ////customer data in file
                CustomerData customerData1 = new CustomerData();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<CustomerModelClass> values = customerData1.GetAllCustomer();

                //// Loops over to get customer data
                foreach (var items in values)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.Valuation);
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }

        /// <summary>
        /// Stocks the data.
        /// </summary>
        public void StockData()
        {
            try
            {
                ////this case is used for getting all the records
                StockDataClass stockData1 = new StockDataClass();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<StockDataModelClass> stock = stockData1.GetStock();

                //// Loops over to get stock data
                foreach (var items in stock)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.NumberOfShares + "\t" + items.PricePerShare);
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }

        /// <summary>
        /// Transactions the data.
        /// </summary>
        public void TransactionData()
        {
            try
            {
                ////IList is non - generic collection object that can be individually access by index. 
                IList<TransactionModelClass> valuess = TransactionClass.GetAllTransactions();

                //// Loops over to get transaction data
                foreach (var items in valuess)
                {
                    Console.WriteLine(items.CustomerName + "\t" + items.StockName + "\t" + items.TransactionType + "\t" + items.NoOfShares + "\t" + items.Amount + "\t" + items.Time);
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }
    }
}
