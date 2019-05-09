//-----------------------------------------------------------------------
// <copyright file="RemoveStockClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
   
    /// <summary>
    /// RemoveStockClass as class
    /// </summary>
    public class RemoveStockClass
    {
        /// <summary>
        /// RemoveStockFunction as function
        /// </summary>
        public void RemoveStockFunction()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = new StreamReader(constantClass.StockData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    streamReader.Close();
                    IList<StockDataModelClass> stockDataModelClasses = JsonConvert.DeserializeObject<List<StockDataModelClass>>(jsonString);
                    foreach (var item in stockDataModelClasses)
                    {
                        Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.NumberOfShares + "\t" + item.PricePerShare);
                    }

                    Console.WriteLine("Which Id do you want to Delete");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    bool deleteItem = true;

                    foreach (var item in stockDataModelClasses)
                    {
                        if (deleteId == item.Id)
                        {
                            Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.NumberOfShares + "\t" + item.PricePerShare);
                            deleteItem = false;
                            break;
                        }
                    }

                    if (deleteItem == true)
                    {
                        Console.WriteLine("Inventory item not available");
                    }

                    var removeItem = stockDataModelClasses.Single(d => d.Id == deleteId);
                    stockDataModelClasses.Remove(removeItem);

                    var convertTojson = JsonConvert.SerializeObject(stockDataModelClasses);
                    File.WriteAllText(constantClass.StockData, convertTojson);
                    Console.WriteLine("Remove Stock Successfully....");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
