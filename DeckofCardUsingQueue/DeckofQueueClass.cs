//-----------------------------------------------------------------------
// <copyright file="DeckOfQueueClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DeckofCardUsingQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DeckOfQueueClass as class
    /// </summary>
    public class DeckOfQueueClass
    {
        /// <summary>
        /// QueueCardFunction as function
        /// </summary>
        public static void QueueCardFunction()
        {
            try
            {
                string[,] cardforPlayer = DeckofCard.CardClass.DistributedCard();
                Queue<Queue<string>> shuffleCard = SortCardFunction(cardforPlayer);

                string[] nameofPlayer = { "Player1", "Player2", "Player3", "Player4" };
                int index = 0;
                while (shuffleCard.Count != 0)
                {
                    Queue<string> temp = shuffleCard.Dequeue();
                    Console.WriteLine(nameofPlayer[index]);

                    while (temp.Count != 0)
                    {
                        Console.Write(temp.Dequeue() + "\t");
                    }  
                    
                     Console.WriteLine();
                     index++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortCardFunction as function
        /// </summary>
        /// <param name="cardForPlayer">cardForPlayer as parameter</param>
        /// <returns>return collection type</returns>
        public static Queue<Queue<string>> SortCardFunction(string[,] cardForPlayer)
        {
            //// used generic collection 
            Queue<Queue<string>> sortCard = new Queue<Queue<string>>();
            {
                try
                {
                    string[] rankArray = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
                    int[] lengthArray = new int[9];
                    int indexofArray = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            string[] tempArray = (cardForPlayer[i, j] + " ").Split(' ');
                            for (int range = 0; range < 13; range++)
                            {
                                if (tempArray[1].Equals(rankArray[range]))
                                {
                                    lengthArray[indexofArray] = range;
                                    indexofArray++;
                                }
                            }
                        }

                        Console.WriteLine();
                        indexofArray = 0;

                        for (int card1 = 0; card1 < lengthArray.Length - 1; card1++)
                        {
                            for (int card2 = card1 + 1; card2 < lengthArray.Length - 1; card2++)
                            {
                                if (lengthArray[card1] > lengthArray[card2])
                                {
                                    int temp = lengthArray[card1];
                                    lengthArray[card1] = lengthArray[card2];
                                    lengthArray[card2] = temp;

                                    //// swap the two array 
                                    string tempeory = cardForPlayer[i, card1];
                                    cardForPlayer[i, card1] = cardForPlayer[i, card2];
                                    cardForPlayer[i, card2] = tempeory;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < cardForPlayer.GetLength(0); i++)
                    {
                        Queue<string> temp = new Queue<string>();
                        for (int j = 0; j < cardForPlayer.GetLength(1); j++)
                        {
                            temp.Enqueue(cardForPlayer[i, j]);
                            sortCard.Enqueue(temp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return sortCard;
            }
        }
    }
}
