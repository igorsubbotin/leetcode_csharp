// 101. Symmetric Tree - https://leetcode.com/problems/symmetric-tree
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
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsSymmetric(root.left, root.right);
    }
    
    private static bool IsSymmetric(TreeNode a, TreeNode b) {
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        var s = new Stack<TreeNode[]>();
        s.Push(new [] { a, b });
        while (s.Count > 0) {
            var item = s.Pop();
            if (item[0] == null && item[1] == null) continue;
            if (item[0] == null || item[1] == null) return false;
            if (item[0].val != item[1].val) return false;
            s.Push(new [] { item[0].left, item[1].right });
            s.Push(new [] { item[0].right, item[1].left });
        }
        return true;
    }
}