


namespace Bag_Data_Structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bag<int> bag = new Bag<int>();
            bag.Add(1);  // O(1) - Adding to the linked list
            bag.Add(2);  // O(1)
            bag.Add(3);  // O(1)
            bag.Add(4);  // O(1)

            BagIterator<int> iterator = bag.Iterator();
            while (iterator.HasNext())  // O(n) - Iterates through all elements in the bag
            {
                Console.WriteLine(iterator.Next());  // O(1) - Retrieves the next element
            }
        }
    }
}