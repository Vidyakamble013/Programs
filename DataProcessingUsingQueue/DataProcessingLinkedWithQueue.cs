//-----------------------------------------------------------------------
// <copyright file="DataProcessingLinkedWithQueue.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DataProcessingLinkedWithQueue as class
    /// </summary>
    /// <typeparam name="T">name as field</typeparam>
    public class DataProcessingLinkedWithQueue<T>
    {
        /// <summary>
        /// front as class type object
        /// </summary>
        private NodeClass<T> front;

        /// <summary>
        /// rear as class type object
        /// </summary>
        private NodeClass<T> rear;

        /// <summary>
        /// size as field
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the DataProcessingLinkedWithQueue class.
        /// </summary>
        public DataProcessingLinkedWithQueue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        /// <summary>
        /// EnqueueOperation as function
        /// </summary>
        /// <param name="data">data as field</param>
        public void EnqueueOperation(object data)
        {
            try
            {
                NodeClass<T> newNode = new NodeClass<T>(data);
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    NodeClass<T> temp = this.rear.GetNext();
                    temp = newNode;
                    this.rear = newNode;
                }

                this.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
