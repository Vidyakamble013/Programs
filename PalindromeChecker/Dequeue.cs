//-----------------------------------------------------------------------
// <copyright file="Dequeue.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.PalindromeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Dequeue as class
    /// </summary>
    /// <typeparam name="T">name as field</typeparam>
    public class Dequeue<T>
    {
        /// <summary>
        /// DequeNode class object of front
        /// </summary>
        private DequeueNode<T> front;

        /// <summary>
        /// DequeNode class object of rear
        /// </summary>
        private DequeueNode<T> rear;

        /// <summary>
        /// size field
        /// </summary>
        private long size = 0;

        /// <summary>
        /// AddToFront as function
        /// </summary>
        /// <param name="data">data as field</param>
        public void AddToFront(T data)
        {
            try
            {
                if (this.front == null)
                {
                    this.front.Data = data;
                    this.rear = this.front;
                }
                else
                {
                    DequeueNode<T> tempNode = null;
                    tempNode.Data = data;
                    tempNode.Next = this.front;
                    this.front.Pre = tempNode;
                    this.front = tempNode;
                }

                this.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// AddToRear function
        /// </summary>
        /// <param name="data">data as field</param>
        public void AddToRear(T data)
        {
            try
            {
                if (this.front == null)
                {
                    DequeueNode<T> dequeNode = new DequeueNode<T>(data);
                    this.front = dequeNode;
                    this.rear = this.front;
                }
                else
                {
                    DequeueNode<T> dequeNode = new DequeueNode<T>(data);
                    this.rear.Next = dequeNode;
                    dequeNode.Pre = this.rear;
                    this.rear = dequeNode;
                }

                this.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// RemoveToFront function
        /// </summary>
        /// <returns>return boolean</returns>
        public T RemoveToFront()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Already empty");
                }
                else
                {
                    dataToRemove = this.front.Data;
                    this.front = this.front.Next;
                }

                this.size--;
                return dataToRemove;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// RemoveToFront type 
        /// </summary>
        /// <returns>return type</returns>
        public T RemoveToRear()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Already Empty");
                }
                else
                {
                    dataToRemove = this.rear.Data;
                    this.rear = this.rear.Pre;
                    this.rear.Next = null;
                }

                this.size--;
                return dataToRemove;
            }
            catch (Exception ex)
            {
              throw new Exception(ex.Message);                
            }
        }

        /// <summary>
        /// IsEmpty as function
        /// </summary>
        /// <returns>return boolean</returns>
        public bool IsEmpty()
        {
            try
            {
                if (this.front == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Size function
        /// </summary>
        /// <returns>return long</returns>
        public long Size()
        {
            try
            {
                return this.size;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }
    }
}
