//-----------------------------------------------------------------------
// <copyright file="Queue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.BankingOperation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Queue as class
    /// </summary>
   public class Queue
    {
        private int maximumsizeofqueue = 1000;

        private int rear = -1;

        private int front = -1;

        private Person[] queuearray = new Person[1000];

        private int size;

        public int QueueMaximumSize
        {
            get { return this.maximumsizeofqueue; }
            set { this.maximumsizeofqueue = value; }
        }

        public int Rear
        {
            get { return this.rear; }
            set { this.rear = value; }
        }

        public int Front
        {
            get { return this.front; }
            set { this.front = value; }
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        /// <summary>
        /// EnqueueOperation as function
        /// </summary>
        /// <param name="data">data as parameter</param>
        /// <returns>return boolean</returns>
        public bool EnqueueOperation(Person data)
        {
            try
            {
                if (this.rear == this.maximumsizeofqueue - 1)
                {
                    Console.WriteLine("Queue Size is Overflow");
                    return false;
                }
                else
                {
                    if (this.front == -1)
                    {
                        this.front = 0;
                    }
                    this.rear++;
                    this.queuearray[this.rear] = data;
                    this.size++;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// DequeueOperation as function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool DequeueOperation()
        {
            try
            {
                if (this.front == -1 || this.front > this.rear)
                {
                    Console.WriteLine("Queue Size Underflow");
                    return false;
                }
                else
                {
                    Console.WriteLine(this.queuearray[this.front].Name + " " + "remove from the queue");
                    Console.WriteLine("Available Balance" + " " + this.queuearray[this.front].Balance);
                    this.front++;
                    this.size--;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            } 
        }

        /// <summary>
        /// ShowElements as function
        /// </summary>
        public void ShowElements()
        {
            try
            {
                if (this.front == -1)
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    for (int i = this.front; i <= this.front; i++)
                    {
                        Console.WriteLine(this.queuearray[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// CheckTheSizeofQueue as function
        /// </summary>
        /// <returns>returns boolean</returns>
        public int CheckTheSizeofQueue()
        {
            try
            {
                return this.size;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
