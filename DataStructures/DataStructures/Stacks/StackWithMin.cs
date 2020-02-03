using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
   public class StackWithMin : Stack<NodeWithMin>
    {

        public void push(int value)
        {
            int newMin = Math.Min(value, min());
            base.push(new NodeWithMin(value, newMin));
        }

        public int min()
        {
            if (this.isEmpty())
                return int.MaxValue;
            else
                return base.peek().min;
        }

    } 

    public class NodeWithMin
    {
        public int value;
        public int min;
        public NodeWithMin(int v,int min)
        {
            value = v;
            this.min = min;
        }

    }
}
