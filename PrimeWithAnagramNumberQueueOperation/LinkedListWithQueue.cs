using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.PrimeWithAnagramNumberQueueOperation
{
    class LinkedListWithQueue
    {
        private Node front;

        private Node rear;

        private int size = 0;

        public LinkedListWithQueue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        public void EnqueueOperation(object data)
        {
            try
            {
                Node node = new Node(data);
                if (this.rear == null)
                {
                    this.front = this.rear = node;
                }
                else
                {
                    Node temp = this.rear.GetNext();
                    temp = node;
                    this.rear = node;
                }
                this.size++;
                Console.Write(data + " ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DequeueOpration()
        {
            try
            {
                if(this.front == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Node temp = this.front;
                this.front = this.front.GetNext();

                if (this.front ==null)
                {
                    this.rear = null;
                }
                this.size--;

                Console.WriteLine("Deleted Element  is {0}", temp.GetData());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintFunction()
        {
            try
            {
                if(this.IsEmptyFunction())
                {
                    Console.WriteLine("Empty Queue");
                }
                Node temp = this.rear;

                while(temp!= null)
                {
                    Console.WriteLine(temp.GetData()+ "  ");
                    temp = temp.GetNext();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Count()
        {
                return this.size;
        }

        public bool IsEmptyFunction()
        {
            if (this.size ==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
