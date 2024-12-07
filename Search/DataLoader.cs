using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class DataLoader
    {
        public static int[] LoadData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] scores = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                scores[i] = int.Parse(lines[i]);
            }
            Array.Sort(scores);
            return scores;
        }
    }
}