// 102. Binary Tree Level Order Traversal - https://leetcode.com/problems/binary-tree-level-order-traversal
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var list = new List<IList<int>>();
        Traverse(root, 0, list);
        return list;
    }
    
    private static void Traverse(TreeNode node, int depth, IList<IList<int>> list) {
        if (node == null) return;
        if (depth == list.Count) list.Add(new List<int>());
        list[depth].Add(node.val);
        Traverse(node.left, depth + 1, list);
        Traverse(node.right, depth + 1, list);
    }
}