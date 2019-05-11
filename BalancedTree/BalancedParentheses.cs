//-----------------------------------------------------------------------
// <copyright file="BalancedParentheses.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructureProgram.BalancedTree;

    /// <summary>
    /// BalancedParentheses as class
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// BalancedParenthesesProgram as function
        /// </summary>
        public static void BalancedParenthesesProgram()
        {
            string stringexpression = string.Empty;
            long expressionlength = 0;
            try
            {
                StackOperation stack = new StackOperation();
                stack.StackInitialise(Convert.ToInt32(150));
                bool loopingexpression = true;
                expressionlength:
                //// check while loop condition
                while (loopingexpression)
                {
                    Console.WriteLine("Enter any exprssion");
                    stringexpression = Console.ReadLine();

                    //// call StringChecker function in Utility class
                    if (Utility.StringChecker(stringexpression))
                    {
                        Console.WriteLine("Invalid Expression");
                        continue;
                    }

                    break;
                }

                expressionlength = stringexpression.Length;
                for (int i = 0; i < expressionlength; i++)
                {
                    char character = stringexpression[i];

                    //// check all parantheses
                    if (character == '(')
                    {
                        break;
                    }

                    //// check all parantheses
                    if (character == '[')
                    {
                        break;
                    }

                    //// check all parantheses
                    if (character == '{')
                    {
                        break;
                    }

                    //// check all parantheses
                    if (character == ')')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }

                    //// check all parantheses
                    if (character == ']')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }

                    //// check all parantheses
                    if (character == '}')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }
                }

                for (int i = 0; i < expressionlength; i++)
                {
                    char character = stringexpression[i];
                    //// check all parantheses
                    if (character == '(')
                    {
                        stack.Push(character);
                    }

                    //// check all parantheses
                    if (character == '{')
                    {
                        stack.Push(character);
                    }

                    //// check all parantheses
                    if (character == '[')
                    {
                        stack.Push(character);
                    }
                    //// check all parantheses
                    else if (character == ')')
                    {
                        stack.Pop();
                    }
                    //// check all parantheses
                    else if (character == '}')
                    {
                        stack.Pop();
                    }
                    //// check all parantheses
                    else if (character == ']')
                    {
                        stack.Pop();
                    }
                }

                //// call IsEmpty() function
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Parenthese are balanced");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid Closing Parenthese ");
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
