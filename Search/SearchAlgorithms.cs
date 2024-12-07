using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class SearchAlgorithms
    {
        public static List<int> LinearSearch(int[] array, int target)
        {
            List<int> indices = new List<int>();  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    indices.Add(i);  
                }
            }
            return indices;  
        }


        public static List<int> BinarySearch(int[] array, int target)
        {
            List<int> indices = new List<int>();  
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == target)
                {
                    indices.Add(mid);

                    int left = mid - 1;
                    while (left >= 0 && array[left] == target)
                    {
                        indices.Add(left);
                        left--;
                    }

                    int right = mid + 1;
                    while (right < array.Length && array[right] == target)
                    {
                        indices.Add(right);
                        right++;
                    }

                    break;  
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return indices; 
        }


        public static List<int> InterpolationSearch(int[] array, int target)
        {
            List<int> indices = new List<int>(); 
            int low = 0;
            int high = array.Length - 1;

            while (low <= high && target >= array[low] && target <= array[high])
            {
             
                if (array[high] == array[low])
                {
                    break;
                }

                
                int pos = low + ((target - array[low]) * (high - low)) / (array[high] - array[low]);

                if (array[pos] == target)
                {
                    indices.Add(pos);

                  
                    int left = pos - 1;
                    while (left >= low && array[left] == target)
                    {
                        indices.Add(left);
                        left--;
                    }

                    
                    int right = pos + 1;
                    while (right <= high && array[right] == target)
                    {
                        indices.Add(right);
                        right++;
                    }

                    break; 
                }
                else if (array[pos] < target)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }

            return indices; 
        }

    }
}
