//-----------------------------------------------------------------------
// <copyright file="InventoryClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// InventoryClass class
    /// </summary>
    public class InventoryClass
    {
        /// <summary>
        /// InventoryData function
        /// </summary>
        public void InventoryData()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                //// use StreamReader as class to read file
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    JSONInventory.InventoryDisplayInfo list = JsonConvert.DeserializeObject<JSONInventory.InventoryDisplayInfo>(jsonString);
                    IList<JSONInventory.JSONInventoryModelClass> rice = list.RiceInformation;
                    Console.WriteLine("Different Types of Rices");
                    Console.WriteLine("Name" + " " + "Price" + " " + "Weight");
                    double priceofRice = 0;

                    //// access data into a TransactionModelClass class
                    foreach (var item in rice)
                    {
                        Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        priceofRice = priceofRice + (item.Price * item.Weight);                      
                    }

                    Console.WriteLine(priceofRice);
                    Console.WriteLine();
                    //// IList collection is used
                    IList<JSONInventory.JSONInventoryModelClass> wheat = list.WheatInformation;
                    Console.WriteLine("Different types of Wheats");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofWheat = 0;

                    //// access data into a wheat json array. 
                    foreach (var item in wheat)
                    {
                        Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        priceofWheat = priceofWheat + (item.Price * item.Weight);
                    }

                    Console.WriteLine(priceofWheat);
                    Console.WriteLine();
                    IList<JSONInventory.JSONInventoryModelClass> pulses = list.PulsesInformation;
                    Console.WriteLine("Types of Pulses");
                    Console.WriteLine("Name" + "  " + "Price" + "  " + "weight");
                    double priceodPulses = 0;

                    //// access data into a pilses array
                    foreach (var item in pulses)
                    {
                        Console.WriteLine(item.Name + "  " + item.Price + "  " + item.Weight);
                        priceodPulses = priceodPulses + (item.Price * item.Weight);
                    }

                    Console.WriteLine(priceodPulses);
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
