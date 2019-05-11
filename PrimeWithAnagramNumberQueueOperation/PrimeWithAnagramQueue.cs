//-----------------------------------------------------------------------
// <copyright file="PrimeWithAnagramQueue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.PrimeWithAnagramNumberQueueOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrimeWithAnagramQueue class
    /// </summary>
    public class PrimeWithAnagramQueue
    {
        /// <summary>
        /// PrimeWithAnagramNumber function
        /// </summary>
        public static void PrimeWithAnagramNumber()
        {
            try
            {
                int[] numberArray = new int[170];
                int j = 0;
                for (int i = 2; i < 1000; i++)
                {
                    if (Utility.PrimeNumber(i))
                    {
                        numberArray[j] = i;
                        j++;
                    }
                }

                foreach (int number in numberArray)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
                LinkedListWithQueue linkedListWithQueue = new LinkedListWithQueue();
                Console.WriteLine("This prime are also Anagram Number");
                for (int num = numberArray.Length; num > 0; num--)
                {
                    for (int count = num + 1; count < numberArray.Length; count++)
                    {
                        string variable1 = numberArray[num].ToString();
                        string variable2 = numberArray[count].ToString();

                        //// call AnagramNumber function in Utility class
                        if (Utility.AnagramNumber(variable1, variable2))
                        {
                            linkedListWithQueue.EnqueueOperation(variable1);

                            linkedListWithQueue.EnqueueOperation(variable2);
                            Console.WriteLine();
                        }
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
