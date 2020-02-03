using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
    public class MyQueue<T>
    {
        public class QueueNode<T>
        {
            public T data;
            public QueueNode<T> next;
            public QueueNode(T data)
            {
                this.data = data;
            }

        }

        private QueueNode<T> first;
        private QueueNode<T> last;

        public void run()
        {
            MyQueue<int> q = new MyQueue<int>();
            q.add(5);
            q.add(3);
            q.add(8);
            q.add(6);
        }

        public void add(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);

            if (last != null)
            {
                last.next = t;
            }
            last = t;

            if (first == null)
            {
                first = last;
            }

        }

        //Priority queue
        
    }
}
