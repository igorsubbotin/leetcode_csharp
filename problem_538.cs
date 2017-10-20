// 538. Convert BST to Greater Tree - https://leetcode.com/problems/convert-bst-to-greater-tree
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
    public TreeNode ConvertBST(TreeNode root) {
        Traverse(root, 0);
        return root;
    }
    
    private static int Traverse(TreeNode node, int sum) {
        if (node == null) return 0;
        if (node.right != null) node.val += Traverse(node.right, sum);
        else node.val += sum;
        if (node.left != null) return Traverse(node.left, node.val);
        return node.val;
    } 
}