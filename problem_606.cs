// 606. Construct String from Binary Tree - https://leetcode.com/problems/construct-string-from-binary-tree
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
    public string Tree2str(TreeNode t) {
        var sb = new StringBuilder();
        Traverse(t, sb, true);
        return sb.ToString();
    }
    
    private void Traverse(TreeNode node, StringBuilder sb, bool noWrap = false) {
        if (!noWrap) sb.Append("(");
        if (node != null) {
            sb.Append(node.val.ToString());
            if (node.left != null) Traverse(node.left, sb);
            if (node.right != null) {
                if (node.left == null) Traverse(node.left, sb);
                Traverse(node.right, sb);
            }
        }
        if (!noWrap) sb.Append(")");
    }
}