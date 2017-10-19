// 654. Maximum Binary Tree - https://leetcode.com/problems/maximum-binary-tree
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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return ConstructMaximumBinaryTree(nums, 0, nums.Length - 1);
    }
    
    private static TreeNode ConstructMaximumBinaryTree(int[] nums, int left, int right) {
        var length = right - left + 1;
        if (length <= 0) return null;
        var max = int.MinValue;
        var max_ix = -1;
        for (var i = left; i <= right; i++) {
            if (nums[i] > max) {
                max = nums[i];
                max_ix = i;
            }
        }
        var node = new TreeNode(max);
        node.left = ConstructMaximumBinaryTree(nums, left, max_ix - 1);
        node.right = ConstructMaximumBinaryTree(nums, max_ix + 1, right);
        return node;
    }
}