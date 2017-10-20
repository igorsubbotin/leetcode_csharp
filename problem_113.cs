// 113. Path Sum II - https://leetcode.com/problems/path-sum-ii
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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var list = dfs(root, sum);
        foreach (var each in list) ((List<int>)each).Reverse();
        return list;
    }
    
    private static IList<IList<int>> dfs(TreeNode root, int sum) {
        var list = new List<IList<int>>();
        if (root == null) return list;
        sum -= root.val;
        if (sum == 0 && root.left == null && root.right == null) {
            list.Add(new List<int> { root.val });
            return list;
        }
        foreach (var each in dfs(root.left, sum)) list.Add(each);
        foreach (var each in dfs(root.right, sum)) list.Add(each);
        foreach (var each in list) each.Add(root.val);
        return list;
    }
}