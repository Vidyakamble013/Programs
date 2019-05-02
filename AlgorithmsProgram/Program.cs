//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;

    /// <summary>
    /// Program as class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main is method
        /// </summary>
        /// <param name="args">args as parameter</param>
        public static void Main(string[] args)
        {
            try
            {
                int choice;
                do
                {                    
                    Console.WriteLine("1. Anagram_String \n2. Prime_Number \n3. AnagramPalindrome_Number \n" +
                        "4. Sort_Function \n5. FindWord_Program \n6. InsertionSort_Program \n7. BubbleSortProgram" +
                        "\n8. MergeSortForString_Program \n9. DayofWeek_Program \n10. TemperaturConversion_Program" +
                        "\n11. MonthlyPayment_Program \n12. VendingMachine_Program\n13. SqrtRoot_Program " +
                        "\n14. DecimalToBinary_Program \n15. BinaryToDecimal_Program \n16. BinarySearchForInteger_Program" +
                        "\n17. BubbleSortForString_Program");
                    Console.WriteLine("Enter your choice ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AnagramString.CheckAnagram();
                            break;
                        case 2:
                            PrimeNumber.CheckPrimeNumber();
                            break;
                        case 3:
                            AnagramPalindromeNumber.AnagramPalindrome();
                            break;
                        case 4:
                            UtilityClass.SortMethod();
                            break;
                        case 5:
                            BinarySearchWordList.FindWord();
                            break;
                        case 6:
                            InsertionSortAlgorithm.InsertionSortForString();
                            break;
                        case 7:
                            BubbleSort.BubbleSortAlgorithm();
                            break;
                        case 8:
                            MergeSortForString.MergeSort();
                            break;
                        case 9:
                            PrintDayofWeek.PrintDay();
                            break;
                        case 10:
                            TemperatureConversion.TemperatureConversionFunction();
                            break;
                        case 11:
                            MonthlyPaymentSlip.MonthlyPayment();
                            break;
                        case 12:
                            VendingMachine.VendingMachineFunction();
                            break;
                        case 13:
                            SquareRootFunction.FindSquareRoot();
                            break;
                        case 14:
                            DecimalToBinary.DecimalToBinaryConversion();
                            break;
                        case 15:
                            BinaryToDecimal.BinaryToDecimalConversion();
                            break;
                        case 16:
                            BinarySearchForInteger.BinarySearchInteger();
                            break;
                        case 17:
                            BubbleSortString.SortStringUsingBubbleSort();
                            break;
                        default:
                            Console.WriteLine("Invali case");
                            break;
                    }
                }
                while (choice != 0);
                Console.WriteLine();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
