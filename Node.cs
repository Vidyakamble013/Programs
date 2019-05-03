//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Node as class
    /// </summary>
   public class Node
    {
        /// <summary>
        /// the data as object
        /// </summary>
        private object data;

        /// <summary>
        /// the node to the next
        /// </summary>
        private Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="object1">object1 as parameter</param>
        /// <param name="n">n as object</param>
        public Node(object object1, Node n)
        {
            this.data = object1;
            this.next = n;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="o">o as parameter</param>
        public Node(object o)
        {
            this.data = o;
        }

        /// <summary>
        /// SetData as class
        /// </summary>
        /// <param name="data">data as parameter</param>
        public void SetData(object data)
        {
            this.data = data;
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>return true or false</returns>
        public object GetData()
        {
            return this.data;
        }

        /// <summary>
        /// SetNext as function
        /// </summary>
        /// <param name="n">n as parameter</param>
        public void SetNext(Node n)
        {
            this.next = n;
        }

        /// <summary>
        /// Get Next as function
        /// </summary>
        /// <returns>Node return</returns>
        public Node GetNext()
        {
            return this.next;
        }
    }
}
