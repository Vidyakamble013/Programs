//-----------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructureProgram.OrderedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SinglyLinkedList as class
    /// </summary>
    public class SinglyLinkedList
    {
        /// <summary>
        /// head field
        /// </summary>
        private Node head;

        /// <summary>
        /// last field
        /// </summary>
        private Node last;

        /// <summary>
        /// size field
        /// </summary>
        private long size = 0;

        /// <summary>
        /// SortLinkedList as function
        /// </summary>
        /// <param name="head">head as parameter</param>
        public static void SortLinkedList(Node head)
        {
            try
            {
                Node i;
                Node j;
                i = head;
                for (i = head; i.Next != null; i = i.Next)
                {
                    for (j = head; j.Next != null; j = j.Next)
                    {
                        if (i.Data > j.Data)
                        {
                            int temp = i.Data;
                            i.Data = j.Data;
                            j.Data = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Add function
        /// </summary>
        /// <param name="number">number as field</param>
        /// <returns>return boolean</returns>
        public bool Add(int number)
        {
            try
            {
                Node n = new Node(number, this.size);
                this.size++;

                if (this.head == null && this.last == null)
                {
                    this.head = n;
                    this.last = n;
                }
                else
                {
                    this.last.Next = n;
                    this.last = n;
                }

                SortLinkedList(this.head);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Contains as function
        /// </summary>
        /// <param name="word">word as parameter</param>
        /// <returns>return boolean</returns>
        public bool Contains(int word)
        {
            try
            {
                Node temp = this.head;
                while (temp != null)
                {
                    if (temp.Data == word)
                    {
                        return true;
                    }

                    temp = temp.Next;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Delete as function
        /// </summary>
        /// <param name="deletenumber">delete number as parameter</param>
        /// <returns>returns boolean</returns>
        public bool Delete(object deletenumber)
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("List is already empty");
                    return false;
                }
                else
                {
                    Node temp = this.head;
                    Node remove = null;
                    if (temp.Data.Equals(deletenumber))
                    {
                        remove = temp;
                        this.head = temp.Next;
                        return true;
                    }

                    for (int i = 0; i < this.size; i++)
                    {
                         if (temp.Data.Equals(deletenumber))
                        {
                            remove = temp.Next;
                            temp.Next = remove.Next;
                            break;
                        }

                        temp = temp.Next;
                    }

                    Console.WriteLine("Element is remove from list" + remove.Data);
                    remove.Next = null;
                    this.Reposition();
                    this.size = this.size - 1;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Insert as function
        /// </summary>
        /// <param name="data">data as parameter</param>
        /// <param name="position">position as parameter</param>
        /// <returns>returns boolean</returns>
        public bool Insert(int data, long position)
        {
            try
            {
                if (position > this.size)
                {
                    Console.WriteLine("position is greater than existing position");
                    return false;
                }
                else
                {
                    Node n = new Node(data, position);
                    Node temp = this.head;

                    for (int i = 0; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }

                    Node n1 = temp.Next;
                    temp.Next = n;
                    n.Next = n1;
                    temp = null;
                    this.size++;
                    this.Reposition();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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

        /// <summary>
        /// Print function
        /// </summary>
        public void Print()
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("Linked list is empty");
                }
                else
                {
                    Node temp = this.head;
                    while (temp != null)
                    {
                        Console.WriteLine(temp.Data + " " + temp.Position);
                        temp = temp.Next;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Size function
        /// </summary>
        /// <returns>return boolean</returns>
        public long Size()
        {
            return this.size;
        }

        /// <summary>
        /// Reposition function
        /// </summary>
        public void Reposition()
        {
            try
            {
                Node temp = this.head;
                int i = 0;
                while (temp != null)
                {
                    temp.Position = i++;
                    temp = temp.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// WriteFile function
        /// </summary>
        /// <param name="path">path as field</param>
        /// <returns>returns boolean</returns>
        public bool WriteFile(string path)
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("linked list is already empty");
                    return false;
                }
                else
                {
                    Node temp = this.head;
                    using (var writer = new System.IO.StreamWriter("C:/Users/admin/source/repos/DataStructureProgram/DataStructureProgram/OrderedList.txt"))
                    {
                        while (temp != null)
                        {
                            writer.Write(temp.Data.ToString().Trim() + " ");
                            temp = temp.Next;
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

        /// <summary>
        /// Search as function
        /// </summary>
        /// <param name="element">element as parameter</param>
        /// <returns>return boolean</returns>
        internal bool Search(string element)
        {
            throw new NotImplementedException();
        }
    }
}
