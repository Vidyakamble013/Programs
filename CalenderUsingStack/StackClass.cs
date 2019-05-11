//-----------------------------------------------------------------------
// <copyright file="StackClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.CalenderUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackClass class
    /// </summary>
   public class StackClass
    {
        /// <summary>
        /// maxSize field
        /// </summary>
        private int maxSize;

        /// <summary>
        /// stackArray private array
        /// </summary>
        private int[] stackArray;

        /// <summary>
        /// top filed
        /// </summary>
        private int top;

        /// <summary>
        /// StackInitialize function
        /// </summary>
        /// <param name="stackSize">stackSize filed</param>
        public void StackInitialise(int stackSize)
        {
            try
            {
                this.maxSize = stackSize;
                this.stackArray = new int[this.maxSize];
                this.top = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Push function
        /// </summary>
        /// <param name="data">data as field</param>
        public void Push(int data)
        {
            try
            {
                this.top++;
                this.stackArray[this.top] = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pop function
        /// </summary>
        /// <returns>return boolean</returns>
        public int Pop()
        {
            try
            {
                if (this.top == 1)
                {
                    return 0;
                }

                this.top--;
                return this.stackArray[this.top];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Peek function
        /// </summary>
        /// <returns>return boolean</returns>
        public int Peek()
        {
            try
            {
                return this.stackArray[this.top];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// IsFull function
        /// </summary>
        /// <returns>returns boolean</returns>
        public bool IsFull()
        {
            try
            {
                return this.top == this.maxSize - 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
