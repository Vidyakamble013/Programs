using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ObjectOrientedProgram1.InventoryManagement
{
   public class InventoryManagerClass
    {
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

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.AddToRice();
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

        public void AddToRice()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    String jsonString = streamReader.ReadToEnd();

                    var jsonObject = JObject.Parse(jsonString);

                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> rice = list.Rices;
                    Console.WriteLine("Enter Rice Name ");
                    var nameofRice = Console.ReadLine();
                    if (Utility.IsStringCharacter(nameofRice))
                    {
                        Console.WriteLine("Enter price of Rice");
                    }

                    double priceofRice = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumberOnly(priceofRice))
                    {
                        Console.WriteLine("Enter weight of Rice");
                    }

                    double weightofRice = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumberOnly(weightofRice))
                    {
                        InventoryModelClass inventoryModelClass = new InventoryModelClass()
                        {
                            Name = nameofRice,
                            Price = priceofRice,
                            Weight = weightofRice
                        };
                        rice.Add(inventoryModelClass);

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

        public void AddToWheat()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                using (StreamReader streamReader = File.OpenText(constantClass.InventoryData))
                {
                    string jsonString = streamReader.ReadToEnd();
                    var jsonObject = JObject.Parse(jsonString);

                    InventoryModelClass.InventoryInfo list = JsonConvert.DeserializeObject<InventoryModelClass.InventoryInfo>(jsonString);
                    IList<InventoryModelClass> wheat = list.Wheat;

                    Console.WriteLine("Enter Wheat name");
                    var nameofWheat = Console.ReadLine();
                    if (Utility.IsStringCharacter(nameofWheat))
                    {
                        Console.WriteLine("Enter Prices");
                    }

                    double priceofWheat = Convert.ToDouble(Console.ReadLine());
                    if(Utility.IsNumberOnly(priceofWheat))
                    {
                        Console.WriteLine("Enter Weight of Wheat");
                    }

                    double weightofWheat = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumberOnly(weightofWheat))
                    {
                        InventoryModelClass inventoryModelClass = new InventoryModelClass()
                        {
                            Name = nameofWheat,
                            Price = priceofWheat,
                            Weight = weightofWheat
                        };
                        wheat.Add(inventoryModelClass);
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
        
    }
}
