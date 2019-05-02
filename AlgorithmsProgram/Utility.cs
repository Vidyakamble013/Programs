//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility as class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// AnagramFunction as function
        /// </summary>
        /// <param name="input1">input1 as parameter</param>
        /// <param name="input2">input2 as parameter</param>
        public static void AnagramFunction(string input1, string input2)
        {
            try
            {
                input1 = Convert.ToString(Console.ReadLine());
                input2 = Convert.ToString(Console.ReadLine());
                char[] frist = input1.ToLower().ToCharArray();
                char[] second = input2.ToLower().ToCharArray();
                Array.Sort(frist);
                Array.Sort(second);
                string one = new string(frist);
                string two = new string(second);
                if (one == two)
                {
                    Console.WriteLine("Yes This is Anagram String");
                }
                else
                {
                    Console.WriteLine("Not Found");
                    AnagramFunction( input1, input2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// FindPrimeNumber as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void FindPrimeNumber(int number)
        {
            try
            {
               int result;
               int i;
               int prime = 0;
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0 && number <= 1000)
                {
                    Console.WriteLine("Continue...");
                }
                else
                {
                    FindPrimeNumber(number);
                }

                result = number / 2;
                for (i = 2; i <= result; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("It is not prime number");
                        prime = 1;
                        break;                       
                    }
                }

                if (prime == 0)
                {
                    Console.WriteLine("Prime number");
                }                            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// FindAnagramPalindrome as method
        /// </summary>
        /// <param name="number">number as parameter</param>       
        public static void FindAnagramPalindrome(int number)
        {
            try
            {
                int panlindrome = 0;
                int compare, remainder;
                number = Convert.ToInt32(Console.ReadLine());                
                if (number >= 0 && number <= 1000)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Please enter the number should be positive");
                    FindAnagramPalindrome(number);
                }

                compare = number;
                while (number > 0)
                {
                    remainder = number % 10;
                    number = number / 10;
                    panlindrome = (panlindrome * 10) + remainder;
                }    
                
                if (compare == panlindrome)
                {
                    Console.WriteLine(panlindrome + " " + " Is Panlindrome Number");                   
                }
                else
                {
                    Console.WriteLine(panlindrome + " " + " Is Not Nanlindrome Number");                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BinarySearchForString as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        /// <param name="input">input as parameter</param>
        public static void BinarySearchForString(string[] array, string input)
        {
            array = new string[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
                Console.WriteLine(array);
            }
        }

        /// <summary>
        /// BinarySearchFromWordList as function
        /// </summary>
        /// <param name="word">word as parameter</param>
        /// <param name="line">line as parameter</param>
        public static void BinarySearchFromWordList(string word, string line)
        {
            int count = 0;
            int i = 0;
            string key = " ";
            string[] array = new string[i];

            for (i = 0; i < word.Length; i++)
            {
                if (key.Equals(array[i] == word))
                {
                    Console.WriteLine("String found" + key);
                }
                else if (count == 0)
                {
                    Console.WriteLine("Not found");
                    BinarySearchFromWordList(word, line);
                }
            }
        }

        /// <summary>
        /// BubbleSortFunction as function
        /// </summary>
        public static void BubbleSortFunction()
        {
            try
            {
                int i = 0;
                int temp;
                int length = 0;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[length];
                Console.WriteLine("Enter element into array");
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int n = arr.Length;
                for (i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted Array");
                {
                    n = arr.Length;
                    for (i = 0; i < n; ++i)
                    {
                        Console.Write(arr[i] + " ");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortStringUsingInsertionSort as function
        /// </summary>
        public static void SortStringUsingInsertionSort()
        {
            try
            {
                int i = 0, j = 0;
                int length = 0;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                IComparable[] list = new string[length];
                Console.WriteLine("Add word into array");
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }

                for (i = 0; i < list.Length; i++)
                {
                    IComparable value = list[i];
                    j = i - 1;
                    while ((j >= 0) && list[j].CompareTo(value) > 0)
                    {
                        list[j + 1] = list[j];
                        j--;
                    }

                    list[j + 1] = value;
                }

                Console.WriteLine("Sorted String Array");
                {
                    IComparable newArray = list.Length;
                    for (i = 0; i < list.Length; ++i)
                    {
                        Console.WriteLine(list[i] + " ");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortStringUsingMergeSort as function
        /// </summary>
        public static void SortStringUsingMergeSort()
        {
            try
            {
                int i = 0, result, position, number;
                int length = 0;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                string[] list = new string[length];
                Console.WriteLine("Add word into array");
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DayOfWeek as function
        /// </summary>
        /// <param name="year">year sa parameter</param>
        /// <param name="month">month as parameter</param>
        /// <param name="date">date as parameter</param>
        public static void DayOfWeek(int year, int month, int date)
        {
            try
            {
                string[] dayofweek = { "Sunday", "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday" };

                Console.WriteLine("Enter the year");
                year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the month");
                month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the date");
                date = Convert.ToInt32(Console.ReadLine());

                if (month > 12 || date > 31)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    int printday = dayofweek.Length;
                    int y0 = year - ((14 - month) / 12);
                    int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                    int m0 = ((month + 12) * ((14 - month) / 12)) - 2;
                    int d0 = (date + x + 31) * (m0 / (12 % 7));
                    if (d0 <= printday)
                    {
                        Console.WriteLine("The day of week is " + dayofweek[d0]);
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// TemperatureConversionMethod as function
        /// </summary>
        /// <param name="temperature">temperature as parameter</param>
        public static void TemperatureConversionMethod(int temperature)
        {
            try
            {
                Console.WriteLine("Enter Temperatur ");
                temperature = Convert.ToInt32(Console.ReadLine());
                int fahrenheit = 0;
                int celsius = 0;
                fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine("Celsius to Fahrenheit " + fahrenheit + "F");
                celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine("Fahrenheit to Celsius " + celsius + "C");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// PaymentSlip as method
        /// </summary>
        /// <param name="amount">amount as parameter</param>
        /// <param name="year">year as parameter</param>
        /// <param name="rate">rate as parameter</param>
        public static void PaymentSlip(int amount, int year, int rate)
        {
            try
            {
                double n, r, payment;
                n = 12 * year;
                r = rate / (12 * 100);
                payment = amount * r / (1 - Math.Pow(1 + r, -n));
                Console.WriteLine(payment);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// VendingMachineMethod as function
        /// </summary>
        /// <param name="amount">amount as parameter</param>
        public static void VendingMachineMethod(int amount)
        {
            int[] notes = { 2000, 1000, 500, 300, 200, 100, 50, 5, 1 };
            int[] counter = new int[9];
            Console.WriteLine("Enter your amount");
            amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    counter[i] = amount / notes[i];
                    amount = amount - (counter[i] * notes[i]);
                }
            }

            Console.WriteLine("Total number of changed notes");
            for (int i = 0; i < 9; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine("required changes {0} is {1} =" + (notes[i], counter[i]));
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Square rootMethod as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void SquarerootMethod(int number)
        {
            double epsilon = 1e-15;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            if (number > 0)
            {
                while (Math.Abs(temp - (number / temp)) > (epsilon * temp))
                {
                    Console.WriteLine(temp);
                }
            }
            else
            {
                Console.WriteLine("Please Enter Positive Number");
                SquarerootMethod(number);
            }
        }

        /// <summary>
        /// ToBinaryConversion as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void ToBinaryConversion(int number)
        {
            try
            {
                Console.WriteLine("Enter number");
                number = int.Parse(Console.ReadLine());
                int remainder;
                string result = " ";
                while (number >= 1)
                {
                    remainder = number / 2;
                    result += (number % 2).ToString();
                    number = remainder;
                }

                string binarynumber = " ";
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    binarynumber = binarynumber + result[i];
                }

                Console.WriteLine("Binary number format is = " + binarynumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BinaryToDecimal as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void BinaryToDecimal(int number)
        {
            try
            {
                int basevalue = 1;
                int temp;
                int decvalue = 0, num = 1, result;
                Console.WriteLine("Enter Number");
                number = int.Parse(Console.ReadLine());
                temp = number;

                for (int j = temp; j > 0; j = j / 10)
                {
                    result = j % 10;
                    if (num == 1)
                    {
                        basevalue *= 1;
                    }
                    else
                    {
                        basevalue *= 2;
                    }

                    decvalue = decvalue + (result * basevalue);
                    num++;
                }

                Console.WriteLine("Decimal to binary = " + decvalue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// IntegerBinarySearch as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        public static void IntegerBinarySearch(int[] array)
        {
            try
            {               
                int length;               
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                array = new int[length];
                Console.WriteLine("Enter array Element");
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }   
                
                Console.WriteLine("Enter Search Element");
                    int search = int.Parse(Console.ReadLine());
                    int low = 0;
                
                int high = array.Length - 1;
                while (low <= high)
                {
                    int mid = (low + high - 1) / 2;
                    if (array[mid] == search)
                    {
                        Console.WriteLine(mid);
                    }
                    if(array[mid] < search) 
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }                   
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BubbleSortForString as method
        /// </summary>
        public static void BubbleSortForString()
        {
            try
            {
                int i, l;
                int length = 0;
                IComparable temp;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                IComparable[] list = new string[length];
                Console.WriteLine("Add word into array");
                l = list.Length - 1;
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }

                for (i = 0; i < l; i++)
                {
                    for (int j = 0; j < l - 1; j++)
                    {
                        if (list[j].CompareTo(list[j + 1]) > 0)
                        {
                            temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("\n Sort Array");
               for (i = 0; i < l; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
