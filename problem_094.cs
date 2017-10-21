// 94. Binary Tree Inorder Traversal - https://leetcode.com/problems/binary-tree-inorder-traversal
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var p = root;
        while (stack.Count > 0 || p != null) {
            if (p != null) {
                stack.Push(p);
                p = p.left;
            } else {
                var node = stack.Pop();
                result.Add(node.val);
                p = node.right;
            }
        }
        return result;
    }
}