//-----------------------------------------------------------------------
// <copyright file="BinarySearchWordList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BinarySearchWord_List as class
    /// </summary>
    public class BinarySearchWordList
    {
        /// <summary>
        /// FindWord as function
        /// </summary>
        public static void FindWord()
        {
            string path = "C:/Users/admin/source/repos/AlgorithmsProgram/AlgorithmsProgram/wordList.txt";
            Console.WriteLine(path);
            Console.WriteLine("Enter search word");
            string word = Convert.ToString(Console.ReadLine());
            Utility.BinarySearchFromWordList(path, word);
        }
    }
}
