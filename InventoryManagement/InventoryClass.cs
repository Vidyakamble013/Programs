using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedProgram1.InventoryManagement
{
   public class InventoryClass
    {
        public void InventryData()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();

                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();

                    JSONInventory.InventoryDisplayInfo list = JsonConvert.DeserializeObject<JSONInventory.InventoryDisplayInfo>(jsonString);

                    IList<JSONInventory.JSONInventoryModelClass> rice = list.Rice;
                    Console.WriteLine("Different Types of Rices");
                    Console.WriteLine("Name" + " " + "Price" + " " + "Weight");
                    double priceofRice = 0;

                    foreach(var item in rice)
                    {
                        Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        priceofRice = priceofRice + (item.Price * item.Weight);                      
                    }
                    Console.WriteLine(priceofRice);
                    Console.WriteLine();

                    IList<JSONInventory.JSONInventoryModelClass> wheat = list.Wheat;
                    Console.WriteLine("Different types of Wheats");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofWheat = 0;

                    foreach(var item in wheat)
                    {
                        Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        priceofWheat = priceofWheat + (item.Price * item.Weight);
                    }

                    Console.WriteLine(priceofWheat);
                    Console.WriteLine();

                    IList<JSONInventory.JSONInventoryModelClass> pulses = list.Pulses;
                    Console.WriteLine("Types of Pulses");
                    Console.WriteLine("Name" + "  " + "Price" + "  " + "weight");
                    double priceodPulses = 0;

                    foreach(var item in pulses)
                    {
                        Console.WriteLine(item.Name + "  " + item.Price + "  " + item.Weight );
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
