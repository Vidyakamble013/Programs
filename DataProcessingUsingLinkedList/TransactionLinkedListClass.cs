//-----------------------------------------------------------------------
// <copyright file="TransactionLinkedListClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// TransactionLinkedListClass as class
    /// </summary>
    public class TransactionLinkedListClass
    {
        /// <summary>
        /// TransactionDetailsFunction as function
        /// </summary>
        public void TransactionDetailsFunction()
        {
            try
            {
                ConstantClass constantClass = new ConstantClass();
                IList<CommercialDataProcessing.TransactionModelClass> transcationClasses = new List<CommercialDataProcessing.TransactionModelClass>();
                LinkedListClass<CommercialDataProcessing.TransactionModelClass> linkedListClass = new LinkedListClass<CommercialDataProcessing.TransactionModelClass>();
                using (StreamReader streamReader = new StreamReader(constantClass.TranscationData)) 
                {
                    string jsonString = streamReader.ReadToEnd();

                    //// It returns JSON data in string format. In Deserialization.
                    transcationClasses = JsonConvert.DeserializeObject<IList<CommercialDataProcessing.TransactionModelClass>>(jsonString);
                    streamReader.Close();   
                }

                foreach (var item in transcationClasses)
                {
                    linkedListClass.AddCompanyStock(item);
                }

                foreach (var item in transcationClasses)
                {
                    Console.WriteLine(item.CustomerName + "\t" + item.StockName + "\t" + item.NoOfShares + "\t" + item.Amount + "\t" + item.Time);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
