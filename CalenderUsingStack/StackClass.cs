using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.CalenderUsingStack
{
    class StackClass
    {
        private int maxSize;
        private int[] stackArray;
        private int top;

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
