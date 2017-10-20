// 449. Serialize and Deserialize BST - https://leetcode.com/problems/serialize-and-deserialize-bst
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    private const string Null = "x";
    
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) return string.Empty;
        var list = new List<int?>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0) {
            var node = q.Dequeue();
            if (node == null) {
                list.Add(null);
                continue;
            }
            list.Add(node.val);
            q.Enqueue(node.left);
            q.Enqueue(node.right);
        }
        var end = list.Count - 1;        
        while (end >= 0 && list[end] == null) end--;
        var s = new List<string>();
        for (var i = 0; i < end + 1; i++) {
            if (list[i] == null) s.Add(Null);
            else s.Add(list[i].Value.ToString());
        }
        return string.Join(",", s);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;
        var list = new List<int?>();
        foreach (var each in data.Split(new [] { ',' })) {
            if (each == Null) list.Add(null);
            else list.Add(int.Parse(each));
        }
        if (list.Count == 0 || list[0] == null) return null;
        var root = new TreeNode(list[0].Value);
        var i = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (i < list.Count && q.Count > 0) {
            var node = q.Dequeue();
            var left = i + 1;
            if (left < list.Count && list[left] != null) {
                node.left = new TreeNode(list[left].Value);
                q.Enqueue(node.left);
            }
            var right = i + 2;
            if (right < list.Count && list[right] != null) {
                node.right = new TreeNode(list[right].Value);
                q.Enqueue(node.right);
            }
            i += 2;
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));