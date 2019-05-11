//-----------------------------------------------------------------------
// <copyright file="PrimeNumberProgram.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeNumberProgram class
    /// </summary>
   public class PrimeNumberProgram
    {
        /// <summary>
        /// PrimeNumber function
        /// </summary>
        public static void PrimeNumber()
        {
            try
            {
                int i = 0, j, count;
                int[,] primeNumberArray = new int[10, 50];
                for (i = 1; i < 10; i++)
                {
                    primeNumberArray[i, 0] = primeNumberArray[i - 1, 0] + 100;
                }

                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 0; j < 100; j++)
                    {
                        if (Utility.PrimeNumber(primeNumberArray[i, 0] + j))
                        {
                            count++;
                            primeNumberArray[i, count] = primeNumberArray[i, 0] + j;
                        }
                    }
                }

                Console.WriteLine("List of prime number");
                for (i = 0; i < 10; i++)
                {
                    //// Storing the prime numbers in the range
                    Console.WriteLine("Prime number between {0} - {1}:", "\n" + primeNumberArray[i, 0], primeNumberArray[i, 0] + 100);
                    
                    for (j = 1; primeNumberArray[i, j] != 0; j++)
                    {
                        Console.Write(primeNumberArray[i, j] + " ");
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
