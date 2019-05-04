//-----------------------------------------------------------------------
// <copyright file="ILinkedList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.OrderedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ILinkedList as interface
    /// </summary>
    public interface ILinkedList
    {
        /// <summary>
        /// Add as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        /// <returns>return boolean</returns>
        bool Add(int number);

        /// <summary>
        /// IsEmpty as function
        /// </summary>
        /// <returns>return boolean</returns>
        bool IsEmpty();

        /// <summary>
        /// size as object
        /// </summary>
        /// <returns>return long</returns>
        long Size();

        /// <summary>
        /// Delete as method
        /// </summary>
        /// <param name="searchnumber">search number as parameter</param>
        /// <returns>return boolean</returns>
        bool Delete(int searchnumber);

        /// <summary>
        /// Insert as function 
        /// </summary>
        /// <param name="data">data as parameter</param>
        /// <param name="pos">pos as parameter</param>
        /// <returns>return boolean</returns>
        bool Insert(int data, long pos);

        /// <summary>
        /// Print as function
        /// </summary>
        void Print();

        /// <summary>
        /// Contains as function
        /// </summary>
        /// <param name="word">word as parameter</param>
        /// <returns>return boolean</returns>
        bool Contains(int word);
    }
}
