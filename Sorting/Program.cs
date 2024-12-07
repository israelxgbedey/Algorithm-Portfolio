using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = ArrayUtilities.LoadData("scores.txt");

            Console.WriteLine("Sorting Algorithm Performance:");
            Console.WriteLine($"Array size: {scores.Length}");

            var algorithms = new (string name, Action<int[]> sortAlgorithm)[]
            {
                ("Bubble Sort", SortingAlgorithms.BubbleSort.Sort),
                ("Insertion Sort", SortingAlgorithms.InsertionSort.Sort),
                ("Selection Sort", SortingAlgorithms.SelectionSort.Sort),
                ("HeapSort", SortingAlgorithms.HeapSort.Sort),
                ("Quick Sort", SortingAlgorithms.QuickSortAlgorithm.Sort),
                ("Merge Sort", SortingAlgorithms.MergeSort.Sort)
            };

            foreach (var algorithm in algorithms)
            {
                RunSortAlgorithm(scores, algorithm.name, algorithm.sortAlgorithm);
            }
        }

        static void RunSortAlgorithm(int[] originalArray, string algorithmName, Action<int[]> sortAlgorithm)
        {
            int[] array = (int[])originalArray.Clone();  

            var stopwatch = Stopwatch.StartNew();
            sortAlgorithm(array);  
            stopwatch.Stop();  

            Console.WriteLine($"{algorithmName} took: {stopwatch.ElapsedMilliseconds} ms");

            if (!ArrayUtilities.IsSorted(array))
            {
                Console.WriteLine($"{algorithmName} failed to sort the array correctly!");
            }
        }
    }
}
