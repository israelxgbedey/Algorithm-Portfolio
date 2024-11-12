using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Data_Structure
{
    public class Bag<T>
    {
        private LinkedList<T> linkedList;
        private int size;

        public Bag()
        {
            linkedList = new LinkedList<T>();  // O(1) - Initializes an empty linked list
            size = 0;  // O(1)
        }

        // O(1) - Adds an element to the bag (at the beginning of the linked list)
        public void Add(T element)
        {
            linkedList.Add(element);
            size++;
        }

        // O(1) - Returns the size of the bag
        public int Size()
        {
            return size;
        }

        // O(1) - Returns an iterator for the bag
        public BagIterator<T> Iterator()
        {
            return new BagIterator<T>(linkedList);
        }
    }
}
