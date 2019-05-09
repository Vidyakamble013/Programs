//-----------------------------------------------------------------------
// <copyright file="DisplayClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.JSONInventory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// DisplayClass as class
    /// </summary>
    public static class DisplayClass
    {
        /// <summary>
        /// InputFunction function
        /// </summary>
        public static void InputFunction()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    InventoryDisplayInfo list = JsonConvert.DeserializeObject<InventoryDisplayInfo>(jsonString);

                    ////IList is non - generic collection object that can be individually access by index. 
                    IList<JSONInventoryModelClass> rice = list.RiceInformation;
                    Console.WriteLine("Types of Rice", rice);
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofRice = 0;

                    //// access rice json array objects
                    foreach (var item in rice)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceofRice = priceofRice + (item.Price * item.Weight);
                    }

                    Console.WriteLine("Total price of rices" + priceofRice);
                    Console.WriteLine();

                    ////IList is non - generic collection object that can be individually access by index. 
                    IList<JSONInventoryModelClass> wheat = list.WheatInformation;

                    //// access wheat json array objects
                    Console.WriteLine("Types of Wheat");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofWheat = 0;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceofWheat = priceofWheat + (item.Price * item.Weight);
                    }

                    Console.WriteLine("Total price of rices" + priceofWheat);
                    Console.WriteLine();

                    ////IList is non - generic collection object that can be individually access by index. 
                    IList<JSONInventoryModelClass> pulse = list.PulsesInformation;
                    Console.WriteLine("Types of Pulses");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofPulses = 0;

                    //// access pulses json array objects
                    foreach (var item in pulse)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceofPulses = priceofPulses + (item.Price * item.Weight);
                    }

                    Console.WriteLine("Total price of wheat is " + priceofPulses);
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
