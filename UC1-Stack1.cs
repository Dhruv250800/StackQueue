using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class UC1_Stack1
    {
        private Node? top;

        public void Push(int data)
        {
            Node newNode = new Node(data);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }
    }
}
