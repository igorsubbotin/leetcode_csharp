// 99. Recover Binary Search Tree - https://leetcode.com/problems/recover-binary-search-tree
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
    public void RecoverTree(TreeNode root) {
        if (root == null) return;
        var list = new List<TreeNode>();
        Traverse(root, list);
        var sorted = list.OrderBy(x => x.val).Select(x => x.val).ToList();
        for (var i = 0; i < list.Count; i++) {
            list[i].val = sorted[i];
        }
    }
    
    private static void Traverse(TreeNode root, IList<TreeNode> list) {
        if (root == null) return;
        Traverse(root.left, list);
        list.Add(root);
        Traverse(root.right, list);
    }
}