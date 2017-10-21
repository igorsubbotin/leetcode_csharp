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
        if (root == null) return result;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var right = new Stack<TreeNode>();
        while (q.Count > 0 || right.Count > 0) {
            while (q.Count > 0) {
                var node = q.Dequeue();
                if (node.left == null && node.right == null) result.Add(node.val);
                else {
                    if (node.left != null) q.Enqueue(node.left);
                    right.Push(node);
                }
            }
            while (right.Count > 0) {
                var node = right.Pop();
                if (node.right != null) q.Enqueue(node.right); 
                result.Add(node.val);
                break;
            }
        }
        return result;
    }
}