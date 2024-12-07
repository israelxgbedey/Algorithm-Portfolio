using System;
using System.IO;

namespace SortingAlgorithms
{
    public static class ArrayUtilities
    {
        public static int[] LoadData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] scores = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                scores[i] = int.Parse(lines[i]);
            }
            return scores;
        }

        public static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i]) return false;
            }
            return true;
        }
    }
}
