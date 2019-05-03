//-----------------------------------------------------------------------
// <copyright file="SinglyUnorderedLinkedList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.UnorderedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SinglyUnorderedLinkedList as class
    /// </summary>
    public class SinglyUnorderedLinkedList
    {
        /// <summary>
        /// SinglyLinkedList as class
        /// </summary>
        public class SinglyLinkedList
        {
            /// <summary>
            /// Node is null
            /// </summary>
            private Node head;

            /// <summary>
            /// size is parameter
            /// </summary>
            private int size = 0;

            /// <summary>
            /// Initializes a new instance of the <see cref="SinglyLinkedList"/> class.
            /// </summary>
            public SinglyLinkedList()
            {
                this.head = null;
                this.size = 0;
            }

            /// <summary>
            /// Add as function
            /// </summary>
            /// <param name="data">data as parameter</param>
            public void Add(object data)
            {
                try
                {
                    if (this.IsEmpty())
                    {
                        this.head = new Node(data, null);
                        this.size++;
                    }
                    else
                    {
                        Node current = this.head;
                        Node temp = new Node(data, null);

                        while (current.GetNext() != null)
                        {
                            current = current.GetNext();
                        }

                        current.SetNext(temp);
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
            /// <returns>boolean type</returns>
            public bool IsEmpty()
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

            /// <summary>
            /// Print as function
            /// </summary>
            public void Print()
            {
                try
                {
                    if (this.IsEmpty())
                    {
                        Console.WriteLine("Empty Linked list");
                    }

                    Node temp = this.head;
                    while (temp != null)
                    {
                        Console.WriteLine("{0}", temp.GetData());
                        temp = temp.GetNext();
                    }

                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            /// <summary>
            /// search as function
            /// </summary>
            /// <param name="element">element as parameter</param>
            /// <returns>return boolean</returns>
            public bool Search(object element)
            {
                try
                {
                    Node temp = this.head;
                    while (temp != null)
                    {
                        if (temp.GetData().Equals(element))
                        {
                            return true;
                        }

                        temp = temp.GetNext();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return false;
            }

            /// <summary>
            /// Delete as function
            /// </summary>
            /// <param name="singlyLinkedList">singly Linked List as class parameter</param>
            /// <param name="element">element as parameter</param>
            public void Delete(SinglyLinkedList singlyLinkedList, object element)
                {
                try
                {
                    Node temp = singlyLinkedList.head;
                    Node perv = temp;

                    if (temp.GetData() == element)
                    {
                        singlyLinkedList.head = temp.GetNext();
                    }

                    while (temp != null)
                    {
                        if (temp.GetData().Equals(element))
                        {
                            perv.SetNext(temp.GetNext());
                            return;
                        }

                        perv = temp;
                        temp = temp.GetNext();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                }

            /// <summary>
            /// Counts this instance.
            /// </summary>
            /// <returns>return integer</returns>
            public int Count()
            {
                return this.size;
            }

            /// <summary>
            /// Write File as method
            /// </summary>
            /// <param name="path">path as parameter</param>
            /// <returns>return boolean</returns>
            public bool WriteFile(string path)
            {
                try
                {
                    if (this.head == null)
                    {
                        Console.WriteLine("list is already empty");
                        return false;
                    }
                    else
                    {
                        Node temp = this.head;
                        using (var writer = new System.IO.StreamWriter(path)) 
                        {
                            while (temp != null)
                            {
                                writer.Write(temp.GetData().ToString().Trim() + " ");
                                temp = temp.GetNext();
                            }
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
