//-----------------------------------------------------------------------
// <copyright file="DataProcessingTransactionQueueClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingQueue
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// DataProcessingTransactionQueueClass as class
    /// </summary>
    public class DataProcessingTransactionQueueClass
    {
        /// <summary>
        /// TransactionQueueDetail as function
        /// </summary>
        public void TransactionQueueDetail()
        {
            try
            {
                //// create instance of constant class
                ConstantClass constantClass = new ConstantClass();

                ////IList is non - generic collection object that can be individually access by index. 
                IList<CommercialDataProcessing.TransactionModelClass> transcationModels = new List<CommercialDataProcessing.TransactionModelClass>();
                DataProcessingLinkedWithQueue<CommercialDataProcessing.TransactionModelClass> withQueue = new DataProcessingLinkedWithQueue<CommercialDataProcessing.TransactionModelClass>();
                using (StreamReader streamReader = new StreamReader(constantClass.TranscationData))
                {
                    string jsonString = streamReader.ReadToEnd();

                    //// It returns JSON data in string format. In Deserialization.
                    transcationModels = JsonConvert.DeserializeObject<IList<CommercialDataProcessing.TransactionModelClass>>(jsonString);

                    //// access data into a TransactionModelClass class
                    foreach (var item in transcationModels)
                    {
                        withQueue.EnqueueOperation(item);
                    }

                    //// access data into a TransactionModelClass class
                    foreach (var item in transcationModels)
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
