//-----------------------------------------------------------------------
// <copyright file="LinkedListStackClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LinkedListStackClass as class
    /// </summary>
    /// <typeparam name="T">The name generic type parameter. </typeparam>
    public class LinkedListStackClass<T>
    {
        /// <summary>
        /// the top field
        /// </summary>
        private NodeClass<T> top;

        /// <summary>
        /// size field
        /// </summary>
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListStackClass{T}"/> class..
        /// </summary>
        public LinkedListStackClass()
        {
            this.top = null;
            this.size = 0; 
        }

        /// <summary>
        /// PushFunction as function
        /// </summary>
        /// <param name="data">data as field</param>
        public void PushFunction(object data)
        {
            try
            {
                NodeClass<T> newNode = new NodeClass<T>(data);

                if (this.top == null)
                {
                    NodeClass<T> temp = newNode.GetNext();
                    temp = null;       
                }
                else
                {
                    NodeClass<T> temp1 = newNode.GetNext();
                    this.top = temp1;
                }

                this.size++;
                this.top = newNode;
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
