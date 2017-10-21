// 98. Validate Binary Search Tree - https://leetcode.com/problems/validate-binary-search-tree
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
    public bool IsValidBST(TreeNode root) {
        var list = new List<int>();
        Traverse(root, list);
        for (var i = 1; i < list.Count; i++)
            if (list[i - 1] >= list[i]) return false;
        return true;
    }
    
    private static void Traverse(TreeNode node, IList<int> list) {
        if (node == null) return;
        Traverse(node.left, list);
        list.Add(node.val);
        Traverse(node.right, list);
    }
}