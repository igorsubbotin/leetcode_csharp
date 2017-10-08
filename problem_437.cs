// 437. Path Sum III - https://leetcode.com/problems/path-sum-iii
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
    public int PathSum(TreeNode root, int sum) {
        var result = 0;
        Traverse(root, sum, ref result);
        return result;
    }
    
    private static int[] Traverse(TreeNode node, int sum, ref int count) {
        if (node == null) return new int[0];
        var result = new List<int> { node.val };
        foreach (var each in Traverse(node.left, sum, ref count)) result.Add(each + node.val);
        foreach (var each in Traverse(node.right, sum, ref count)) result.Add(each + node.val);
        foreach (var value in result) if (value == sum) count++;
        return result.ToArray();
    }
}