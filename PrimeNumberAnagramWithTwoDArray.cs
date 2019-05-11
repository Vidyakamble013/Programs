//-----------------------------------------------------------------------
// <copyright file="PrimeNumberAnagramWithTwoDArray.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeNumberAnagramWithTwoDArray class
    /// </summary>
    public class PrimeNumberAnagramWithTwoDArray
    {
        /// <summary>
        /// FindAnagramIntoPrimeNumberArray function
        /// </summary>
        public static void FindAnagramIntoPrimeNumberArray()
        {
            try
            {
                Utility utility = new Utility();
                int i = 0, j, count, number;
                int[,] primeNumberArray = new int[10, 50];
                int[,] anagramNumberArray = new int[10, 50];
                for (i = 1; i < 10; i++)
                {
                    primeNumberArray[i, 0] = primeNumberArray[i - 1, 0] + 100;
                    anagramNumberArray[i, 0] = anagramNumberArray[i - 1, 0] + 100;
                }

                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 1; j < 100; j++)
                    {
                        if (Utility.PrimeNumber(primeNumberArray[i, 0] + j))
                        {
                            count++;
                            primeNumberArray[i, count] = primeNumberArray[i, 0] + j;
                        }
                    }
                }

                Console.WriteLine("The prime numbers are: ");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("\n Prime Number  {0} - {1}:", primeNumberArray[i, 0], primeNumberArray[i, 0] + 100);
                    for (j = 1; primeNumberArray[i, j] != 0; j++)
                    {
                        Console.Write(primeNumberArray[i, j] + " ");
                    }

                    Console.WriteLine();
                }

                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 1; primeNumberArray[i, j] != 0; j++)
                    {
                        for (number = j + 1; primeNumberArray[i, number] != 0; number++)
                        {
                            if (Utility.AnagramNumber(Convert.ToString(primeNumberArray[i, j]), Convert.ToString(primeNumberArray[i, number])))
                            {
                                count++;
                                anagramNumberArray[i, count++] = primeNumberArray[i, j];
                                anagramNumberArray[i, count] = primeNumberArray[i, number];
                            }
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("This Anagram number find into the Prime number array");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("\n Anagram Number  {0} - {1}", anagramNumberArray[i, 0], anagramNumberArray[i, 0] + 100);
                    for (j = 1; anagramNumberArray[i, j] != 0; j++)
                    {
                        Console.Write(anagramNumberArray[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
