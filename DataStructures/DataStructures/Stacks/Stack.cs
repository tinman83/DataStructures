 using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
   public class Stack<T>
    {
       private  class StackNode<T>
        {
            public T data;
            public StackNode<T> next;
            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode<T> top;
        public T pop()
        {
            if (top == null) throw EmptyStackException();
            T item = top.data;
            top = top.next;
            return item;
        }
        public void push(T item)
        {
            StackNode<T> t = new StackNode<T>(item); 
            t.next = top;
            top = t;

        }

        public T peek()
        {
            if (top == null) throw EmptyStackException();
            
            return top.data;
        }

        public Boolean isEmpty()
        {
            return top == null;
        }


        private Exception EmptyStackException()
        {
            throw new NullReferenceException();
        }
    }
}
