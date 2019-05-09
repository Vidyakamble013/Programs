//-----------------------------------------------------------------------
// <copyright file="TransactionClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// TransactionClass as class
    /// </summary>
    public class TransactionClass
    {
        /// <summary>
        /// priceOfShare as field
        /// </summary>
        private int priceOfShare = 0;

        /// <summary>
        /// The data in queue
        /// </summary>
        private Queue<string> dataInqueue = new Queue<string>();

        /// <summary>
        /// Writes the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="data">The data.</param>
        public static void WriteFile(string fileName, object data)
        {
            try
            {
                var convertedJson = JsonConvert.SerializeObject(data);
                File.WriteAllText(fileName, convertedJson);
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }

        /// <summary>
        /// Gets all transactions.
        /// </summary>
        /// <returns>the list</returns>
        public static IList<TransactionModelClass> GetAllTransactions()
        {
            ////IList is non - generic collection object that can be individually access by index. 
            IList<TransactionModelClass> transactions = new List<TransactionModelClass>();
            try
            {
                ConstantClass constants = new ConstantClass();

                ////this is used for reading the file
                using (StreamReader stream = new StreamReader(constants.TranscationData))
                {
                    string json = stream.ReadToEnd();
                    stream.Close();
                    transactions = JsonConvert.DeserializeObject<IList<TransactionModelClass>>(json);
                    stream.Close();
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }

            return transactions;
        }

        /// <summary>
        /// Buys the stock.
        /// </summary>
        /// <exception cref="Exception">
        /// Invalid stock id        
        /// No. of shares you mentioned are not available in stock or invalid input
        /// </exception>
        public void BuyStock()
        {
            try
            {
                int priceOfShare = 0;
                ////creating the object of customer class
                CustomerData customer = new CustomerData();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<CustomerModelClass> customerModels = customer.GetAllCustomer();
                Console.WriteLine("id \t name \t valuation");

                ////this loop is used for printing the elements in a list
                foreach (var items in customerModels)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.Valuation);
                }

                Console.WriteLine("Please enter the customer id");
                int customerId = Convert.ToInt32(Console.ReadLine());

                ////IList is non - generic collection object that can be individually access by index. 
                StockDataClass stockData = new StockDataClass();
                IList<StockDataModelClass> stockModels = stockData.GetStock();
                Console.WriteLine("id \tname \tnumberofshares \tpricepershare");
                ////this loop is used for printing the data in  StockData
                foreach (var items in stockModels)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.NumberOfShares + "\t" + items.PricePerShare);
                }

                Console.WriteLine("Please enter the  Stock Id to select stock for the customer");
                int stockId = Convert.ToInt32(Console.ReadLine());
                StockDataModelClass stockDataModel = null;
                bool stockFl = true;
                ////this loop is used for printing the data in  stockModels
                foreach (var items in stockModels)
                {
                    if (items.Id == stockId)
                    {
                        stockDataModel = items;
                        Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.NumberOfShares + "\t" + items.PricePerShare);
                        stockFl = false;
                    }
                }

                ////this condition is used for checking the whether the stock present or not
                if (stockFl == true)
                {
                    throw new Exception("Invalid stock id");
                }

                Console.WriteLine("Enter the number of shares need to purchase");
                int numberOfShares = Convert.ToInt32(Console.ReadLine());
                string customerName = string.Empty;
                string stockName = string.Empty;
                int amountValuation = 0;
                ////this condition is used for checking whether user entered the valid number of shares
                if (numberOfShares < stockDataModel.NumberOfShares || numberOfShares <= 0)
                {
                    ////int priceOfShare = 0;
                    bool stockFlag = true;
                    ////this loop is used for searching for the given stock id
                    foreach (var items in stockModels)
                    {
                        if (items.Id == stockId)
                        {
                            items.NumberOfShares = items.NumberOfShares - numberOfShares;
                            priceOfShare = items.PricePerShare;
                            stockName = items.Name;
                            stockFlag = false;
                        }
                    }

                    ////this condition is used for checking the id exists
                    if (stockFlag == true)
                    {
                        throw new Exception("Invalid stock id");
                    }

                    bool customerFlag = true;
                    ////this loop is used for searching for the given customer id
                    foreach (var item in customerModels)
                    {
                        if (item.Id == customerId)
                        {
                            item.Valuation = item.Valuation - (priceOfShare * numberOfShares);
                            customerName = item.Name;
                            amountValuation = item.Valuation;
                            customerFlag = false;
                        }
                    }

                    ////this condition is used for checking the id exists
                    if (customerFlag == true)
                    {
                        throw new Exception("Invalid customer id");
                    }
                }
                else
                {
                    throw new Exception("No. of shares you mentioned are not available in stock or invalid input");
                }

                ////creating the object of transactionModel class
                TransactionModelClass transactionModel = new TransactionModelClass()
                {
                    CustomerName = customerName,
                    StockName = stockName,
                    NoOfShares = numberOfShares,
                    Amount = priceOfShare * numberOfShares,
                    Time = DateTime.Now.ToString(),
                    TransactionType = TransactionTypeClass.TransactionType.Buy
                };

                ////IList is non - generic collection object that can be individually access by index. 
                IList<TransactionModelClass> transactionModels = TransactionClass.GetAllTransactions();
                transactionModels.Add(transactionModel);
                ConstantClass constants = new ConstantClass();
                TransactionClass.WriteFile(constants.StockData, stockModels);
                TransactionClass.WriteFile(constants.CustomerData, customerModels);
                TransactionClass.WriteFile(constants.TranscationData, transactionModels);
                Console.WriteLine("purchase sucessfull");
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }

        /// <summary>
        /// Sells the stock.
        /// </summary>
        /// <exception cref="Exception">
        /// Invalid stock id      
        /// No. of shares you mentioned are not available in stock or invalid input
        /// </exception>
        public void SellStock()
        {
            try
            {
                ////creating the object of customer class
                CustomerData customer = new CustomerData();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<CustomerModelClass> customerModels = customer.GetAllCustomer();
                Console.WriteLine("id \t name \t valuation");
                ////this is used for reading the data in customerModels
                foreach (var items in customerModels)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.Valuation);
                }

                Console.WriteLine("Please enter the selling customer id");
                int customerId = Convert.ToInt32(Console.ReadLine());
                ////creating the object of stock data
                StockDataClass stockData = new StockDataClass();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<StockDataModelClass> stockModels = stockData.GetStock();
                Console.WriteLine("id \tname \tnumberofshares \tpricepershare");
                foreach (var items in stockModels)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.NumberOfShares + "\t" + items.PricePerShare);
                }

                Console.WriteLine("Please enter the Stock Id to which stock you want to sell");
                int stockId = Convert.ToInt32(Console.ReadLine());
                StockDataModelClass stockDataModel = null;
                bool stockFl = true;
                ////this loop is used for printing the data in stock model
                foreach (var items in stockModels)
                {
                    if (items.Id == stockId)
                    {
                        stockDataModel = items;
                        Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.NumberOfShares + "\t" + items.PricePerShare);
                        stockFl = false;
                    }
                }

                if (stockFl == true)
                {
                    throw new Exception("Invalid stock id");
                }

                Console.WriteLine("Enter the number of shares need to sell");
                ////taking the input from the user
                int numberOfShares = Convert.ToInt32(Console.ReadLine());
                string customerName = string.Empty;
                string stockName = string.Empty;
                int amountValuation = 0;
                if (numberOfShares > 0)
                {
                    ////int priceOfShare = 0;
                    bool stockFlag = true;
                    ////this loop is used for searching the entered id 
                    foreach (var items in stockModels)
                    {
                        ////this condition is used for checkint the data present in the stock
                        if (items.Id == stockId)
                        {
                            items.NumberOfShares = items.NumberOfShares + numberOfShares;
                            this.priceOfShare = items.PricePerShare * numberOfShares;
                            stockName = items.Name;
                            stockFlag = false;
                        }
                    }

                    if (stockFlag == true)
                    {
                        throw new Exception("Invalid stock id");
                    }

                    bool customerFlag = true;
                    foreach (var item in customerModels)
                    {
                        ////this condition is used for 
                        if (item.Id == customerId)
                        {
                            item.Valuation = item.Valuation + this.priceOfShare;
                            customerName = item.Name;
                            amountValuation = item.Valuation;
                            customerFlag = false;
                        }
                    }

                    if (customerFlag == true)
                    {
                        throw new Exception("Invalid customer id");
                    }
                }
                else
                {
                    throw new Exception("No. of shares you mentioned are not available in stock or invalid input");
                }

                ////creating the object of transactionModel
                TransactionModelClass transactionModel = new TransactionModelClass()
                {
                    CustomerName = customerName,
                    StockName = stockName,
                    NoOfShares = numberOfShares,
                    Amount = this.priceOfShare * numberOfShares,
                    Time = DateTime.Now.ToString(),
                    TransactionType = TransactionTypeClass.TransactionType.Sell
                };

                ////IList is non - generic collection object that can be individually access by index. 
                IList<TransactionModelClass> transactionModels = TransactionClass.GetAllTransactions();
                transactionModels.Add(transactionModel);
                ConstantClass constants = new ConstantClass();

                ////writing the stock in to the file
                TransactionClass.WriteFile(constants.StockData, stockModels);

                ////writing the customer in to the file
                TransactionClass.WriteFile(constants.CustomerData, customerModels);

                ////writing the transaction in to file
                TransactionClass.WriteFile(constants.TranscationData, transactionModels);

                Console.WriteLine("selling is successfull");
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }
    }
}
