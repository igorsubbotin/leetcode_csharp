// 103. Binary Tree Zigzag Level Order Traversal - https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var list = new List<IList<int>>();
        Traverse(root, 0, list);
        for (var i = 0; i < list.Count; i++) {
            if (i % 2 == 1) {
                ((List<int>)list[i]).Reverse();
            }
        }
        return list;
    }
    
    private static void Traverse(TreeNode node, int depth, IList<IList<int>> list) {
        if (node == null) return;
        if (depth == list.Count) list.Add(new List<int>());
        list[depth].Add(node.val);
        Traverse(node.left, depth + 1, list);
        Traverse(node.right, depth + 1, list);
    }
}