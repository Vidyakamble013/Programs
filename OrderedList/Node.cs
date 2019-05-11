﻿//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.OrderedList
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
        /// next is objects
        /// </summary>
        private Node next;

        /// <summary>
        /// data as member
        /// </summary>
        private int data;

        /// <summary>
        /// position as parameter
        /// </summary>
        private long position;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">data as parameter</param>
        /// <param name="position">position as parameter</param>
        public Node(int data, long position)
        {
            this.position = position;
            this.data = data;
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public Node Next
        {
            get
            {
                return this.next;
            }

            set
            {
                this.next = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}
