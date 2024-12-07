using Search;
using System;
using System.Diagnostics;
using System.IO;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = DataLoader.LoadData("scores.txt");
            int target = 85;

            Console.WriteLine("Searching Algorithm Performance:");

            RunSearchAlgorithm(scores, "Linear Search", target, SearchAlgorithms.LinearSearch);
            RunSearchAlgorithm(scores, "Binary Search", target, SearchAlgorithms.BinarySearch);
            RunSearchAlgorithm(scores, "Interpolation Search", target, SearchAlgorithms.InterpolationSearch);
        }

        static void RunSearchAlgorithm(int[] array, string algorithmName, int target, Func<int[], int, List<int>> searchAlgorithm)
        {
            var stopwatch = Stopwatch.StartNew();
            List<int> results = searchAlgorithm(array, target);  
            stopwatch.Stop();

            if (results.Count > 0)
            {
                Console.WriteLine($"{algorithmName} took: {stopwatch.ElapsedTicks} ticks - Target found at indices: {string.Join(", ", results)}");
            }
            else
            {
                Console.WriteLine($"{algorithmName} took: {stopwatch.ElapsedTicks} ticks - Target not found");
            }
        }

    }
}
