// 513. Find Bottom Left Tree Value - https://leetcode.com/problems/find-bottom-left-tree-value
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
    public int FindBottomLeftValue(TreeNode root) {
        var list = new List<IList<TreeNode>>();
        Traverse(root, list, 0);
        return list.Last().First().val;
    }
    
    private static void Traverse(TreeNode root, IList<IList<TreeNode>> list, int depth) {
        if (root == null) return;
        if (depth == list.Count) list.Add(new List<TreeNode>());
        Traverse(root.left, list, depth + 1);
        list[depth].Add(root);
        Traverse(root.right, list, depth + 1);
    }
}