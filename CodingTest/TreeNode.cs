/*
 * find the sum of all left leaves in a given binary tree
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class TreeNode
    {
        public int data;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            data = item;
            left = right = null;
        }       
    }

    class BinaryTree
    {
        public TreeNode root;
        public virtual bool isLeaf(TreeNode node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.left == null && node.right == null)
            {
                return true;
            }
            return false;
        }

        public virtual int leftLeavesSum(TreeNode node)
        {
            // Initialize result
            int res = 0;

            // Update result if root is not NULL
            if (node != null)
            {
                // If left of root is NULL, then add key of
                // left child
                if (isLeaf(node.left))
                {
                    res += node.left.data;
                }
                else // Else recur for left child of root
                {
                    res += leftLeavesSum(node.left);
                }

                // Recur for right child of root and update res
                res += leftLeavesSum(node.right);
            }

            // return result
            return res;
        }
    }
}
