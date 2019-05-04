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
        private int maxsize;
        private char[] stackarray;
        private int top;

        /// <summary>
        /// StackInitialise as function
        /// </summary>
        /// <param name="stacksize">stacksize as parameter</param>
        public void StackInitialise(int stacksize)
        {
            try
            {
                this.maxsize = stacksize;
                this.stackarray = new char[this.maxsize];
                this.top = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
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
        public bool IsFull()
        {
            try
            {
                return this.top == this.maxsize - 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
