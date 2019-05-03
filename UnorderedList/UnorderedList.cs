//-----------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.UnorderedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using static DataStructureProgram.UnorderedList.SinglyUnorderedLinkedList;

    /// <summary>
    /// UnorderedList as class
    /// </summary>
    public static class UnorderedList
    {
        /// <summary>
        /// Unordered as function
        /// </summary>
        public static void Unordred()
        {
            try
            {
                SinglyLinkedList singlelinklist = new SinglyLinkedList();

                string text = System.IO.File.ReadAllText("C:/Users/admin/source/repos/DataStructureProgram/DataStructureProgram/UnorderedList.txt");
                string[] string1 = text.Split(' ');
                    
                foreach (string str in string1)

                {
                    singlelinklist.Add(str);
                }

                Console.WriteLine("Linked List element");
                singlelinklist.Print();

                Console.WriteLine("Enter Search word from the list");
                string element = Console.ReadLine();

                Console.WriteLine("After adding & removing the element linked list");

                if (singlelinklist.Search(element))
                {
                    Console.WriteLine("remove element from linked list" + "\t" + element);
                    singlelinklist.Delete(singlelinklist, element);
                }
                else
                {
                    singlelinklist.Add(element);
                    Console.WriteLine("add new element in linked list" + "\t" + element);
                }

                singlelinklist.Print();
                singlelinklist.WriteFile("C:/Users/admin/sourc/repos/DataStructureProgram/DataStructureProgram/UnorderedList.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
