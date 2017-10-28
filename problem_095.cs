// 95. Unique Binary Search Trees II - https://leetcode.com/problems/unique-binary-search-trees-ii
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
    public IList<TreeNode> GenerateTrees(int n) {
        var result = new List<TreeNode>();
        var hs = new HashSet<string>();
        foreach (var each in Permutate(n, new HashSet<int>())) {
            var root = CreateTree(each.ToArray());
            if (root == null) continue;
            var data = Serialize(root);
            if (!hs.Contains(data)) {
                hs.Add(data);
                result.Add(root);
            }
        }
        return result;
    }
    
    private static IList<IList<int>> Permutate(int n, HashSet<int> skip) {
        var result = new List<IList<int>>();
        if (n == skip.Count) return new List<IList<int>> { new List<int>() };
        for (var i = 1; i <= n; i++) {
            if (skip.Contains(i)) continue;
            skip.Add(i);
            foreach (var each in Permutate(n, skip)) {
                each.Add(i);
                result.Add(each);
            }
            skip.Remove(i);
        }
        return result;
    }
    
    private static TreeNode CreateTree(int[] list) {
        if (list.Length == 0) return null;
        var root = new TreeNode(list[0]);
        foreach (var n in list) InsertNode(root, n);
        return root;
    }
    private static void InsertNode(TreeNode root, int val) {
        if (root == null) return;
        if (root.val > val) {
            if (root.left != null) InsertNode(root.left, val);
            else root.left = new TreeNode(val);
        } else if (root.val < val) {
            if (root.right != null) InsertNode(root.right, val);
            else root.right = new TreeNode(val);
        }
    }
    private static string Serialize(TreeNode root) {
        var list = new List<int?>();
        Traverse(root, list);
        var end = list.Count - 1;
        while (end >= 0 && list[end] == null) end--;
        var str = new List<string>();
        for (var i = 0; i < end + 1; i++) {
            if (list[i] == null) str.Add("null");
            else str.Add(list[i].Value.ToString());
        }
        return string.Join(",", str);
    }
    private static void Traverse(TreeNode root, IList<int?> list) {
        if (root == null) {
            list.Add(null);
            return;
        }
        list.Add(root.val);
        Traverse(root.left, list);
        Traverse(root.right, list);
    }
}