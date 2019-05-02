//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    
    /// <summary>
    /// Utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Harmonic  the number.
        /// </summary>
        /// <param name="number">number as parameter</param>
       public void Harmonic(float number)
        {
            float harmonic = 1;
            try
            {
                Console.WriteLine("Enter any number");
               number = Convert.ToInt32(Console.ReadLine());
                while (number != 0)
                {
                    for (int i = 2; i <= number; i++)
                    { 
                        harmonic += (float)1 / i;
                      
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Hormonic number" + harmonic);
            Console.ReadKey();
        }

        /// <summary>
        /// Primes the factor.
        /// </summary>
        /// <param name="number">The number.</param>
       public void PrimeFactor(int number)
        {
            int i = 2;
            while (number != 1)
            {
                if (number % i == 0)
                {
                    while (number % i == 0)
                    {
                         Console.WriteLine(number + "=" + number + "%" + i);
                        number = number / i;
                    }
                }

                i++;
            }
        }

        /// <summary>
        /// Powers the function.
        /// </summary>
        /// <param name="number">The number.</param>
       public void PowerFunction(int number)
       {
            try
            {
                int i = 0;
                int power = 1;

                if (number > 0)
                {
                    while (i <= number)
                    {
                        Console.WriteLine("Power of Number = 2^" + i + "= " + power);
                        power = power * 2;
                        i++;
                    }
                }
                else
                {
                    if (i >= number)
                    {
                        Console.WriteLine("Power of Number = 2^ " + i + "=" + power);
                        i--;
                   }
                }            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Replace User Name as function
        /// </summary>
        /// <param name="username">username as parameter</param>
       public void ReplaceUserName(string username)
        {
            try
            {
                if (username.Length > 3)
                {
                    string input = "Hello <<UserName>>, How are you?";
                    input = input.Replace("<<UserName>>", username);
                    Console.WriteLine(input);                   
                }
                else
                {
                    Console.WriteLine("Enter name should be greater than three character");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("String Not Find" + e.Message);
            }
        }

        /// <summary>
        /// Toss game
        /// </summary>
        /// <param name="coins">coins as parameter</param>
       public void Tossgame(int coins)
        {
            try
            {
                int heads = 0;
                int tails = 0;
                if (coins > 1)
                {
                    Random random = new Random();
                    double randomvariable = 0.0;
                   
                    for (int i = 0; i < coins; i++)
                    {
                        randomvariable = random.NextDouble();
                        Console.WriteLine(randomvariable);
                        
                        if (randomvariable < 0.5)
                        {
                            heads += 1;
                        }
                        else
                        {
                            tails += 1;
                        }
                    }

                    double heasdpercentage = (double)(heads * 100) / coins;
                    double tailspercentage = (double)(tails * 100) / coins;
                    Console.WriteLine(heasdpercentage + "%" + "\n" + tailspercentage + "%");  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Win  loss game
        /// </summary>
        /// <param name = "stake">stake as parameter</param>
        /// <param name = "goal">goal as parameter</param>     
       public void Winlossgame(int stake, int goal)
        {
            int win = 0;
            int bets = 0;
            try
            {
                Console.WriteLine("Enter trails glamber");
                int trials = Convert.ToInt32(Console.ReadLine());
                if (trials > 0)
                {
                }
                else
                {
                    Console.WriteLine("trails should be greater then 0");
                    this.Winlossgame(stake, goal);
                }

                for (int i = 0; i < trials; i++)
                {
                    int cash = stake;
                    if (cash > 0 && cash < goal)
                    {
                        bets++;
                        cash += 1;
                    }
                    else
                    {
                        cash -= 1;
                    }

                    if (cash == goal)
                    {
                        win++;
                    }

                    Console.WriteLine(win + " " + "wins of" + " " + trials);
                    Console.WriteLine("percertange of wins=" + (100.0 * win / trials) + "%");
                    Console.WriteLine("percertange of bets=" + (1.0 * bets / trials) + "%");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        /// <summary>
        /// Create Coupon
        /// </summary>
        /// <param name="rows">rows as parameter</param>
        /// <param name="column">column as parameter</param>
        public void CreateCoupon(int rows, int column)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// User Input Array
        /// </summary>
        /// <param name="rows">row as parameter</param>
        /// <param name="columns">column as parameter</param>
        public void UserInputArray(int rows, int columns)
        {
            try
            {
                rows = Convert.ToInt32(Console.ReadLine());
                columns = Convert.ToInt32(Console.ReadLine());

                int[,] array = new int[rows, columns];
                Console.WriteLine("Enter Array Element");
                for (int i = 0; i <= rows; i++)
                {
                    for (int j = 0; j <= columns; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Multiplication of array as function
        /// </summary>
        /// <param name="row">row as parameter</param>
        /// <param name="column">column as parameter</param>
        public void Multiplicationofarray(int row, int column)
        {
            try
            {
                Console.WriteLine("Enter rows of arry");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter column of arry");
                column = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[2, 2];
                Console.WriteLine("enter element");
                ////this for loop used to take a array elemnt 
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                //// this for loop used to dispaly array
                for (int i = 0; i < row; i++) 
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
                ////this for loop used to take a second array elemnt 
                int[,] array2 = new int[2, 2];
                Console.WriteLine("enter element");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                //// dispaly array 
                for (int i = 0; i < row; i++) 
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(array2[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                int[,] result = new int[row, column];
                ////This for loop used to multipication of 2d array
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < row; k++)
                        {
                            result[i, j] = array[i, j] * array2[i, j];
                        }
                    }
                }

                Console.WriteLine("Multipication of arrays");
                ////This for loop used to diplay multipication of 2d array
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(result[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Triple Addition as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public void TripleAddition(int number)
        {
            try
            {
                int i, j, k;
                int count = 0;
                Console.WriteLine("Enetr number of digit");
                number = Convert.ToInt32(Console.ReadLine());
               
                int[] array = new int[number];
                ////loop used to take a array element
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }            

                for (i = 0; i < array.Length - 2; i++)
                {
                    for (j = i + 1; j < array.Length - 1; j++)
                    {
                        for (k = j + 1; k < array.Length; k++)
                        {
                            if (array[i] + array[j] + array[k] == 0)
                            {
                                count++;
                                Console.WriteLine("Finf Element " + array[i] + " " + array[j] + " " + array[k]);
                            }                           
                        }                  
                    }
                }

                if (count > 0)
                {
                    Console.WriteLine("Triple of Element " + count);
                }
                else
                {
                    Console.WriteLine("Sorry Triple not found in given array");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// DistanceFromPoint as function
        /// </summary>
        /// <param name="x">x as parameter</param>
        /// <param name="y">y as parameter</param>
        public void DistanceFromPoint(int x, int y)
        {
            Console.WriteLine("Enter Two Points");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            double distance = 0;
            distance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("distance of two points = " + distance);
        }

        /// <summary>
        /// FindPermutation as function
        /// </summary>
        /// <param name="letter">letter as parameter</param>
        /// <param name="number">number as parameter</param>
        /// <param name="count">count as parameter</param>
        public void FindPermutation(string letter, int number, int count)
        {
            try
            {
                if (number == count)
                {
                    Console.WriteLine("Enter String");
                    letter = Convert.ToString(Console.ReadLine());
                    swap(letter, number, count);
                }
                else
                {
                    for (int i = number; i <= count; i++)
                    {
                        letter = swap(letter, number + 1, i);
                       this.FindPermutation(letter, number + 1, count);
                    }
                }

                 string swap(string word, int i, int j)
                {
                    char temp;
                    char[] permuterray = word.ToCharArray();
                    temp = permuterray[i];
                    permuterray[i] = permuterray[j];
                    permuterray[j] = temp;
                    string newpermutationstring = new string(permuterray);
                    return newpermutationstring;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ElapsedTime as function
        /// </summary>
        public void ElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time = " + stopwatch.Elapsed);
        }

        /// <summary>
        /// Quadratic as function
        /// </summary>
        /// <param name="first">first as parameter</param>
        /// <param name="second"> second as parameter</param>
        /// <param name="third">third as parameter</param>
        public void Quadratic(int first, int second, int third)
        {
            Console.WriteLine("Enter Input");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());

            double delta, root1, root2;
            delta = (second * second) - (4 * first * third);
            root1 = ((-second) + Math.Sqrt(delta)) / (2 * first);
            root2 = ((-second) - Math.Sqrt(delta)) / (2 * first);
            Console.WriteLine(delta + "\n" + root1 + "\n" + root2);
        }

        /// <summary>
        /// Calculate Temperature as function
        /// </summary>
        /// <param name="temperature">temperature as parameter</param>
        /// <param name="speed">speed as parameter</param>
        public void CalculateTemperature(int temperature, int speed)
        {
            double windchill;
            Console.WriteLine("Enter temperature");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed");
            speed = Convert.ToInt32(Console.ReadLine());
            if ((temperature <= 50) && (speed > 3 && speed < 120))
            {
                Console.WriteLine(temperature + " " + speed);
            }
            else
            {
               this.CalculateTemperature(temperature, speed);
            }

            windchill = (35.75 + 0.6215) * temperature + (0.4275 * temperature - 35.75) * Math.Pow(speed, 0.16);
            Console.WriteLine(windchill);
        }

        /// <summary>
        /// FindLeapYear is function
        /// </summary>
        /// <param name="year">year is parameter</param>
        public void FindLeapYear(int year)
        {
            try
            {
                year = Math.Abs(year);
                if (year <= 4 && year >= 4)
                {
                    Console.WriteLine("year shoukd be 4 digits");
                    this.FindLeapYear(year);
                }

                if (year % 4 == 0 || year % 100 == 0 || year % 400 == 0)
                {
                    Console.WriteLine(year + " " + "It is leap year");
                }
                else
                {
                    Console.WriteLine(year + " " + "This is not leap year");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }   
}
