// 653. Two Sum IV - Input is a BST - https://leetcode.com/problems/two-sum-iv-input-is-a-bst
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
    private TreeNode root;
    
    public bool FindTarget(TreeNode root, int k) {
        var list = new List<int>();
        Traverse(root, list);
        var left = 0;
        var right = list.Count - 1;
        while (left < right) {
            var diff = list[right] + list[left] - k;
            if (diff > 0) right--;
            else if (diff < 0) left++;
            else return true;
        }
        return false;
    }
    
    public void Traverse(TreeNode node, IList<int> list) {
        if (node == null) return;
        Traverse(node.left, list);
        list.Add(node.val);
        Traverse(node.right, list);
    }
}