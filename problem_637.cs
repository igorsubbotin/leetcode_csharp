// 637. Average of Levels in Binary Tree - https://leetcode.com/problems/average-of-levels-in-binary-tree
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
    public IList<double> AverageOfLevels(TreeNode root) {
        var levels = new List<IList<int>>();
        Traverse(root, 0, levels);
        var result = new List<double>();
        foreach (var level in levels) {
            var sum = 0.0;
            foreach (var value in level) sum += value;
            result.Add(sum / level.Count);
        }
        return result;
    }
    
    private static void Traverse(TreeNode node, int level, IList<IList<int>> levels) {
        if (node == null) return;
        if (level == levels.Count) levels.Add(new List<int>());
        levels[level].Add(node.val);
        Traverse(node.left, level + 1, levels);
        Traverse(node.right, level + 1, levels);
    }
}