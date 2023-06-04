using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class UC2_Stack2
    {
        private Node? top;

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
