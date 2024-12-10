using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Structures
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int score)
        {
            root = InsertRec(root, score);
        }

        private TreeNode InsertRec(TreeNode root, int score)
        {
            if (root == null)
            {
                root = new TreeNode(score);
                return root;
            }

            if (score < root.Score)
                root.Left = InsertRec(root.Left, score);
            else if (score > root.Score)
                root.Right = InsertRec(root.Right, score);

            return root;
        }

        public List<int> InOrderTraversal()
        {
            List<int> sortedScores = new List<int>();
            InOrderRec(root, sortedScores);
            return sortedScores;
        }

        private void InOrderRec(TreeNode root, List<int> sortedScores)
        {
            if (root != null)
            {
                InOrderRec(root.Left, sortedScores);
                sortedScores.Add(root.Score);
                InOrderRec(root.Right, sortedScores);
            }
        }
    }

}
