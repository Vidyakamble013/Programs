//-----------------------------------------------------------------------
// <copyright file="AnagramNumberLinkedList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.PrimeWithAnagramNumberStackOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AnagramNumberLinkedList function
    /// </summary>
   public class AnagramNumberLinkedList
    {
        /// <summary>
        /// Node class object top
        /// </summary>
        private Node top;

        /// <summary>
        /// size as field
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnagramNumberLinkedList"/> class.
        /// </summary>
        public AnagramNumberLinkedList()
        {
            this.top = null;
            this.size = 0;
        }

        /// <summary>
        /// Push function
        /// </summary>
        /// <param name="value">value as field</param>
        public void Push(object value)
        {
            try
            {
                Node newNode = new Node(value);

                if (this.top == null)
                {
                    //// Node points to next node
                    Node temp = newNode.GetNext();
                    temp = null;
                }
                else
                {
                    Node temp = newNode.GetNext();
                    this.top = temp;
                }

                this.size++;
                this.top = newNode;
                Console.WriteLine(value + " ");
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pop function
        /// </summary>
        public void Pop()
        {
            try
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }

                this.size--;
                Console.WriteLine("Item popped is {0}" + this.top.GetData());
                this.top = this.top.GetNext();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Peek function
        /// </summary>
        public void Peek()
        {
            try
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }

                if (this.top == null)
                {
                    //// Displays stack underflow message
                    Console.WriteLine("Stack Underflow.");
                    return;
                }

                Console.WriteLine("{0} is on the top of Stack", this.top.GetData());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Count function
        /// </summary>
        /// <returns>return integer</returns>
        public int Count()
        {
            return this.size;
        }

        /// <summary>
        /// IsEmpty function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool IsEmpty()
        {
            //// checks for the size is empty
            if (this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// PrintFunction function
        /// </summary>
        public void PrintFunction()
        {
            try
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Empty Linked List");
                }

                Node temp = this.top;
                string string1 = " ";

                while (temp != null)
                {
                    string1 = string1 + " " + temp.GetData();
                    Console.WriteLine(string1);
                    temp = temp.GetNext();
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
