using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram.PalindromeChecker
{
   public class DequeNode<T>
    {
        private T data;

        private DequeNode <T> next;
        private DequeNode<T> pre;

        public DequeNode(T data)
        {
            this.data = data;
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DequeNode<T>Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public DequeNode<T> Pre
        {
            get { return this.pre; }
            set { this.pre = value; }
        }


    }
}
