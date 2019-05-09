//-----------------------------------------------------------------------
// <copyright file="StockDataClass.cs" company="BridgeLabs">
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
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// StockDataClass as class
    /// </summary>
    public class StockDataClass
    {
        /// <summary>
        /// The constants object
        /// </summary>
        private ConstantClass constants = new ConstantClass();

        /// <summary>
        /// Adds the stock.
        /// </summary>
        public void AddStock()
        {
            try
            {
                ////IList is non - generic collection object that can be individually access by index. 
                IList<StockDataModelClass> stock = new List<StockDataModelClass>();

                //// Takes in the stock information
                Console.WriteLine("enter id of stock");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name of stock");
                string name = Console.ReadLine();
                Console.WriteLine("enter the number of shares");
                int numberOfStocks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter price per share");
                int pricePerShare = Convert.ToInt32(Console.ReadLine());

                ////creating the object of StockDataModel class 
                StockDataModelClass stockDataModel = new StockDataModelClass();
                {
                    stockDataModel.Id = id;
                    stockDataModel.Name = name;
                    stockDataModel.NumberOfShares = numberOfStocks;
                    stockDataModel.PricePerShare = pricePerShare;

                    ////this is used for reading the file
                    using (StreamReader stream = new StreamReader(this.constants.StockData))
                    {
                        string json = stream.ReadToEnd();
                        stream.Close();
                        stock = JsonConvert.DeserializeObject<List<StockDataModelClass>>(json);
                        stock.Add(stockDataModel);

                        ////searializeing the object
                        var convertedJson = JsonConvert.SerializeObject(stock);
                        File.WriteAllText(this.constants.StockData, convertedJson);
                        Console.WriteLine("new stock added");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Gets the stock.
        /// </summary>
        /// <returns> the list</returns>
        public IList<StockDataModelClass> GetStock()
        {
            ////IList is non - generic collection object that can be individually access by index. 
            IList<StockDataModelClass> stock = new List<StockDataModelClass>();
            try
            {
                ////this is used for reading the file
                using (StreamReader stream = new StreamReader(this.constants.StockData))
                {
                    string json = stream.ReadToEnd();
                    stream.Close();
                    ////Deserializeing the object
                    stock = JsonConvert.DeserializeObject<List<StockDataModelClass>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return stock;
        }
    }
}
