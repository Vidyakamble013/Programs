//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Here is main class of Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {    
            try
            {
                int choice;
                do
                {                    
                    Console.WriteLine(" 0. Exit\n 1. ReplaceString_Program \n 2.HeadsTails_program" +
                        " \n 3. Leapyear_Program\n 4. CalculatePower_Program \n 5. HarmonicProgram_Program \n " +
                        "6. PrimeFactors_Program \n 7. Gambler_Program \n 8. Triple_Element_Addition \n 9. TwoDimensionalArray_Program " +
                        "\n 10. TripleElementAddition_Program \n 11. Distance_Program \n 12. PermutationString_Program \n 13. CalculateElapsedTime_Program" +
                        " \n 14. QuadraticFunction_Program \n 15. QuadraticFunction_Program \n 16. WindChill_Program");
                    Console.WriteLine("Enter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        
                        case 1:
                            ReplaceString.Replaceletter();
                           
                            break;
                        case 2:
                            HeadsTails.Tosscoin();
                           
                            break;
                        case 3:
                            Leapyear.CheckleapYear();
                            
                            break;
                        case 4:
                            CalculatePower.PowerFunction();
                            break;
                        case 5:
                            HarmonicProgram.Hormonic();
                            break;
                        case 6:
                            PrimeFactors.Primefactor();
                            
                            break;
                        case 7:
                            Gambler.GamblerGame();
                            
                            break;
                        case 8:
                            
                            break;
                        case 9:
                            TwoDimensionalArray.InputArray();
                           
                            break;
                        case 10:
                            TripleElementAddition.Triple();
                            break;
                        case 11:
                            Distance.CalculateDistance();
                           
                            break;
                        case 12:
                            PermutationString.Permutation();
                            break;
                        case 13:
                            CalculateElapsedTime.ElapsedTimeDifferent();                         
                            break;
                        case 14:
                            
                            break;

                        case 15:
                            QuadraticFunction.QuadraticMethods();
                            break;
                        case 16:
                            WindChill.CalculateWindChill();
                            break;
                        default:
                            Console.WriteLine("Case not valid plese try again");
                            break;
                    }   
                }
                while (choice != 0);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
