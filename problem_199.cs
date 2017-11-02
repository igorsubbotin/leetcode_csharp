// 199. Binary Tree Right Side View - https://leetcode.com/problems/binary-tree-right-side-view
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
    public IList<int> RightSideView(TreeNode root) {
        var levels = new List<IList<int>>();
        Traverse(root, 0, levels);
        var result = new List<int>();
        foreach (var level in levels) result.Add(level.Last());
        return result;
    }
    
    private static void Traverse(TreeNode root, int depth, IList<IList<int>> levels) {
        if (root == null) return;
        if (levels.Count == depth) levels.Add(new List<int>());
        Traverse(root.left, depth + 1, levels);
        levels[depth].Add(root.val);
        Traverse(root.right, depth + 1, levels);
    }
}