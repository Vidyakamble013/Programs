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
                while (loopingexpression)
                {
                    Console.WriteLine("Enter any exprssion");
                    stringexpression = Console.ReadLine();

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
                    if (character == '(')
                    {
                        break;
                    }
                    if (character == '[')
                    {
                        break;
                    }
                    if (character == '{')
                    {
                        break;
                    }
                    if (character == ')')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }
                    if (character == ']')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }
                    if (character == '}')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionlength;
                    }
                }

                for (int i = 0; i < expressionlength; i++)
                {
                    char character = stringexpression[i];
                    if (character == '(')
                    {
                        stack.Push(character);
                    }
                    if (character == '{')
                    {
                        stack.Push(character);
                    }
                    if (character == '[')
                    {
                        stack.Push(character);
                    }                    
                    else if (character == ')')
                    {
                        stack.Pop();
                    }
                    else if (character == '}')
                    {
                        stack.Pop();
                    }
                    else if (character == ']')
                    {
                        stack.Pop();
                    }
                }
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
