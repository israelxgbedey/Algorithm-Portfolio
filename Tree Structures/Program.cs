using System;
using System.Collections.Generic;
using System.IO;
using Tree_Structures;

class Program
{
    static void Main(string[] args)
    {
        List<int> scores = LoadScores("scores.txt");

        List<int> sortedScores = Sorting.QuickSort(scores);

        BinarySearchTree bst = new BinarySearchTree();

        foreach (var score in sortedScores)
        {
            bst.Insert(score);
        }

        List<int> treeSortedScores = bst.InOrderTraversal();

        Console.WriteLine("Sorted Scores from Binary Search Tree:");
        foreach (var score in treeSortedScores)
        {
            Console.WriteLine(score);
        }
    }

    static List<int> LoadScores(string filePath)
    {
        List<int> scores = new List<int>();
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (int.TryParse(line.Trim(), out int score))
                {
                    scores.Add(score);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        return scores;
    }
}
