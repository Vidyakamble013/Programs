//-----------------------------------------------------------------------
// <copyright file="OrderedInput.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.OrderedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// OrderedInput as class
    /// </summary>
    public class OrderedInput
    {
        /// <summary>
        /// OrderedLinkedList as method
        /// </summary>
        public static void OrderedLinkedList()
        {
            try
            {
                string path = string.Empty;
                SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

                string dataFromFile = System.IO.File.ReadAllText("C:/Users/admin/source/repos/DataStructureProgram/DataStructureProgram/OrderedList.txt");
                Console.WriteLine(dataFromFile);

                string[] arraysplit = dataFromFile.Split(' ');

                foreach (string word in arraysplit)
                {
                    if (word.Trim() != string.Empty)
                    {
                        singlyLinkedList.Add(Convert.ToInt32(word.Trim()));
                    }
                }

                Console.WriteLine("Enter Element for search & remove in the list");
                string number = Console.ReadLine();
                if (Utility.IsNumber(number) == false)
                {
                    Console.WriteLine("Enter only NUmber");
                    Console.Read();
                }

                int searchnumber = Convert.ToInt32(number);
                Console.WriteLine("Entered NUmber" + searchnumber);
                
                if (singlyLinkedList.Search(number))
                {
                    Console.WriteLine("remove number from the list" + "\t" + number);
                    singlyLinkedList.Delete(singlyLinkedList);
                }             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
