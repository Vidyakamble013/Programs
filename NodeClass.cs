//-----------------------------------------------------------------------
// <copyright file="NodeClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// NodeClass as class
    /// </summary>
    /// <typeparam name="T">collection of T</typeparam>
    public class NodeClass<T>
    {
        /// <summary>
        /// data as object type
        /// </summary>
        private object data;

        /// <summary>
        /// next is field
        /// </summary>
        private NodeClass<T> next;

        /// <summary>
        /// Initializes a new instance of the NodeClass class.
        /// </summary>
        /// <param name="nodeObject">nodeObject as field</param>
        /// <param name="nodeClass">nodeClass as field</param>
        public NodeClass(object nodeObject, NodeClass<T> nodeClass)
        {
            this.data = nodeObject;
            this.next = nodeClass;
        }

        /// <summary>
        /// Initializes a new instance of the NodeClass class.
        /// </summary>
        /// <param name="nodeObject">nodeObject as field</param>
        public NodeClass(object nodeObject)
        {
            this.data = nodeObject;
        }

        /// <summary>
        /// SetData as function
        /// </summary>
        /// <param name="data">data as field</param>
        public void SetData(object data)
        {
            this.data = data;
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>object type return</returns>
        public object GetData()
        {
            return this.data;
        }

        /// <summary>
        /// SetNext as function
        /// </summary>
        /// <param name="node">node as field</param>
        public void SetNext(NodeClass<T> node)
        {
            this.next = node;
        }

        /// <summary>
        /// GetNext function
        /// </summary>
        /// <returns>return type function</returns>
        public NodeClass<T> GetNext()
        {
            return this.next;
        }
    }
}
