using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Structures
{
    public class TreeNode
    {
        public int Score { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int score)
        {
            Score = score;
            Left = null;
            Right = null;
        }
    }

}
