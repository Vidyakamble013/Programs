//-----------------------------------------------------------------------
// <copyright file="ICustomer.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// ICustomer is interface
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Adds the customer. 
        /// </summary>
        void AddCustomer();

        /// <summary>
        /// Gets all customer.
        /// </summary>
        /// <returns>returns the customer objects</returns>
        IList<CustomerModelClass> GetAllCustomer();
    }

    /// <summary>
    /// this class is used for developing the interface methods
    /// </summary>
    /// <seealso cref="OopsPrograms.ICustomer" />
    public class CustomerData : ICustomer
    {
        /// <summary>
        /// The constant object is created
        /// </summary>
        private ConstantClass constant = new ConstantClass();

        /// <summary>   
        /// Adds the customer.
        /// </summary>
        /// <exception cref="Exception">file not found exception</exception>
        public void AddCustomer()
        {
            try
            {
                //// Takes input for customer id
                Console.WriteLine("enter id");
                int id = Convert.ToInt32(Console.ReadLine());

                //// Takes input for customer name
                Console.WriteLine("enter name");
                string name = Console.ReadLine();

                //// Takes input for customer valuation
                Console.WriteLine("enter valuation");
                int valuation = Convert.ToInt32(Console.ReadLine());

                ///// Checks for valuation greater than 0
                if (valuation > 0)
                {
                    ////creating the object of the customer model class
                    CustomerModelClass customerModel = new CustomerModelClass();
                    {
                        customerModel.Id = id;
                        customerModel.Name = name;
                        customerModel.Valuation = valuation;
                    }

                    ////IList is non - generic collection object that can be individually access by index. 
                    IList<CustomerModelClass> customers = new List<CustomerModelClass>();
                    ////this is used for reading the file
                    using (StreamReader stream = new StreamReader(this.constant.CustomerData))
                    {
                        ////reading the hole content in the file
                        string json = stream.ReadToEnd();
                        ////closing the file
                        stream.Close();
                        ////Deserialize the customet model file
                        customers = JsonConvert.DeserializeObject<List<CustomerModelClass>>(json);
                        customers.Add(customerModel);
                        ////Serialize the customer model object
                        var convertedJson = JsonConvert.SerializeObject(customers);
                        ////writing all the text in to a file
                        File.WriteAllText(this.constant.CustomerData, convertedJson);

                        Console.WriteLine("new customer added");
                    }
                }
                else
                {
                    Console.WriteLine("enter valid data");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets all customer.
        /// </summary>
        /// <returns>returns the customer objects</returns>
        /// <exception cref="Exception">No customers available</exception>
        public IList<CustomerModelClass> GetAllCustomer()
        {
            ////IList is non - generic collection object that can be individually access by index. 
            IList<CustomerModelClass> customers = new List<CustomerModelClass>();
            ////this is used for reading the file
            try
            {
                using (StreamReader stream = new StreamReader(this.constant.CustomerData))
                {
                    string json = stream.ReadToEnd();
                    stream.Close();
                    ////Deserialize the customet model file
                    customers = JsonConvert.DeserializeObject<IList<CustomerModelClass>>(json);

                    //// Checks for file is null
                    if (customers == null)
                    {
                        throw new Exception("No customers available");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return customers;
        }
    }
}
