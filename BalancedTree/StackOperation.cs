//-----------------------------------------------------------------------
// <copyright file="StackOperation.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructureProgram.BalancedTree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackOperation as class
    /// </summary>
    public class StackOperation
    {
        /// <summary>
        /// size field
        /// </summary>
        private int size;

        /// <summary>
        /// stack array char array
        /// </summary>
        private char[] stackarray;

        /// <summary>
        /// top field
        /// </summary>
        private int top;

        /// <summary>
        /// Stack Initialize as function
        /// </summary>
        /// <param name="stacksize">stacksize as parameter</param>
        public void StackInitialise(int stacksize)
        {
            try
            {
                this.size = stacksize;
                this.stackarray = new char[this.size];
                this.top = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Push is function
        /// </summary>
        /// <param name="character">character field</param>
        public void Push(char character)
        {
            try
            {
                this.top++;
                this.stackarray[this.top] = character;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pop is function
        /// </summary>
        /// <returns>return boolean</returns>
        public long Pop()
        {
            try
            {
                if (this.top == 0)
                {
                    this.top--; 
                    return this.stackarray[this.top + 1];
                }
                else
                {
                    this.top--;
                    return this.stackarray[this.top];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// IsEmpty function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool IsEmpty()
        {
            try
            {
                return this.top == -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// IsFull function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool IsFull()
        {
            try
            {
                return this.top == this.size - 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
