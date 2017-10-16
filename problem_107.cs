// 107. Binary Tree Level Order Traversal II - https://leetcode.com/problems/binary-tree-level-order-traversal-ii
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var list = new List<IList<int>>();
        Traverse(root, list, 0);
        list.Reverse();
        return list;
    }
    
    private static void Traverse(TreeNode root, IList<IList<int>> list, int depth) {
        if (root == null) return;
        if (list.Count == depth) list.Add(new List<int>());
        Traverse(root.left, list, depth + 1);
        list[depth].Add(root.val);
        Traverse(root.right, list, depth + 1);
    }
}