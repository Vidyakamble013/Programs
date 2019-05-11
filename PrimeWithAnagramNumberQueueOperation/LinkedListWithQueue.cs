//-----------------------------------------------------------------------
// <copyright file="LinkedListWithQueue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.PrimeWithAnagramNumberQueueOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LinkedListWithQueue class
    /// </summary>
    public class LinkedListWithQueue
    {
        /// <summary>
        /// Node class object front
        /// </summary>
        private Node front;

        /// <summary>
        /// Node class object rear
        /// </summary>
        private Node rear;

        /// <summary>
        /// size field
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListWithQueue"/> class.
        /// </summary>
        public LinkedListWithQueue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        /// <summary>
        /// EnqueueOperation function
        /// </summary>
        /// <param name="data">data field</param>
        public void EnqueueOperation(object data)
        {
            try
            {
                Node node = new Node(data);
                if (this.rear == null)
                {
                    this.front = this.rear = node;
                }
                else
                {
                    Node temp = this.rear.GetNext();
                    temp = node;
                    this.rear = node;
                }

                this.size++;
                Console.Write(data + " ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DequeueOperation function
        /// </summary>
        public void DequeueOperation()
        {
            try
            {
                if (this.front == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }

                Node temp = this.front;
                this.front = this.front.GetNext();

                if (this.front == null)
                {
                    this.rear = null;
                }

                this.size--;

                Console.WriteLine("Deleted Element  is {0}", temp.GetData());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// PrintFunction function
        /// </summary>
        public void PrintFunction()
        {
            try
            {
                if (this.IsEmptyFunction())
                {
                    Console.WriteLine("Empty Queue");
                }

                Node temp = this.rear;

                while (temp != null)
                {
                    Console.WriteLine(temp.GetData() + "  ");
                    temp = temp.GetNext();
                }
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
        /// IsEmptyFunction function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool IsEmptyFunction()
        {
            if (this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
