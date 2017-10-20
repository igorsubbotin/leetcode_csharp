// 652. Find Duplicate Subtrees - https://leetcode.com/problems/find-duplicate-subtrees
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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var result = new List<TreeNode>();
        Traverse(root, new Dictionary<string, int>(), result);
        return result;
    }
    
    private static string Traverse(TreeNode root, IDictionary<string, int> d, IList<TreeNode> result) {
        if (root == null) return "#";
        var key = root.val + "L" + Traverse(root.left, d, result) + "R" + Traverse(root.right, d, result);
        if (!d.ContainsKey(key)) d[key] = 0;
        d[key]++;
        if (d[key] == 2) result.Add(root);
        return key;
    }
}