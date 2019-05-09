//-----------------------------------------------------------------------
// <copyright file="LinkedListClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.DataProcessingUsingLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LinkedListClass as class
    /// </summary>
    /// <typeparam name="T">name as field</typeparam>
    public class LinkedListClass<T>
    {
        /// <summary>
        /// firstNode is class type object
        /// </summary>
        private NodeClass<T> firstNode;

        /// <summary>
        /// sixe as field
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the LinkedListClass class.
        /// </summary>
        public LinkedListClass()
        {
            this.firstNode = null;
            this.size = 0;
        }

        /// <summary>
        /// AddCompanyStock as function
        /// </summary>
        /// <param name="data">data as field</param>
        public void AddCompanyStock(object data)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.firstNode = new NodeClass<T>(data, null);
                    this.size++;
                }
                else
                {
                    NodeClass<T> currentNode = this.firstNode;
                    NodeClass<T> tempNode = new NodeClass<T>(data, null);
                    while (currentNode.GetNext() != null)
                    {
                        currentNode = currentNode.GetNext();
                    }

                    currentNode.SetNext(tempNode);
                    this.size++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                if (this.size == 0)
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
    }
}
