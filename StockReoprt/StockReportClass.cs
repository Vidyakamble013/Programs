//-----------------------------------------------------------------------
// <copyright file="StockReportClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.StockReoprt
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// StockReportClass as class
    /// </summary>
    public class StockReportClass
    {
        /// <summary>
        /// StockData as function
        /// </summary>
        public static void StockData()
        {
            try
            {
                //// create instance of ConstantClass
                ConstantClass constantClass = new ConstantClass();   
                
                //// StreamReader class used to read the file
                using (StreamReader stream = File.OpenText(constantClass.StockReoprt))
                {
                    string jsonString = stream.ReadToEnd();
                    //// It returns JSON data in string format. In Deserialization.
                    List<StockModelClass> list = JsonConvert.DeserializeObject<List<StockModelClass>>(jsonString);
                    double totalSum = 0;

                    //// access list items to StockModelClass
                    foreach (var share in list)
                    {
                        Console.WriteLine("Company Name {0} \nShare {1} \nSharePrice {2}", share.Name, share.Numofshare, share.Shareprice); 
                        Console.WriteLine("Total Cost of Company Share = " + (share.Numofshare * share.Shareprice) + "\n");
                        totalSum += share.Numofshare * share.Shareprice; 
                    }

                    Console.WriteLine("Total cost price of Stock =" + totalSum);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {   
                Console.WriteLine(ex.Message);
            }
        }
    }
}
