//-----------------------------------------------------------------------
// <copyright file="DeckClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DeckofCard
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DeckClass as class
    /// </summary>
    public class DeckClass
    {
        /// <summary>
        /// DeckFunction as function
        /// </summary>
        public static void DeckFunction()
        {
            try
            {
                string[,] cardForPlayer = CardClass.DistributedCard();
                Console.WriteLine("Player1 \t Player2 \t Player3 \t Player4");
                Console.WriteLine();
                int count1 = 0;
                int count2 = 0;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(cardForPlayer[count1, count2] + " \t ");
                        count2++;
                        while (count2 == 9)
                        {
                            count2 = 0;
                            count1++;
                        }
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
