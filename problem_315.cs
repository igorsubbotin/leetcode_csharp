// 315. Count of Smaller Numbers After Self - https://leetcode.com/problems/count-of-smaller-numbers-after-self
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var result = new int[nums.Length];
        if (nums.Length == 0) return result.ToList();
        var root = new TreeNode(nums[nums.Length - 1]);
        for (var i = nums.Length - 2; i >= 0; i--) result[i] = Insert(root, nums[i], 0).count;
        return result.ToList();
    }
    private static TreeNode Insert(TreeNode root, int val, int top_count) {
        root.count = top_count + root.left_count;
        if (root.val >= val) {
            root.count++;
            root.left_count++;
            if (root.left == null) {
                var node = new TreeNode(val);
                node.count = top_count;
                root.left = node;
                return node;
            } else return Insert(root.left, val, top_count);
        } else {
            if (root.right == null) {
                var node = new TreeNode(val);
                node.count = root.count + 1;
                root.right = node;
                return node;
            } else return Insert(root.right, val, root.count + 1);
        }
    }
}

public class TreeNode {
    public int val;
    public int count;
    public int left_count;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val) {
        this.val = val;
    }
}