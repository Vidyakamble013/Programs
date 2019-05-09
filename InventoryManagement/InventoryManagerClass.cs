//-----------------------------------------------------------------------
// <copyright file="InventoryManagerClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    
    /// <summary>
    /// InventoryManagerClass class
    /// </summary>
    public class InventoryManagerClass
    {
        /// <summary>
        /// ManagerFunction function
        /// </summary>
        public void ManagerFunction()
        {
            try
            {                
                char character = 'n';
                do
                {
                    Console.WriteLine("1 for add Rice");
                    Console.WriteLine("2 for add Wheat");
                    Console.WriteLine("3 for add Pulses");
                    Console.WriteLine("4 for delete Rice");
                    Console.WriteLine("5 for delete Wheat");
                    Console.WriteLine("6 for delete Pulses");
                    Console.WriteLine("7 for update Rice");
                    Console.WriteLine("7 for update Wheat");
                    Console.WriteLine("7 for update Pulses");
                    Console.WriteLine("Select Any One Operation ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.AddToRice();
                            break;
                        case 2:
                            this.AddToWheat();
                            break;
                        case 3:
                            this.AddToPulses();
                            break;
                        case 4:
                            this.DeleteToRice();
                            break;
                        case 5:
                            this.DeleteToWheat();
                            break;
                        case 6:
                            this.DeleteToPulses();
                            break;
                        case 7:
                            this.UpdateToRice();
                            break;
                        case 8:
                            this.UpdateToWheat();
                            break;
                        case 9:
                            this.UpdateToPulses();
                            break;
                    }
                }
                while (character != 'n');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AddToRice as function
        /// </summary>
        public void AddToRice()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    var jsonObject = JObject.Parse(jsonString);
                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> rice = list.RiceInformation;
                    Console.WriteLine("Enter Rice Name ");
                    var nameofRice = Console.ReadLine();

                    //// IsStringCharacter function in Utility class
                    if (Utility.IsStringCharacter(nameofRice))
                    {
                        Console.WriteLine("Enter price of Rice");
                    }

                    double priceofRice = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly function in Utility class
                    if (Utility.IsNumberOnly(priceofRice))
                    {
                        Console.WriteLine("Enter weight of Rice");
                    }

                    double weightofRice = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly function in Utility class
                    if (Utility.IsNumberOnly(weightofRice))
                    {
                        InventoryModelClass inventoryModelClass = new InventoryModelClass()
                        {
                            Name = nameofRice,
                            Price = priceofRice,
                            Weight = weightofRice
                        };
                        rice.Add(inventoryModelClass);

                        //// access rice in rices json array
                        foreach (var item in rice)
                        {
                            Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        }

                        string outputString = JsonConvert.SerializeObject(list);
                        File.WriteAllText(constantClass.InventoryData, outputString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AddToWheat function
        /// </summary>
        public void AddToWheat()
        {
            try
            {
                //// create object of ConstantClass 
                ConstantClass constantClass = new ConstantClass();

                //// use StreamReader class
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    var jsonObject = JObject.Parse(jsonString);
                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> wheat = list.WheatInformation;
                    Console.WriteLine("Enter Wheat name");
                    var nameofWheat = Console.ReadLine();

                    //// IsStringCharacter function call in Utility class
                    if (Utility.IsStringCharacter(nameofWheat))
                    {
                        Console.WriteLine("Enter Prices");
                    }

                    double priceofWheat = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly function call in Utility class
                    if (Utility.IsNumberOnly(priceofWheat))
                    {
                        Console.WriteLine("Enter Weight of Wheat");
                    }

                    double weightofWheat = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly function call in Utility class
                    if (Utility.IsNumberOnly(weightofWheat))
                    {
                        InventoryModelClass inventoryModelClass = new InventoryModelClass()
                        {
                            Name = nameofWheat,
                            Price = priceofWheat,
                            Weight = weightofWheat
                        };

                        //// Add object of inventoryModelClass ito wheat
                        wheat.Add(inventoryModelClass);

                        //// call wheat json
                        foreach (var item in wheat)
                        {
                            Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        }

                        string outputString = JsonConvert.SerializeObject(list);
                        File.WriteAllText(constantClass.InventoryData, outputString);
                    }
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AddToPulses function
        /// </summary>
        public void AddToPulses()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    var jsonObject = JObject.Parse(jsonString);
                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> pulses = list.PulsesInformation;
                    Console.WriteLine("Enter Pulses name");
                    var nameofPulses = Console.ReadLine();

                    //// IsStringCharacter call function in Utility class
                    if (Utility.IsStringCharacter(nameofPulses))
                    {
                        Console.WriteLine("Enter price of pulses");
                    }

                    double priceofPulses = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly call function in Utility class
                    if (Utility.IsNumberOnly(priceofPulses))
                    {
                        Console.WriteLine("Enter weight of Pulses");
                    }

                    double weightofPulses = Convert.ToDouble(Console.ReadLine());

                    //// IsNumberOnly call function in Utility class
                    if (Utility.IsNumberOnly(weightofPulses))
                    {
                        InventoryModelClass inventoryModelClass = new InventoryModelClass()
                        {
                            Name = nameofPulses,
                            Price = priceofPulses,
                            Weight = weightofPulses
                        };

                        pulses.Add(inventoryModelClass);
                        //// add objcet in  to inventoryModelClass 
                        pulses.Add(inventoryModelClass);

                        //// access pulses json
                        foreach (var item in pulses)
                        {
                            Console.WriteLine(item.Name + " " + item.Price + " " + item.Weight);
                        }

                        string output = JsonConvert.SerializeObject(list);
                        File.WriteAllText(constantClass.InventoryData, output);
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ReadFile function
        /// </summary>
        /// <param name="path">path as field</param>
        /// <returns>returns boolean</returns>
        public string ReadFile(string path)
        {
            //// StreamReader class use to raed data
            using (StreamReader streamReader = File.OpenText(path))
                {
                    string jsonString = streamReader.ReadToEnd();
                    streamReader.Close();
                    return jsonString; 
                }
        }

        /// <summary>
        /// DeleteToRice as function
        /// </summary>
        public void DeleteToRice()
        {
            ConstantClass constantClass = new ConstantClass();
            var jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofRice = (JArray)jsonObject["RiceInformation"];
                Console.WriteLine(arrayofRice);
                Console.WriteLine("Enter name of rice to Delete in array");
                var nameofRice = Console.ReadLine();

                //// chect condition
                if (!nameofRice.Equals(null))
                {
                    var brandName = string.Empty;
                    var deleteRice = arrayofRice.FirstOrDefault(objName => objName["Name"].Value<string>().Equals(nameofRice));
                    arrayofRice.Remove(deleteRice);

                    string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                    Console.WriteLine(arrayofRice);
                }
                else
                {
                    Console.WriteLine("Rice name not found in array");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DeleteToWheat function
        /// </summary>
        public void DeleteToWheat()
        {
            ConstantClass constantClass = new ConstantClass();
            var jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofWheat = (JArray)jsonObject["WheatInformation"];
                Console.WriteLine(arrayofWheat);
                Console.WriteLine("Enter name of wheat to Delete in array");
                var nameofWheat = Console.ReadLine();
                if (!nameofWheat.Equals(null))
                {
                    var brandName = string.Empty;
                    var deleteWheatName = arrayofWheat.FirstOrDefault(objName => objName["Name"].Value<string>().Equals(nameofWheat));
                    string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                    Console.WriteLine(arrayofWheat);
                }
                else
                {
                    Console.WriteLine("Wheat name not found in json array");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DeleteToPulses as function
        /// </summary>
        public void DeleteToPulses()
        {
            ConstantClass constantClass = new ConstantClass();
            var jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofPulses = (JArray)jsonObject["PulsesInformation"];
                Console.WriteLine(arrayofPulses);
                Console.WriteLine("Delete pulses name ");
                var nameofPulses = Console.ReadLine();
                if (!nameofPulses.Equals(null))
                {
                    var brandName = string.Empty;
                    var deletenameofPulses = arrayofPulses.FirstOrDefault(objName => objName["Name"].Value<string>().Equals(nameofPulses));
                    string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                }
                else
                {
                    Console.WriteLine("Pulses name not found in json array");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateToRice function
        /// </summary>
        public void UpdateToRice()
        {
            ConstantClass constantClass = new ConstantClass();
            string jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofRice = (JArray)jsonObject["RiceInformation"];
                Console.WriteLine("Enter name of rice to update");
                var nameofRice = Console.ReadLine();
                if (!nameofRice.Equals(null))
                {
                    Console.WriteLine("Enter new prices");
                    var newPriceofRice = Convert.ToDouble(Console.ReadLine());
                    if (newPriceofRice > 0)
                    {
                        //// access json array
                        foreach (var brand in arrayofRice.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofRice)))
                        {
                            brand["Price"] = newPriceofRice != 0 ? newPriceofRice : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Price of rice is must positive");
                    }

                    Console.Write("Enter new weight : ");
                    var newWeightofRice = Convert.ToDouble(Console.ReadLine());
                    if (newWeightofRice > 0)
                    {
                        //// access json array
                        foreach (var brand in arrayofRice.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofRice)))
                        {
                            brand["Weight"] = newWeightofRice != 0 ? newWeightofRice : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("weight must be positive");
                    }

                    jsonObject["Rices"] = arrayofRice;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                }
                else
                {
                    Console.WriteLine("Invalid rice name");
                    this.UpdateToRice();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateToWheat as function
        /// </summary>
        public void UpdateToWheat()
        {
            ConstantClass constantClass = new ConstantClass();
            string jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofWheat = (JArray)jsonObject["WheatInformation"];
                Console.WriteLine("Enter name of wheat to update");
                var nameofWheat = Console.ReadLine();
                if (!nameofWheat.Equals(null))
                {
                    Console.WriteLine("Enter new prices");
                    var newPriceofWheat = Convert.ToDouble(Console.ReadLine());
                    if (newPriceofWheat > 0)
                    {
                        //// access wheat json array 
                        foreach (var brand in arrayofWheat.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofWheat)))
                        {
                            brand["Price"] = newPriceofWheat != 0 ? newPriceofWheat : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Price of wheat is must positive");
                    }

                    Console.Write("Enter new weight : ");
                    var newWeightofWheat = Convert.ToDouble(Console.ReadLine());
                    if (newWeightofWheat > 0)
                    {
                        //// access wheat json array objects
                        foreach (var brand in arrayofWheat.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofWheat)))
                        {
                            brand["Weight"] = newWeightofWheat != 0 ? newWeightofWheat : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("weight must be positive");
                    }

                    jsonObject["Wheat"] = arrayofWheat;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                }
                else
                {
                    Console.WriteLine("Invalid Wheat name");
                    this.UpdateToWheat();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateToPulses as function
        /// </summary>
        public void UpdateToPulses()
        {
            ConstantClass constantClass = new ConstantClass();
            string jsonString = File.ReadAllText(constantClass.InventoryData);
            try
            {
                var jsonObject = JObject.Parse(jsonString);
                JArray arrayofPulses = (JArray)jsonObject["PulsesInformation"];
                Console.WriteLine("Enter name of wheat to update");
                var nameofPulses = Console.ReadLine();
                if (!nameofPulses.Equals(null))
                {
                    Console.WriteLine("Enter new prices");
                    var newPriceofPulses = Convert.ToDouble(Console.ReadLine());
                    if (newPriceofPulses > 0)
                    {
                        ////  //// access wheat json array pulses
                        foreach (var brand in arrayofPulses.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofPulses)))
                        {
                            brand["Price"] = newPriceofPulses != 0 ? newPriceofPulses : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Price of wheat is must positive");
                    }

                    Console.Write("Enter new weight : ");
                    var newWeightofPulses = Convert.ToDouble(Console.ReadLine());
                    if (newWeightofPulses > 0)
                    {
                        ////  //// access pulses json array objects
                        foreach (var brand in arrayofPulses.Where(objNmae => objNmae["Name"].Value<string>().Equals(nameofPulses)))
                        {
                            brand["Weight"] = newWeightofPulses != 0 ? newWeightofPulses : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("weight must be positive");
                    }

                    jsonObject["Pulses"] = arrayofPulses;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(constantClass.InventoryData, output);
                }
                else
                {
                    Console.WriteLine("Invalid Pulses name");
                    this.UpdateToPulses();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ViewDetails as function
        /// </summary>
        public void ViewDetails()
        {           
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> rice = list.RiceInformation;
                    Console.WriteLine("Types of rices");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofRice = 0;

                    ////  //// access rice json array objects
                    foreach (var item in rice)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "  " + item.Weight);
                        priceofRice = priceofRice + (item.Price * item.Weight);                        
                    }

                    Console.WriteLine("Total price of rice is " + priceofRice);
                    Console.WriteLine();
                    IList<InventoryModelClass> wheat = list.WheatInformation;
                    Console.WriteLine("Types of wheat");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofWheat = 0;

                    ////  //// access wheat json array objects
                    foreach (var item in wheat)
                    {
                        Console.WriteLine(item.Name + "  " + item.Price + "  " + item.Weight);
                        priceofWheat = priceofWheat + (item.Price * item.Weight);
                    }

                    Console.WriteLine("Total price of wheat is " + priceofWheat);
                    Console.WriteLine();
                    IList<InventoryModelClass> pulses = list.PulsesInformation;
                    Console.WriteLine("Types of wheat");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceofPulses = 0;

                    //// access pulses json array objects
                    foreach (var item in pulses)
                    {
                        Console.WriteLine(item.Name + "  " + item.Price + "  " + item.Weight);
                        priceofPulses = priceofPulses + (item.Price * item.Weight);
                    }

                    Console.WriteLine("Toatal price of pulses" + priceofPulses);
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
