//-----------------------------------------------------------------------
// <copyright file="DequeueNode.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.PalindromeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DequeNode class
    /// </summary>
    /// <typeparam name="T">name type of field</typeparam>
    public class DequeueNode<T>
    {
        /// <summary>
        /// data field
        /// </summary>
        private T data;

        /// <summary>
        /// DequeNode is type of next object
        /// </summary>
        private DequeueNode<T> next;

        /// <summary>
        /// DequeNode is type of pre object
        /// </summary>
        private DequeueNode<T> pre;

        /// <summary>
        /// Initializes a new instance of the <see cref="DequeueNode"/> class.
        /// </summary>
        /// <param name="data">data field</param>
        public DequeueNode(T data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public DequeueNode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public DequeueNode<T> Pre
        {
            get { return this.pre; }
            set { this.pre = value; }
        }
    }
}
