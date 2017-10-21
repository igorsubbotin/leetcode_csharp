// 145. Binary Tree Postorder Traversal - https://leetcode.com/problems/binary-tree-postorder-traversal
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
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var p = root;
        while (stack.Count > 0 || p != null) {
            if (p != null) {
                stack.Push(p);
                result.Insert(0, p.val);
                p = p.right;
            } else {
                var node = stack.Pop();
                p = node.left;
            }
        }
        return result;
    }
}