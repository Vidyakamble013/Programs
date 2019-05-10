//-----------------------------------------------------------------------
// <copyright file="CardClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DeckofCard
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// CardClass as class
    /// </summary>
    public class CardClass
    {
        /// <summary>
        /// DistributedCard as function
        /// </summary>
        /// <returns>return string type</returns>
        public static string[,] DistributedCard()
        {
            string[,] cardForPlayer = new string[4, 9];
            try
            {
               string[,] actualCard = new string[4, 13];
                AddCard(actualCard);
                ShuffleCard(actualCard);
                
                for (int i = 0; i < cardForPlayer.GetLength(0); i++)
                {
                    for (int j = 0; j < cardForPlayer.GetLength(1); j++)
                    {
                        cardForPlayer[i, j] = actualCard[i, j];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cardForPlayer;
        }

        /// <summary>
        /// AddCard as function
        /// </summary>
        /// <param name="addCardArray">addCardArray as array</param>
        public static void AddCard(string[,] addCardArray)
        {
            try
            {
                string[] suitArray = { "Clubs", "Diamonds", "Hearts", "Spades" };
                string[] rankArray = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                for (int i = 0; i < addCardArray.GetLength(0); i++)
                {
                    for (int j = 0; j < addCardArray.GetLength(1); j++)
                    {
                        addCardArray[i, j] = suitArray[i] + " " + rankArray[j]; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ShuffleCard as function
        /// </summary>
        /// <param name="shuffleArray">shuffleArray as array</param>
        public static void ShuffleCard(string[,] shuffleArray)
        {
            //// Ramdom class use
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int random1 = random.Next(4);
                int random2 = random.Next(13);
                int random3 = random.Next(4);
                int random4 = random.Next(13);
                SwapFunction(shuffleArray, random1, random2, random3, random4);
            }
        }

        /// <summary>
        /// SwapFunction as function
        /// </summary>
        /// <param name="swapArray">swapArray as array</param>
        /// <param name="number1">number1 as parameter</param>
        /// <param name="number2">number2 as parameter</param>
        /// <param name="number3">number3 as parameter</param>
        /// <param name="number4">number4 as parameter</param>
        public static void SwapFunction(string[,] swapArray, int number1, int number2, int number3, int number4)
        {
            try
            {
                string temp = swapArray[number1, number2];
                swapArray[number1, number2] = swapArray[number3, number4];
                swapArray[number3, number4] = temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
