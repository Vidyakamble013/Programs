//-----------------------------------------------------------------------
// <copyright file="TransactionClassWithStack.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// TransactionClassWithStack as class
    /// </summary>
    public class TransactionClassWithStack
    {
        /// <summary>
        /// TransactionStackFunction as function
        /// </summary>
        public void TransactionStackFunction()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                IList<CommercialDataProcessing.TransactionModelClass> transactionModels = new List<CommercialDataProcessing.TransactionModelClass>();
               Stack<CommercialDataProcessing.TransactionModelClass> transactions = new Stack<CommercialDataProcessing.TransactionModelClass>();
                using (StreamReader streamReader = new StreamReader(constantClass.TranscationData))
                {
                    string jsonString = streamReader.ReadToEnd();

                    //// It returns JSON data in string format. In Deserialization.
                    transactionModels = JsonConvert.DeserializeObject<IList<CommercialDataProcessing.TransactionModelClass>>(jsonString);
                    streamReader.Close();
                    foreach (var item in transactionModels)
                    {
                        transactions.Push(item);
                    }
                        
                    foreach (var item in transactions)
                    {
                        Console.WriteLine(item.CustomerName + "\t" + item.StockName + "\t" + item.NoOfShares + "\t" + item.Amount + "\t" + item.Time);
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
