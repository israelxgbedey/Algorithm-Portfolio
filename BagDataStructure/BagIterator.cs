using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Data_Structure
{
    public class BagIterator<T>
    {
        private List<T> elements;
        private Random random;

        public BagIterator(LinkedList<T> linkedList)
        {
            elements = new List<T>();
            LinkedListNode<T> current = linkedList.GetHead();
            while (current != null)
            {
                elements.Add(current.Value);
                current = current.Next;
            }
            random = new Random();
            Shuffle();
        }

        private void Shuffle()
        {
            int n = elements.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + random.Next(n - i);
                T temp = elements[r];
                elements[r] = elements[i];
                elements[i] = temp;
            }
        }

        public bool HasNext()
        {
            return elements.Count > 0;
        }

        public T Next()
        {
            if (!HasNext()) throw new InvalidOperationException();
            T nextElement = elements[0];
            elements.RemoveAt(0);
            return nextElement;
        }
    }

}
