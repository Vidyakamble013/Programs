//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1
{
    using System;

    /// <summary>
    ///  Program class
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">args as field</param>
       public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. JSONInventory_Program");
                Console.WriteLine("2. InventoryManagement_Program");
                Console.WriteLine("3. RegexExpression_Program");
                Console.WriteLine("4. StockReport_Program");
                Console.WriteLine("5. CommercialDataProcessing_Program");
                Console.WriteLine("6. CommercialDataProcessingUsingLinkedList_Program");
                Console.WriteLine("7. CommercialDataProcessingUsingQueue_Program");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        JSONInventory.DisplayClass.InputFunction();
                        break;
                    case 2:
                        InventoryManagement.InventoryManagerClass inventory = new InventoryManagement.InventoryManagerClass();
                        inventory.ManagerFunction();
                        break;
                    case 3:
                        RegularExpression.RegexExpressionClass expressionClass = new RegularExpression.RegexExpressionClass();
                        expressionClass.ReadInfo();
                        break;
                    case 4:
                        StockReoprt.StockReportClass.StockData();
                        break;
                    case 5:
                        CommercialDataProcessing.DataProcessingMainClass.DataProcesssing();
                        break;
                    case 6:
                        DataProcessingUsingLinkedList.TransactionLinkedListClass transcationLinkedList = new DataProcessingUsingLinkedList.TransactionLinkedListClass();
                        transcationLinkedList.TransactionDetailsFunction();
                        break;
                    case 7:
                        DataProcessingUsingQueue.DataProcessingTransactionQueueClass dataProcessingTranscationQueue = new DataProcessingUsingQueue.DataProcessingTransactionQueueClass();
                        dataProcessingTranscationQueue.TransactionQueueDetail();
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
