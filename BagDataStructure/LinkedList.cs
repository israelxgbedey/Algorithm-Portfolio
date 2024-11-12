using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Data_Structure
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void Add(T element)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(element);
            newNode.Next = head;
            head = newNode;
        }

        public LinkedListNode<T> GetHead()
        {
            return head;
        }
    }

}
