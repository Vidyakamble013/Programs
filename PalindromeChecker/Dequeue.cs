using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.PalindromeChecker
{
   public  class Dequeue<T>
    {
        private DequeNode<T> front;

        private DequeNode<T> rear;

        private long size = 0;

        public void AddToFront(T data)
        {
            try
            {
                if (this.front == null)
                {
                    this.front.Data = data;
                    this.rear = this.front;
                }
                else
                {
                    DequeNode<T> tempNode = null;
                    tempNode.Data = data;
                    tempNode.Next = this.front;
                    this.front.Pre = tempNode;
                    this.front = tempNode;
                }
                this.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddToRear(T data)
        {
            try
            {
                if (this.front == null)
                {
                    DequeNode<T> dequeNode = new DequeNode<T>(data);
                    this.front = dequeNode;
                    this.rear = this.front;
                }
                else
                {
                    DequeNode<T> dequeNode = new DequeNode<T>(data);
                    this.rear.Next = dequeNode;
                    dequeNode.Pre = this.rear;
                    this.rear = dequeNode;
                }
                this.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public T RemoveToFront()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Already empty");
                }
                else
                {
                    dataToRemove = this.front.Data;
                    this.front = this.front.Next;
                }
                this.size--;
                return dataToRemove;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T RemoveToRear()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Already Empty");
                }
                else
                {
                    dataToRemove = this.rear.Data;
                    this.rear = this.rear.Pre;
                    this.rear.Next = null;
                }
                this.size--;
                return dataToRemove;
            }
            catch (Exception ex)
            {
              throw new Exception(ex.Message);
                
            }
        }

        public bool IsEmpty()
        {
            try
            {
                if(this.front == null)
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

        public long Size()
        {
            try
            {
                return this.size;
               
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

    }
}
