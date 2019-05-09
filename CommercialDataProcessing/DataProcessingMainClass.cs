//-----------------------------------------------------------------------
// <copyright file="DataProcessingMainClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DataProcessingMainClass as class
    /// </summary>
    public class DataProcessingMainClass
    {
        /// <summary>
        /// Data processing.
        /// </summary>
        /// <exception cref="Exception">system exceptions </exception>
        public static void DataProcesssing()
        {
            try
            {
                int caseCondition;
                ////this variable is used for checking the condition of do 
                string doCondition = null;
                DataProcessingClass dataProcessing = new DataProcessingClass();
                do
                {
                    Console.WriteLine("1 adding customer");
                    Console.WriteLine("2 adding stock");
                    Console.WriteLine("3 buying stock");
                    Console.WriteLine("4 selling stock");
                    Console.WriteLine("5 view customers");
                    Console.WriteLine("6 view stock");
                    Console.WriteLine("7 view transaction");
                    Console.WriteLine("8 removing the stock ");
                    caseCondition = Convert.ToInt32(Console.ReadLine());
                    switch (caseCondition)
                    {
                        case 1:
                            ////this case is used for adding customer
                            CustomerData customerData = new CustomerData();
                            customerData.AddCustomer();
                            break;
                        case 2:
                            ////this case is used for adding the stock
                            StockDataClass stockData = new StockDataClass();
                            stockData.AddStock();
                            break;
                        case 3:
                            ////this case is used for buying the stock
                            TransactionClass transaction = new TransactionClass();
                            transaction.BuyStock();
                            break;
                        case 4:
                            ////this case is used for selling the stock
                            TransactionClass transaction1 = new TransactionClass();
                            transaction1.SellStock();
                            break;
                        case 5:
                            ////this case is used for getting the all customer data                           
                            dataProcessing.CustomerData();

                            break;
                        case 6:
                            ////this case is used for getting all the records
                            dataProcessing.StockData();

                            break;
                        case 7:
                            ////this case is used for getting all the Transactions
                            dataProcessing.TransactionData();

                            break;
                        case 8:
                            ////this case is used for removing the stock
                            RemoveStockClass removingStock = new RemoveStockClass();
                            removingStock.RemoveStockFunction();
                            break;
                    }

                    Console.WriteLine("enter y to continue");
                    doCondition = Console.ReadLine();
                }
                while (doCondition.Equals("y"));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
