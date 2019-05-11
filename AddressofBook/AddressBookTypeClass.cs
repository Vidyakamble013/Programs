//-----------------------------------------------------------------------
// <copyright file="AddressBookTypeClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.AddressofBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// AddressBookTypeClass as class
    /// </summary>
    public class AddressBookTypeClass
    {
        /// <summary>
        /// ReadFromFile as function
        /// </summary>
        /// <param name="path">path as parameter</param>
        /// <returns>return string</returns>
        public static string ReadFromFile(string path)
        {
            //// read the path from file
            using (StreamReader streamReader = new StreamReader(path))
            {
                //// rread file at end
                string jsonString = streamReader.ReadToEnd();
                streamReader.Close();
                return jsonString;
            }
        }

        /// <summary>
        /// UpdateNumber as function
        /// </summary>
        /// <param name="items">item as parameter</param>
        public static void UpdateNumber(AddressBookModelClass items)
        {
            try
            {
                Console.WriteLine("Enter New Number");
                string newMobileNumber = Console.ReadLine();
                //// Regex class used to check the pattern of string and number as validation purpose
                if (Regex.IsMatch(newMobileNumber, @"[0-9]{10}") && newMobileNumber.Length == 10)
                {
                    items.Phonenumber = newMobileNumber;
                }
                else
                {
                    Console.WriteLine("Invalid Mobile Number");
                }           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateAddress as function
        /// </summary>
        /// <param name="items">items as parameter</param>
        public static void UpdateAddress(AddressBookModelClass items)
        {
            try
            {
                Console.WriteLine("Enter new address");
                items.Address = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateState as function
        /// </summary>
        /// <param name="items">items as parameter</param>
        public static void UpdateState(AddressBookModelClass items)
        {
            try
            {
                Console.WriteLine("Enter new State");
                string newState = Console.ReadLine();
                //// take new state & compare to previous state
                if (Regex.IsMatch(newState, @"[A-Za-z]"))
                {
                    items.State = newState;
                }
                else
                {
                    Console.WriteLine("Invalid State");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateCity as function
        /// </summary>
        /// <param name="items">items as parameter</param>
        public static void UpdateCity(AddressBookModelClass items)
        {
            try
            {
                Console.WriteLine("Enter new City");
                string newCity = Console.ReadLine();
                //// take new city & compare to previous city
                if (Regex.IsMatch(newCity, "@[A-Za-z]"))
                {
                    items.City = newCity;
                }
                else
                {
                    Console.WriteLine("Please enter valid City");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AddNewUser as function
        /// </summary>
        public void AddNewUser()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                IList<AddressBookModelClass> addressBookModelClasses = new List<AddressBookModelClass>();
                Console.WriteLine("Enter first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Zip code");
                string zip = Console.ReadLine();
                Console.WriteLine("Enter 10 digiy Mobile Number");
                string mobile = Console.ReadLine();

                //// regex class use to check string pattern and number pattern
                if (Regex.IsMatch(firstname, @"[A-Za-z]") && Regex.IsMatch(lastname, @"[A-Za-z]") && Regex.IsMatch(address, @"[A-Za-z]") && Regex.IsMatch(city, @"[A-Za-z]") && Regex.IsMatch(state, @"[A-Za-z]") && Regex.IsMatch(zip, @"[0-9]") && Regex.IsMatch(mobile, @"[0-9]{10}"))
                {
                    //// create object of class and send this object to IList interface 
                    AddressBookModelClass addressBookModel = new AddressBookModelClass()
                    {
                        Firstname = firstname,
                        Lastname = lastname,
                        Address = address,
                        City = city,
                        State = state,
                        Zip = zip,
                        Phonenumber = mobile
                    };
                    string userFile = ReadFromFile(constantClass.AddressBook);

                    //// It returns JSON data in string format. In Deserialization.
                    addressBookModelClasses = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(userFile);
                    //// Add method used to Add the class object to IList interface
                    addressBookModelClasses.Add(addressBookModel);
                    //// creates an instance of BlogSiteclass and assigns values to its properties.
                    var convertTojson = JsonConvert.SerializeObject(addressBookModelClasses);
                    File.WriteAllText(constantClass.AddressBook, convertTojson);
                    Console.WriteLine("Add Successfully....");
                    this.PrintAddressBookDetails();
                }
                else
                {
                    Console.WriteLine("Invalid User Details");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UpdateFunction as function
        /// </summary>
        public void UpdateFunction()
        {
            try
            {
                this.PrintAddressBookDetails();
                Console.WriteLine("Enter your mobile number to update");
                string phonenumbre = Console.ReadLine();
                ConstantClass constantClass = new ConstantClass();
                IList<AddressBookModelClass> addressBookModels = new List<AddressBookModelClass>();
                string jsonString = ReadFromFile(constantClass.AddressBook);

                //// It returns JSON data in string format. In Deserialization
                addressBookModels = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(jsonString);
                bool number = false;
                //// fetch data in a addressBookModels Interface
                foreach (var item in addressBookModels)
                {
                    if (item.Phonenumber == phonenumbre)
                    {
                        Console.WriteLine(item.Firstname + "\t" + item.Lastname + "\t" + item.Address + "\t" + item.City + "\t" + item.State + "\t" + item.Zip + "\t" + item.Phonenumber);
                        number = true;

                        string userchoice = null;
                        do
                        {
                           Console.WriteLine("Enter your choice to update to details");
                           Console.WriteLine("1. update mobile number");
                           Console.WriteLine("2. update address");
                           Console.WriteLine("3. update city");
                           Console.WriteLine("4. update state");
                           int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    UpdateNumber(item);
                                    break;
                                case 2:
                                    UpdateAddress(item);
                                    break;
                                case 3:
                                    UpdateCity(item);
                                    break;
                                case 4:
                                    UpdateState(item);
                                    break;
                            }

                            Console.WriteLine("If you want to continue the operation then please enter yes");
                            userchoice = Console.ReadLine();
                        }
                        while (userchoice.Equals("yes"));
                        //// creates an instance of BlogSiteclass and assigns values to its properties.
                        var convertTojson = JsonConvert.SerializeObject(addressBookModels);
                        File.WriteAllText(constantClass.AddressBook, convertTojson);
                        Console.WriteLine("Update details Successfully.......");
                    }
                }

                if (number == true)
                {
                    Console.WriteLine("Mobile number must be proper format");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// PrintAddressBookDetails as function
        /// </summary>
        public void PrintAddressBookDetails()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                IList<AddressBookModelClass> addressBookModels = new List<AddressBookModelClass>();
                using (StreamReader streamReader = new StreamReader(constantClass.AddressBook))
                {
                    string jsonString = streamReader.ReadToEnd();
                    streamReader.Close();
                    //// It returns JSON data in string format. In Deserialization
                    addressBookModels = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(jsonString);
                    foreach (var item in addressBookModels)
                    {
                        Console.WriteLine(item.Firstname + "\t" + item.Lastname + "\t" + item.Address + "\t" + item.City + "\t" + item.State + "\t" + item.Zip + "\t" + item.Phonenumber);
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DeleteUserData as function
        /// </summary>
        public void DeleteUserData()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                Console.WriteLine("Enter mobile number to delete");
                string phonenumber = Console.ReadLine();

                IList<AddressBookModelClass> addressBookModelClasses = new List<AddressBookModelClass>();
                string jsonString = ReadFromFile(constantClass.AddressBook);

                //// It returns JSON data in string format. In Deserialization
                addressBookModelClasses = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(jsonString);
                bool number = false;
                foreach (var item in addressBookModelClasses)
                {
                    if (item.Phonenumber == phonenumber)
                    {
                        Console.WriteLine(item.Firstname + "\t" + item.Lastname + "\t" + item.Address + "\t" + item.City + "\t" + item.State + "\t" + item.Zip + "\t" + item.Phonenumber);
                        number = false;
                    }
                }

                if (number == true)
                {
                    Console.WriteLine("mobile number not found in json array");
                }

                var jsonRemove = addressBookModelClasses.Single(d => d.Phonenumber == phonenumber);
                addressBookModelClasses.Remove(jsonRemove);

                //// creates an instance of BlogSiteclass and assigns values to its properties.
                var convertTojson = JsonConvert.SerializeObject(addressBookModelClasses);
                File.WriteAllText(constantClass.AddressBook, convertTojson);
                Console.WriteLine("Delete successfully........");
                this.PrintAddressBookDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortByOrder as function
        /// </summary>
        public void SortByOrder()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                string jsonString = ReadFromFile(constantClass.AddressBook);
                IList<AddressBookModelClass> addressBookModelClasses = new List<AddressBookModelClass>();

                //// It returns JSON data in string format. In Deserialization
                addressBookModelClasses = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(jsonString);

                //// Sorts the firstname in the collection based on specified fields in ascending or decending order.
                var sortFirstName = addressBookModelClasses.OrderBy(o => o.Firstname);

                //// creates an instance of BlogSiteclass and assigns values to its properties.
                var jsonSortBy = JsonConvert.SerializeObject(sortFirstName);
                File.WriteAllText(constantClass.AddressBook, jsonSortBy);
                Console.WriteLine("Sort First name by successfully.....");
                this.PrintAddressBookDetails(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortToZipCode as function
        /// </summary>
        public void SortToZipCode()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                string jsonString = ReadFromFile(constantClass.AddressBook);
                IList<AddressBookModelClass> addressBookModelClasses = new List<AddressBookModelClass>();

                //// It returns JSON data in string format. In Deserialization
                addressBookModelClasses = JsonConvert.DeserializeObject<List<AddressBookModelClass>>(jsonString);

                //// Sorts the zip code in the collection based on specified fields in ascending or decending order.
                var zipBySort = addressBookModelClasses.OrderBy(z => z.Zip);

                //// creates an instance of BlogSiteclass and assigns values to its properties.
                var jsonSortBy = JsonConvert.SerializeObject(zipBySort);
                File.WriteAllText(constantClass.AddressBook, jsonSortBy);
                Console.WriteLine("Sort Zip Code successfully...");
                this.PrintAddressBookDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}