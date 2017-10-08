// 173. Binary Search Tree Iterator - https://leetcode.com/problems/binary-search-tree-iterator
/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {
    
    private readonly Stack<TreeNode> s = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        Traverse(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return s.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        var node = s.Pop();
        Traverse(node.right);
        return node.val;
    }
    
    private void Traverse(TreeNode node) {
        if (node == null) return;
        s.Push(node);
        Traverse(node.left);
        node.left = null;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */