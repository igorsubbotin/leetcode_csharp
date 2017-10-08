// 617. Merge Two Binary Trees - https://leetcode.com/problems/merge-two-binary-trees
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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) return null;
        var val = 0;
        if (t1 != null) val += t1.val;
        if (t2 != null) val += t2.val;
        var t = new TreeNode(val);
        t.left = MergeTrees(t1?.left, t2?.left);
        t.right = MergeTrees(t1?.right, t2?.right);
        return t;
    }
}