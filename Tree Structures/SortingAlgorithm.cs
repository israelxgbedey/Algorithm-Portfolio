using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Structures
{
    public class Sorting
    {
        public static List<int> QuickSort(List<int> scores)
        {
            if (scores.Count <= 1)
                return scores;

            int pivot = scores[scores.Count / 2];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            foreach (var score in scores)
            {
                if (score < pivot)
                    left.Add(score);
                else if (score > pivot)
                    right.Add(score);
            }

            List<int> result = QuickSort(left);
            result.Add(pivot);
            result.AddRange(QuickSort(right));

            return result;
        }
    }

}
